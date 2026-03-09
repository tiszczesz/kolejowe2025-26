import  { useState,type MouseEvent} from 'react'

type Props = {
    myValue?: string
}

const Input2Comp = (props: Props) => {
    const [info, setInfo] = useState('');
    function handleClick(e: MouseEvent<HTMLInputElement>): void {
        setInfo(prev => prev + ' ' + e.currentTarget.value);
    }

    return (
        <div>
            <input                
                onClick={(e) => handleClick(e)}
                type="button" value={props.myValue || "x"} />
            {/* nacisniecie przycisku dodaje value do diva */}
            <div>{info}</div>
        </div>
    )
}

export default Input2Comp