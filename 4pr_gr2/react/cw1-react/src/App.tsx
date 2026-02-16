import './App.css'
import Component1 from './components/Component1';
import MyInfo from './components/MyInfo';

function App() {


  return (
    <>
      <h1>Hello from React</h1>
      <p>Akapit a App.tsx</p>
      <hr />
      <Component1 />
      <MyInfo myColor='green' content='ala ma kota' />
      <MyInfo myColor='blue' content='ala ma psa' />
      <ul>
        <li>asdasd</li>
        <li>asdasd</li>
        <li>asdasd</li>
      </ul>
    </>
  )
}

export default App
