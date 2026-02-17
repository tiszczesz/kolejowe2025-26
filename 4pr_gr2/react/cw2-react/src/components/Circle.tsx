import { useState } from "react";

type Props = {
  size: number;
  color?: string;
};

const Circle = (props: Props) => {
  console.log("renderowanie Circle");
  //użycie stanu dla text, który wymusza renderowanie gdy zmieni się wartość text
  const [text,setText] = useState("brak");
  //let text = "hh";
  return (
    <div
      onClick={(e) => {
        console.log(e);
        console.log(
          "kliknieto kółko o kolorze: " +
            (e.target as HTMLDivElement).style.backgroundColor
        );
       setText((e.target as HTMLDivElement).style.backgroundColor);
       //text = "fdffdffdd";
        console.log(text);
      }}
      style={{
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        width: `${props.size}px`,
        height: `${props.size}px`,
        backgroundColor: props.color || "white",
        border: "solid 1px black",
        borderRadius: "50%",
        cursor: "pointer",
      }}
    >
      {text}
    </div>
  );
};

export default Circle;
