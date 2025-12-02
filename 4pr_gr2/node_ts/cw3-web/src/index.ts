import { colors } from "./data.js";

const result1 = document.querySelector<HTMLDivElement>('#result1');
if (result1) {
    GenerSelect(colors,result1);
    document.querySelector<HTMLSelectElement>('#colorSelect')
            ?.addEventListener('change', (event)=>{
                document.body.style.backgroundColor = 
                     (event.target as HTMLSelectElement).value
            });
}else{
    console.error("Brak elementu o id 'result1' w dokumencie HTML.");
}

//const GenerSelect = () =>{};
function GenerSelect(colors: string[],elem:Element) { 
    const select = document.createElement('select');
    select.id = 'colorSelect';
    for (const color of colors) {
        const option = document.createElement('option');
        option.value = color;
        option.text = color;
        select.appendChild(option);
    } 
    elem.appendChild(select);   
};
