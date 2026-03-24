import { NavLink, Outlet } from "react-router"



const Layout = () => {
  return (
    <div>
      <header>
        <nav className="d-flex gap-2">
          <NavLink to="/">Home</NavLink>
          <NavLink to="/about">About</NavLink>
          <NavLink to="/contact">Contact</NavLink>
          <NavLink to="/myform">formularz 1</NavLink>
        </nav>
      </header>
      <main>
        <Outlet />
      </main>
      <footer>&copy; 2026 My App. All rights reserved.</footer>
    </div>
  )
}

export default Layout