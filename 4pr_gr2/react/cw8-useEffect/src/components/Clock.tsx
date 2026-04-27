import { useEffect, useState } from "react"


const Clock = () => {
    const [time, setTime] = useState(new Date().toLocaleTimeString())

    useEffect(() => {
        const interval = setInterval(() => {
            setTime(new Date().toLocaleTimeString())
        }, 1000);
        return () => clearInterval(interval) //funkcja czyszcząca, która zostanie wywołana przed odmontowaniem komponentu lub przed kolejnym wywołaniem useEffect
    }, []) //pusty array oznacza że useEffect wykona się tylko raz, po pierwszym renderowaniu komponentu
    return (
        <section className="border border-secondary rounded p-3">
            <h2 className="text-center">Zegarek</h2>
            <section className="text-center" style={{
                fontSize: '3rem',
                fontWeight: 'bold',
                color: 'blue',

            }}>{time}</section>
        </section>
    )
}

export default Clock