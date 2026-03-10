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
      <input
        className="btn btn-primary col-6 offset-3 m-2"
        type="button"
        value="Oblicz NWD"
      />
    </div>
  );
};

export default NwdComp;
