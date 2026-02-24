import { useState, type ChangeEvent } from "react";

type Props = {};

function Info({}: Props) {
  //zdeklaruj stan text, który będzie przechowywał wartość z inputa
  const [text, setText] = useState("");
  function handleChange(e: ChangeEvent<HTMLInputElement>): void {
    console.log(e.target.value);
    //ustaw stan text na wartość z inputa
    setText(e.target.value);
  }

  return (
    <div
      className="row m-2"
      style={{
        border: "solid 1px black",
        borderRadius: "5px",
        padding: "10px",
      }}
    >
      <input onChange={(e) => handleChange(e)} type="text" />
      <span className="bg-dark text-light p-2">{text.toUpperCase()}</span>
    </div>
  );
}

export default Info;
