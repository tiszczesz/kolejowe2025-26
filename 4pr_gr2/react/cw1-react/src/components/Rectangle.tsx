import React from 'react'

type Props = {
    width:number;
    height:number;
    color?:string;
}

const Rectangle = (props: Props) => {
  return (
    <div style={{
        width:`${props.width}px`,
        height:`${props.height}px`,
        backgroundColor:props.color || 'white',
        border:'1px solid black', 
        margin:'10px'      
    }}></div>
  )
}

export default Rectangle