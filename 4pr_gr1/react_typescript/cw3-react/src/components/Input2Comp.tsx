import { useState, type MouseEvent } from 'react'

type Props = {
    myValue?: string
}

const Input2Comp = (props: Props) => {
    const [info, setInfo] = useState(props.myValue || 'brak danych');
    function handleClick(e: MouseEvent<HTMLInputElement>): void {
        const val = e.currentTarget.value;
        console.log(val);
        const newVal = 'kliknięto: ' + val;
        setInfo(newVal);
    }

    return (
        <div>
            <input
                onClick={(e) => handleClick(e)}
                type="button" value={info} />
            {/* nacisniecie przycisku dodaje value do diva */}
            <div>{info}</div>
        </div>
    )
}

export default Input2Comp