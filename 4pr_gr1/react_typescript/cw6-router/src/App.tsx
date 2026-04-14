import "bootstrap/dist/css/bootstrap.min.css";
import "./App.css";
import { createBrowserRouter, RouterProvider } from "react-router";
import Layout from "./components/Layout";
import Home from "./pages/Home";
import About from "./pages/About";
import Contact from "./pages/Contact";
import PageNotFound from "./pages/PageNotFound";
import MyForm1 from "./pages/MyForm1";
import FotoGallery from "./pages/FotoGallery";
import Listdishes from "./pages/Listdishes";

const router = createBrowserRouter([
  {
    path: "/",
    element: <Layout />,
    children: [
      //elementy do Outlet
      { index: true, element: <Home /> },
      { path: "about", element: <About /> },
      { path: "contact", element: <Contact /> },
      { path: "form1", element: <MyForm1 /> },
      { path: "galeria", element: <FotoGallery /> },
      { path: "dishes", element: <Listdishes /> },
      { path: "*", element: <PageNotFound /> },
    ],
  },
]);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
