import './App.css'
import react from './assets/react.svg'
function App() {
  const info = "ala ma kota sd s s sds";
  return (
    // <>

    //  <h1>Dssfsd fsdf sd </h1>
    //  <h3>Witaj w aplikacji React!</h3>
    //  <ul>
    //   <li>dsasad</li>
    //   <li>asdas</li>
    //   <li>asdasd</li>
    //  </ul>
    // </>
    <>
      <h3>{info}</h3>
      <h2>sadadadas</h2>
      <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Necessitatibus nulla et ullam? Vitae commodi ratione a ducimus alias! Voluptatibus, nulla assumenda! Eaque iusto esse eius quaerat deleniti tempore, ex consequatur!</p>
      <img src="vite.svg" alt="ikona" />
      <img src="vite.svg" alt="ikona" />
      <img src="vite.svg" alt="ikona" />
      <img src={react} alt="ikona" />
 
       <div>{4+4}</div>
       <div>{new Date().toLocaleDateString()}</div>
        <FakeComponent />
        <SecondComponent />
        <Motylek />
    </>

  )
}
function FakeComponent() {
  return(<h2>To jest komponent FAKE</h2>)
}
function SecondComponent() {
  return "To jest komponent SECOND"
}
function Motylek(){
  return (     
  <img
       style={{
        width: "200px",
        padding: "20px",
        border: "2px solid black",
        margin: "20px"
       }}
       src="motylek1.jpg" alt="ikona" />)
}


export default App
