import { colors } from "./data.js";
const result1 = document.querySelector('#result1');
if (result1) {
    GenerSelect(colors, result1);
    document.querySelector('#colorSelect')
        ?.addEventListener('change', (event) => {
        document.body.style.backgroundColor =
            event.target.value;
    });
}
else {
    console.error("Brak elementu o id 'result1' w dokumencie HTML.");
}
//const GenerSelect = () =>{};
function GenerSelect(colors, elem) {
    const select = document.createElement('select');
    select.id = 'colorSelect';
    for (const color of colors) {
        const option = document.createElement('option');
        option.value = color;
        option.text = color;
        select.appendChild(option);
    }
    elem.appendChild(select);
}
;
//# sourceMappingURL=index.js.map