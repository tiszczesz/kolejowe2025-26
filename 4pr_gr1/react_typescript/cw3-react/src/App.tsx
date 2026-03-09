import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import InputComp from './components/InputComp'
import Input2Comp from './components/Input2Comp'
import InputText from './components/InputText'


function App() {

  console.log('render App')
  return (
    <>
      <h1>cw3-react z bootstrap</h1>
      <InputComp />
      <InputComp myValue='Ello' />
      <InputComp myValue='Ala ma kota' />
      <hr />
      <Input2Comp myValue='cc' />
      <hr />
      <InputText label='Podaj imię' />
    </>
  )
}

export default App
