import { Link, Outlet } from 'react-router-dom'

export default function Navbar() {
  return (
    <>
      <nav>
        <div id='titulo'>
          <Link to='/'>Home</Link>
        </div>
        <div id='itens'>
          <Link to='/Sobre'>Sobre</Link>
          <Link to='/Competencias'>Competências</Link>
          <Link to='/Portfolio'>Portfólio</Link>
        </div>
      </nav>

      <Outlet />
    </>
  )
}
