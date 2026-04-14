import { useEffect, useState } from "react";

type Props = {};

const TimerPage = (props: Props) => {
  const [time, setTime] = useState<string>(new Date().toLocaleTimeString());
  useEffect(() => {
    const interval = setInterval(() => {
      setTime(new Date().toLocaleTimeString());
    }, 1000);
    return () => clearInterval(interval);
  }, []);
  return (
    <div
      style={{
        fontSize: "3rem",
      }}
    >
      Aktualny czas: {time}
    </div>
  );
};

export default TimerPage;
