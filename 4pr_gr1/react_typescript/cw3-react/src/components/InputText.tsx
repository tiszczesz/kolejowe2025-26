import {  useState, type ChangeEvent } from "react"


type Props = {
    label: string
}

const InputText = (props: Props) => {
    console.log('render InputText')
    const [valueText, setValueText] = useState('')
    function handleChange(e: ChangeEvent<HTMLInputElement>): void {
        console.log(e.currentTarget.value)
        setValueText(e.currentTarget.value)
    }

    return (
        <div>
            <label>{props.label}</label>
            <input onChange={(e) => handleChange(e)} type="text" value={valueText}/>
            <span>{valueText.toUpperCase()}</span>
        </div>
    )
}

export default InputText