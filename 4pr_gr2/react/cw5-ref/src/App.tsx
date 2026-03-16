import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css'
import CompWithChildren from './components/CompWithChildren';

function App() {


  return (
    <>
      <h1>Hello from cw5</h1>
      <CompWithChildren myColor="yellow">ala ma kota</CompWithChildren>
      <CompWithChildren>
        <h2>lorem ipsum</h2>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptas, voluptate.</p>
      </CompWithChildren>
      <CompWithChildren bacColor='lightgreen'>
        <ul style={{ listStyleType: "none" }}>
          <li>item1</li>
          <li>item2</li>
          <li>item3</li>
        </ul>
      </CompWithChildren>

    </>
  )
}

export default App
