import React from 'react'

type Props = {
    width:number;
    height:number;
    color?:string;
}

const Rectangle = ({width,height,color}: Props) => {
  return (
    <div style={{
        width:`${width}px`,
        height:`${height}px`,
        backgroundColor:color
    }}></div>
  )
}

export default Rectangle