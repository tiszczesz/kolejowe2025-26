

type Props = {
    myColor: string;
    content: string;
}

export default function MyInfo({myColor,content}: Props) {
  return (
    <div style={{color:myColor,padding:"10px",border:"solid 1px green"}}>{content}</div>
  )
}

