import 'bootstrap/dist/css/bootstrap.min.css';
import { sizes, widths } from './data/sizes';
import './App.css'
import SelectElems from './components/SelectElems'
import { colors } from './data/colors';
import { useState } from 'react';

function App() {
 const [selectedSize, setSelectedSize] = useState(sizes[0].value);
 const [selectedColor, setSelectedColor] = useState(colors[0].value);
 const [selectedWidth, setSelectedWidth] = useState(widths[0].value);
  return (
    <>
      <div className='d-flex gap-3 m-3'>
        <div>
          <SelectElems label='Rozmiar tekstu'
            options={sizes}
            handleOnChange={(value) =>
             setSelectedSize(value)} />
        </div>
        <div>
          <SelectElems label='Kolor tekstu'
            options={colors}
            handleOnChange={(value) => 
            setSelectedColor(value)} />
        </div>
            <div>
          <SelectElems label='szerokość tekstu'
            options={widths}
            handleOnChange={(value) => 
            setSelectedWidth(value)} />
        </div>
      </div>
      <p style={{ 
        fontSize: selectedSize, 
        color: selectedColor ,
        width: selectedWidth
      }}
      >Lorem ipsum dolor sit amet consectetur adipisicing elit. Ea, deserunt nemo laboriosam tempore natus omnis ad eos similique explicabo ullam, beatae facere ipsa tempora repellat quis odio? Minus, a labore.</p>
      <p>Ala ma kota</p>
    </>
  )
}

export default App
