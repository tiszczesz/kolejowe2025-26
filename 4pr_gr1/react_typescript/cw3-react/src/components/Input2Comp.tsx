import React from 'react'

type Props = {
    myValue?: string
}

const Input2Comp = (props: Props) => {
    return (
        <div>
            <input type="button" value={props.myValue || "x"} />
            {/* nacisniecie przycisku dodaje value do diva */}
            <div></div>
        </div>
    )
}

export default Input2Comp