import type { SizeOption } from "../data/sizes"


type Props = {
  label: string,
  options: SizeOption[],
  handleOnChange: (value: string) => void,
}

const SelectElems = (props: Props) => {
  return (
    <div>
      <label>{props.label}</label>
      <select onChange={(e) =>
         props.handleOnChange(e.target.value)}>
        {props.options.map((option, index) => (
          <option key={index} value={option.value}>{option.name}</option>
        ))}
      </select>
    </div>
  )
}

export default SelectElems     