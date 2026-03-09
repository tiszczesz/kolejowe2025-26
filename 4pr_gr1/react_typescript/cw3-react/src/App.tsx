import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import InputComp from './components/InputComp'


function App() {
 
 console.log('render App')
  return (
    <>
     <h1>cw3-react z bootstrap</h1>
      <InputComp />
      <InputComp myValue='Ello' />
      <InputComp myValue='Ala ma kota' />
    </>
  )
}

export default App
