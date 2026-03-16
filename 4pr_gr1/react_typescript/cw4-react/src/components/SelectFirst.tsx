import { useState, type ChangeEvent } from "react"


type Props = {
    myColors?: string[]
}

const SelectFirst = ({ myColors }: Props) => {
    const [selectedColor, setSelectedColor] = useState<string>("white")
    function handleChange(e: ChangeEvent<HTMLSelectElement>): void {
        console.log(e.target.value);
        setSelectedColor(e.target.value)
    }
    return (
        <>
            <h2>Wybierz kolor</h2>
            <select onChange={(e)=>handleChange(e)}>
                {myColors?.map((elem, index) => (
                    <option key={index}>{elem}</option>
                ))}
            </select>
            <div style={{
                backgroundColor: selectedColor,
                width: "100px",
                height: "100px",
                border: "solid 1px black"
            }}></div>
        </>
    )
}

export default SelectFirst