import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css'
import CompWithChildren from './components/CompWithChildren';
import FormRef from './components/FormRef';

function App() {


  return (
    <>
      <h1>Hello from cw5</h1>
      <CompWithChildren myColor="yellow">ala ma kota</CompWithChildren>
  
      <CompWithChildren  myColor="lightgreen">
        <ul style={{ listStyleType: "none" }}>
          <li>item1</li>
          <li>item2</li>
          <li>item3</li>
        </ul>
      </CompWithChildren>
      <FormRef/>

    </>
  )
}

export default App
