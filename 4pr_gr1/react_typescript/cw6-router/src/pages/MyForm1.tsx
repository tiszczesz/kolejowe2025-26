import { useState, type SubmitEvent } from "react";
type FormResult = {
  name: string;
  option: string;
}

const MyForm1 = () => {
  console.log('render');
  const [name, setName] = useState('');
  const [option, setOption] = useState('option1');
  const [formResult, setFormResult] = useState<FormResult | null>(null);
  function handleOnSubmit(e: SubmitEvent<HTMLFormElement>): void {
    e.preventDefault();
    console.log(name, option);
    setFormResult({ name, option });
  }
  return (
    <>
      <h2>Formularz 1 z wykorzystaniem onChange -- dużo renderów</h2>
      <form onSubmit={(e) => handleOnSubmit(e)}>
        <input onChange={(event) => setName(event.target.value)} type="text" placeholder='podaj imię' value={name} /> <br />
        <select onChange={((event) => setOption(event.target.value))} value={option}>
          <option value="option1">Opcja 1</option>
          <option value="option2">Opcja 2</option>
          <option value="option3">Opcja 3</option>
        </select> <br />
        <input type="submit" value="Wyślij" />
      </form>
      <hr />
      <h3>Wynik:</h3>
      {formResult && (
        <pre>{JSON.stringify(formResult, null, 2)}</pre>
      )}
    </>
  )
}

export default MyForm1