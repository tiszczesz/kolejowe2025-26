import { NavLink, Outlet } from "react-router";

const Layout = () => {
  return (
    <div style={{ position: "relative" , minHeight: "100vh", paddingBottom: "3rem" }}>
      <header>
        <nav className="d-flex gap-4 bg-light p-3">
          <NavLink className="myNav-link" to="/">
            Home
          </NavLink>
          <NavLink className="myNav-link" to="/about">
            About
          </NavLink>
          <NavLink className="myNav-link" to="/contact">
            Contact
          </NavLink>
          <NavLink className="myNav-link" to="/myform">
            Formularz 1
          </NavLink>
          <NavLink className="myNav-link" to="/images">
            Obrazy
          </NavLink>
        </nav>
      </header>
      <main>
        <Outlet />
      </main>
      <footer
        style={{
          position: "absolute",
          bottom: 0,
          width: "100%",
          textAlign: "center",
          padding: "1rem",
          backgroundColor: "#f8f9fa",
        }}
      >
        &copy; 2026 My App. All rights reserved.
      </footer>
    </div>
  );
};

export default Layout;
