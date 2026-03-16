import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import SelectFirst from './components/SelectFirst';
const colors = ['white', 'black', 'red', 'blue', 'yellow', 'green', 'orange',
  'pink', 'purple', 'brown', '#345632'];


function App() {

  return (
    <>
      <h1>Ćwiczenie 4</h1>
      <SelectFirst myColors={colors} />
    </>
  )
}

export default App
