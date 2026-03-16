import  { type ReactNode } from 'react'

type Props = {
    myColor?: string,
    bacColor?: string,
    children?: ReactNode //aby przyjmować dzieci, musimy dodać do propsów children, który jest typu React.ReactNode
}

function CompWithChildren({myColor, children,bacColor}: Props) {
  return (
    <div style={{
        color:myColor || "black",
        backgroundColor: bacColor || "white"
    }}>
      {children}
    </div>
  )
}

export default CompWithChildren