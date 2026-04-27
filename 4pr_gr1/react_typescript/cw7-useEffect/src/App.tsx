import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { useEffect, useRef, useState } from 'react'
import ClockTimer from './components/ClockTimer';

function App() {
  //głóna częśc komponentu
  console.log('render')
  const [info, setInfo] = useState('');
  const inputRef = useRef<HTMLInputElement>(null);
  useEffect(() => {
    console.log('useEffect');
    if (inputRef.current) {
      //focusowanie inputa po pierwszym renderze
      inputRef.current.focus();
    }
  }, []);

  return (
    <>
      <h1 className='text-center'>Hello, React! - użycie useEffect</h1>
      <main>
        <input type="date" name="" id="" /><br />
        <input ref={inputRef} type="text" value={info}
          onChange={(e) => setInfo(e.target.value)} />
        <span>{info}</span>
        <hr />
        <ClockTimer />
      </main>
    </>
  )
}

export default App
