import { useState } from 'react'
//import reactLogo from './assets/react.svg'
//import viteLogo from '/vite.svg'
import './App.css'

function App() {
  const [count, setCount] = useState(0)
  const testApi = () => {
    fetch('/api')
      .then(res => res.text())
      .then(data => alert("Serwer odpowiedział: " + data))
      .catch(err => alert("Błąd połączenia: " + err));
  };
  
  return (
    
    <>
    <h1>aaa</h1>
      <div>
        
      </div>
      <h1>Vite + React</h1>
      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>
        <p>
          Edit <code>src/App.jsx</code> and save to test HMR
        </p>
      </div>
      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>
        <div style={{ padding: '50px' }}>
          <h1>Test Połączenia</h1>
          <button onClick={testApi}>KLIKNIJ MNIE</button>
        </div>
    </>
  )
}

export default App
