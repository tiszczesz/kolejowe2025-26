import { useState, type MouseEvent } from "react";
import { nwdCalc } from "../models/nwdCalc";
const NwdComp = () => {
  const [a, setA] = useState(0);
  const [b, setB] = useState(0);
  const [result, setResult] = useState("?");

  function handleClick(e: MouseEvent<HTMLInputElement>): void {
    const wynik = nwdCalc(a, b);
    console.log(wynik);
    setResult(wynik + "");
  }

  return (
    <div>
      <h1>Największy wspólny dzielnik</h1>
      <div className="row m-2">
        <label className="col-3 text-end" htmlFor="a">
          Podaj a:{" "}
        </label>
        <input
          className="col-6"
          type="number"
          id="a"
          value={a}
          onChange={(e) => {
            setA(Number(e.target.value));
            setResult("?");
          }}
        />
        <span className="col-3">a = {a}</span>
      </div>
      <div className="row m-2">
        <label className="col-3 text-end" htmlFor="b">
          Podaj b:{" "}
        </label>
        <input
          className="col-6"
          type="number"
          id="b"
          value={b}
          onChange={(e) => {
            setB(Number(e.target.value));
            setResult("?");
          }}
        />
        <span className="col-3">b = {b}</span>
      </div>
      <div className="row m-2">
        <label htmlFor="" className="col-3"></label>
        <input
          onClick={(e) => handleClick(e)}
          className="btn btn-primary col-6"
          type="button"
          value="Oblicz NWD"
        />
      </div>
      <div
        className="row offset-3 col-6"
        style={{
          minHeight: "100px",
          border: "solid 1px black",
          padding: "10px",
          fontSize: "1.5em",
          backgroundColor: "lightgray",
        }}
      >
        Nwd({a}, {b}) = {result}
      </div>
    </div>
  );
};

export default NwdComp;
