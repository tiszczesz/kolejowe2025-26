import type { ChangeEvent } from "react"


type Props = {
    label: string
}

const InputText = (props: Props) => {
    function handleChange(e: ChangeEvent<HTMLInputElement>): void {
        console.log(e.currentTarget.value)
    }

    return (
        <div>
            <label>{props.label}</label>
            <input onChange={(e) => handleChange(e)} type="text" />
            <span></span>
        </div>
    )
}

export default InputText