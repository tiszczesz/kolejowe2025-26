import React from "react";

type Props = {
  title: string;
  content: string;
  myColor?: string;
  isBordered?: boolean;
};

const First = (props: Props) => {
  return (
    <div>
      <h3>{props.title}</h3>
      <p
        style={{
          margin: "20px 0",
          color: props.myColor || "black",
          border: props.isBordered ? "1px solid black" : "none",
        }}
      >
        {props.content}
      </p>
    </div>
  );
};

export default First;
