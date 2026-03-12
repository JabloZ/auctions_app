using System;
using System.Net;
using System.Text;
using Npgsql;
namespace Start {
    class Start {
        public async Task RunDatabaseOperations()
            {
                var connString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
                await using var conn = new NpgsqlConnection(connString);
                await conn.OpenAsync();

                await using (var cmd = new NpgsqlCommand("SELECT * FROM users", conn))
                await using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        Console.WriteLine(reader.GetInt32(0));
                    }
                }
        }
        public static async Task Main(string[] args) {
            using var listener = new HttpListener();
            listener.Prefixes.Add("http://*:8001/");
            listener.Start();
            Console.WriteLine("Serwer działa na http://localhost:8001/");
            
            while (true) {
                Console.WriteLine("react");
                HttpListenerContext context = listener.GetContext();
                HttpListenerResponse resp = context.Response;

                resp.AddHeader("Access-Control-Allow-Origin", "*");
                resp.AddHeader("Access-Control-Allow-Methods", "GET, POST, OPTIONS");
                resp.AddHeader("Access-Control-Allow-Headers", "Content-Type");

                if (context.Request.HttpMethod == "OPTIONS") {
                    resp.StatusCode = (int)HttpStatusCode.OK;
                    resp.Close();
                    continue;
                }

                string responseString = "{\"message\": \"Dziala z C#!\"}";
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                
                resp.ContentType = "application/json";
                resp.ContentLength64 = buffer.Length;
                
                using (var output = resp.OutputStream) {
                    output.Write(buffer, 0, buffer.Length);
                }
                var app=new Start();
                await app.RunDatabaseOperations();
                Console.WriteLine("Wysłano odpowiedź do Reacta");
            }
        }
    }
}