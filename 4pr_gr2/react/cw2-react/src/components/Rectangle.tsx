import { useState, type MouseEvent } from "react";


type Props = {
    myColr?: string;
}

const Rectangle = (props: Props) => {
    const [width, setWidth] = useState(200);
    // function handleClick(e: MouseEvent<HTMLDivElement>): void {
    //     console.log('Rectangle clicked', e);
    //     if (width > 20) {
    //         setWidth(width - 10);
    //     }
    //     console.log(width);
    // }
    function handleMouseDown(e: MouseEvent<HTMLDivElement>): void {
        console.log('Mouse down on Rectangle', e);
        e.preventDefault();
        if (e.buttons === 1) { // Sprawdzenie, czy lewy przycisk myszy jest wciśnięty
            console.log('Left mouse button is pressed');
            setWidth(width - 10);
        } else if (e.buttons === 2) { // Sprawdzenie, czy prawy przycisk myszy jest wciśnięty
            console.log('Right mouse button is pressed');
            setWidth(width + 10);
            // Zapobiega wyświetleniu menu kontekstowego
        } else if (e.buttons === 4) { // Sprawdzenie, czy środkowy przycisk myszy jest wciśnięty
            setWidth(200);
            console.log('Middle mouse button is pressed');
        } else {
            console.log('No mouse button is pressed');
        }
        // setWidth(width + 10);
        // console.log(width);
    }

    return (
        <div
            //onClick={(e) => handleClick(e)}
            style={{
                backgroundColor: props.myColr || 'lightblue',
                border: '1px solid black',
                height: '100px',
                width: `${width}px`,
            }}
            onMouseDown={(e) => handleMouseDown(e)}
            onContextMenu={(e) => e.preventDefault()}
        >
        </div>
    )
}


export default Rectangle;