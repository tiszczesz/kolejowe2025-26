import { useEffect, useState } from "react";

const ClockTimer = () => {
    const [time, setTime] = useState(new Date().toLocaleTimeString());
    useEffect(() => {
        const timer = setInterval(() => {
            setTime(new Date().toLocaleTimeString());
        }, 1000);
        return () => clearInterval(timer);
    }, []);

    return (
        <div className="border p-2" style={{
            margin: '20px auto',
            width: '500px',
            height: '200px',
            boxShadow: '0 4px 8px rgba(0, 0, 0, 0.1)',
            borderRadius: '8px',
            display: 'flex',
            textAlign: 'center',
            justifyContent: 'center',
            alignItems: 'center',
            backgroundColor: '#f8f9fa',
            fontSize: '3rem',
        }}>{time}</div>
    )
}

export default ClockTimer