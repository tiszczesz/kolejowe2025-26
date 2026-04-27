import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { useEffect, useState, useRef } from 'react'

function App() {
  const [info, setInfo] = useState('')
  const refInput = useRef<HTMLInputElement>(null)
  console.log('rendering App component')
  useEffect(() => {
    //co ma miejsce po pierwszym renderowaniu komponentu
    console.log('wykonuje się useEffect')
    if (refInput.current) {
      refInput.current.focus()
      
    }
  }, [info]) //tablica zależności, jeśli info się zmieni to useEffect się wykona;
  return (
    <main className='container'>
      <h1 className='text-center'>Hello, World! useEffect</h1>
      <section>
        <input type="range" name="" id="" /><br />
        <input ref={refInput} type="text" onChange={(e) => setInfo(e.target.value)} value={info} />
        <span>{info}</span>
      </section>
    </main>
  )
}

export default App
