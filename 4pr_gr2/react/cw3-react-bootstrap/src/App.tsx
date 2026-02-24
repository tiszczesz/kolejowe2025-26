
import  {type MouseEvent } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import './App.css'
import Info from './components/Info';
const list = ["jeden", "dwa", "trzy"];
function App() {
  

  function handleClick(event: MouseEvent<HTMLButtonElement>): void {
    console.log("kliknięto przycisk");
  }

  return (
    <>
      <main className='container'>
        <h1>Nowa aplikacja React z Bootstrap</h1>
        <ul>
          {list.map((elem,index)=>(
            <li key={index}>{elem}</li>
          ))}
        </ul>
        <ol>
          <li>sadsad</li>
          <li>www</li>
          <li>ddd</li>
          <li>eee</li>
        </ol>
        <button 
        onClick={handleClick}
         className="btn btn-primary">
          Kliknij mnie
        </button>
        <Info />
      </main>
    </>
  )
}

export default App
