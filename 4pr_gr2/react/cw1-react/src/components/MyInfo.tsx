

type Props = {
    myColor: string;
    content: string;
    myOpacity?: number;
}

export default function MyInfo({ myColor, content, myOpacity }: Props) {
    const width = 2;
    return (
        <div style={
            {
                color: myColor, padding: "10px",
                border: `solid ${width}px green`,
                opacity: myOpacity || 1
            }}>{content}</div>
    )
}

