import './App.css'
import Component1 from './components/Component1';
import MyInfo from './components/MyInfo';
import Rectangle from './components/Rectangle';

function App() {


  return (
    <>
      <h1>Hello from React</h1>
      <p>Akapit a App.tsx</p>
      <hr />
      <Component1 />
      <MyInfo myColor='green' content='ala ma kota' />
      <MyInfo myColor='blue' content='ala ma psa' />
      <MyInfo myColor='black' content='ala ma psa' myOpacity={0.6} />
      <MyInfo myColor='red' content='ala ma psa' myOpacity={0.3}/>
      <ul>
        <li>asdasd</li>
        <li>asdasd</li>
        <li>asdasd</li>
      </ul>
      <hr />
      <Rectangle width={200} height={100} color='red' />
      <Rectangle width={100} height={60} color='green' />
      <Rectangle width={30} height={120} color='blue' />
    </>
  )
}

export default App
