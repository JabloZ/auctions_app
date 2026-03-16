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
        <div className='HomePageBox'>
            <h1>Search for auctions:</h1>
            <button onClick={testApi}>przycisk</button>
            <div className="search-container">
                <input type="text" placeholder="Search data..." className="search-bar"/>
                 <button onClick={testApi}>Search</button>
            </div>
        </div>
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