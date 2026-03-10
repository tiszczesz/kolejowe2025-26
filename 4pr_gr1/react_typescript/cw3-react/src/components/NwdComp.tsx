const NwdComp = () => {
  return (
    <div>
      <h1>Największy wspólny dzielnik</h1>
      <div className="row m-2">
        <label className="col-3" htmlFor="a">
          Podaj a:{" "}
        </label>
        <input className="col-6" type="number" id="a" />
      </div>
      <div className="row m-2">
        <label className="col-3" htmlFor="b">
          Podaj b:{" "}
        </label>
        <input className="col-6" type="number" id="b" />
      </div>
      <div className="row m-2">
        <input
          className="btn btn-primary col-6 offset-3"
          type="button"
          value="Oblicz NWD"
        />
      </div>
      <div className="row offset-3 col-6"
        style={{         
          minHeight: "100px",          
          border: "solid 1px black",
          padding: "10px",
          fontSize: "1.5em",
          backgroundColor: "lightgray",
        }}
      ></div>
    </div>
  );
};

export default NwdComp;
