import type { SizeOption } from "../data/sizes"


type Props = {
  label: string,
  options: SizeOption[],
  onChange: (value: string) => void,
}

const SelectElems = (props: Props) => {
  return (
    <div>
      <label>{props.label}</label>
      <select >
        {props.options.map((option, index) => (
          <option key={index} value={option.value}>{option.name}</option>
        ))}
      </select>
    </div>
  )
}

export default SelectElems     