import "./App.css";
import "bootstrap/dist/css/bootstrap.css";
import First from "./components/First";
function App() {
  return (
    <>
      <First title="To jest First" myColor="red" content="lorem ipsum..." />
      <First title="Bez koloru" content="ala ma kota" isBordered={true} />
      <First
        title="Inny tytuł"
        myColor="blue"
        content="ambitna treść komponentu"
      />
    </>
  );
}

export default App;
