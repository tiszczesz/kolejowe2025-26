import { useRef, useState, type SubmitEvent } from "react"

function FormRef() {
    console.log("render FormRef")
    const firstNameRef = useRef<HTMLInputElement>(null);
    const lastNameRef = useRef<HTMLInputElement>(null);
    const ageRef = useRef<HTMLInputElement>(null);
    const [formResult, setFormResult] = useState<string>("");
    function handleSubmit(e: SubmitEvent<HTMLFormElement>): void {
        e.preventDefault();
        //sprawdzenie czy refy są ustawione
        if (firstNameRef.current && lastNameRef.current && ageRef.current) {
            const firstName = firstNameRef.current.value;
            const lastName = lastNameRef.current.value;
            const age = ageRef.current.value;
            //komunikat ile lat do 100
            setFormResult(`Witaj ${firstName} ${lastName}, masz ${age} lat!, do 100 lat zostało Ci ${100 - Number(age)} lat!`);
        }
    }

    return (
        <div>
            <h1>FormRef</h1>
            <form onSubmit={(e) => handleSubmit(e)}>
                <div className="row m-2">
                    <label htmlFor="firstName" className="col-3 text-end">Imię</label>
                    <input ref={firstNameRef} type="text" id="firstName" className="col-6" required />
                </div>
                <div className="row m-2">
                    <label htmlFor="lastName" className="col-3 text-end">Nazwisko</label>
                    <input ref={lastNameRef} type="text" id="lastName" className="col-6" required />
                </div>
                <div className="row m-2">
                    <label htmlFor="age" className="col-3 text-end">Wiek</label>
                    <input ref={ageRef} type="number" id="age" className="col-6" required />
                </div>
                <div className="row m-2">
                    <button type="submit" className="col-6 offset-3 btn btn-primary">Zapisz</button>
                </div>
            </form>
            <div style={{
                marginTop: "20px",
                fontSize: "20px",
                fontWeight: "bold"
            }}>
                {formResult}
            </div>
        </div>
    )
}

export default FormRef