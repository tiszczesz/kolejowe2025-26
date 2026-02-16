import './Component1.css'
export default function Component1(){
    const date = new Date();
    return (
        <>
        <p>To jest Component1</p>
        <div>{date.toLocaleDateString()}</div>
        <div>{1+1*2}</div>
        </>
    )
}