using System.Net;
using System.Text;

namespace start{
    class Program{
        static void Main(string[] args){

            using var listener = new HttpListener();
            listener.Prefixes.Add("http://*:8001/");
            listener.Start();

            Console.WriteLine("Listening on port 8001...");

            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                using HttpListenerResponse resp = context.Response;

        
                resp.Headers.Set("Content-Type", "text/html; charset=utf-8");

                string filePath = "/frontend/index.html";

                if (File.Exists(filePath))
                {
                   
                    byte[] buffer = File.ReadAllBytes(filePath);
                    resp.ContentLength64 = buffer.Length;


                    using Stream ros = resp.OutputStream;
                    ros.Write(buffer, 0, buffer.Length);
                }
                else
                {

                    resp.StatusCode = 404;
                    byte[] errorBuffer = Encoding.UTF8.GetBytes("Błąd: Nie znaleziono pliku index.html");
                    resp.OutputStream.Write(errorBuffer, 0, errorBuffer.Length);
                }
            }
        }
    }
}