import { useState, type MouseEvent } from "react";

type Props = {
    myValue?: string
}

const InputComp = (props: Props) => {
    //useState zwraca tablicę z dwoma elementami: aktualną wartością stanu
    //  i funkcją do jego aktualizacji
    const [info, setInfo] = useState('brak danych');
    console.log('render InputComp')
    //let info = 'brak danych';
    function handleClick(e: MouseEvent<HTMLInputElement>): void {
        //info = 'kliknięto: ' + e.currentTarget.value;
        //setInfo jest asynchroniczne, więc info nie jest od razu aktualizowane
        //wywolanie setInfo powoduje ponowne wyrenderowanie komponentu,
        //  a wtedy info jest już zaktualizowane
        setInfo('kliknięto: ' + e.currentTarget.value);
        console.log(info)
    }

    return (
        <div>
            <input type="button"
                className="btn btn-primary"
                onClick={(e) => handleClick(e)}
                value={props.myValue || "Pokaż"} />
            <div>{info}</div>
        </div>
    )

}
export default InputComp;