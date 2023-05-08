import Navbar from './components/Navbar.jsx'
import Home from './pages/Home.jsx'
import Competencias from './pages/Competencias.jsx'
import Portfolio from './pages/Portfolio.jsx'
import Sobre from './pages/Sobre.jsx'
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'
import './App.css'

function App() {

  return (
    <div id='fundo'>
    <Router>
      <Navbar />
      <Routes>
        <Route exact path="/" element={<Home />} />
        <Route path="/sobre" element={<Sobre />} />
        <Route path="/competencias" element={<Competencias />} />
        <Route path="/portfolio" element={<Portfolio />} />
      </Routes>
    </Router>
    </div>
  )
}

export default App
