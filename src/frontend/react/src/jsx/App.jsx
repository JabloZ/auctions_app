import { useState } from 'react'
import { BrowserRouter, Routes, Route, Link} from 'react-router-dom'
import Home from './Home.jsx'
//import reactLogo from './assets/react.svg'
//import viteLogo from '/vite.svg'
import '../css/App.css'

function App() {
  const [count, setCount] = useState(0)
  const testApi = () => {
    fetch('/api')
      .then(res => res.text())
      .then(data => alert("Serwer odpowiedział: " + data))
      .catch(err => alert("Błąd połączenia: " + err));
  };
  
  return (
    
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Home />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App
