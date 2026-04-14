import { NavLink, Outlet } from "react-router";

function Layout() {
  return (
    <>
      <header>
        <nav
          className="d-flex gap-3 p-3"
          style={{ backgroundColor: "#c4bfbf" }}
        >
          <NavLink className="nav-link" to="/">
            Home
          </NavLink>
          <NavLink className="nav-link" to="/about">
            About
          </NavLink>
          <NavLink className="nav-link" to="/contact">
            Contact
          </NavLink>
          <NavLink className="nav-link" to="/form1">
            Formularz 1
          </NavLink>
          <NavLink className="nav-link" to="/galeria">
            Galeria zdjęć
          </NavLink>

          <NavLink className="nav-link" to="/dishes">
            Posiłki
          </NavLink>
          <NavLink className="nav-link" to="/timer">
            Timer
          </NavLink>
        </nav>
      </header>
      <main className="container mt-3">
        <Outlet />
      </main>
      {/* <footer
        style={{
          padding: "10px",
          position: "absolute",
          textAlign: "center",
          bottom: 0,
          width: "100%",
          height: "45px",
          backgroundColor: "#c4bfbf",
        }}
      >
        &copy; {new Date().getFullYear()} My App. All rights reserved.
      </footer> */}
    </>
  );
}

export default Layout;
