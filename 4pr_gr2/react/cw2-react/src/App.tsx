
import './App.css'
import Circle from './components/Circle'
import Rectangle from './components/Rectangle'

function App() {
  

  return (
    <>
     <div>
      <Circle size={50}/>
      <Circle size={100} color='green'/>
     </div>
     <hr />
     <Rectangle myColr='pink'/>
     <Rectangle />
    </>
  )
}

export default App
