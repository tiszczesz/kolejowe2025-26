import { Outlet } from "react-router";

type Props = {};

function Layout({}: Props) {
  return (
    <>
      <header>
        <nav></nav>
      </header>
      <main>
        <Outlet />
      </main>
      <footer
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
      </footer>
    </>
  );
}

export default Layout;
