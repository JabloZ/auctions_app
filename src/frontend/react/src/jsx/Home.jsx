import '../css/Home.css'
function Home(){
    const testApi = () => {
    fetch('/api')
      .then(res => res.text())
      .then(data => alert("Serwer odpowiedział: " + data))
      .catch(err => alert("Błąd połączenia: " + err));
  };
    return (
        <>
        <h1>Home page</h1>
        <p className="napis">agasgas</p>
        <button onClick={testApi}>przycisk</button>
        </>
    )
}
function Auction(){
    return(
        <>
        
        </>
    )
}
export default Home