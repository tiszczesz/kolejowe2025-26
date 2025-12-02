import { colors, books, getMaxBookId } from "./data.js";
const result1 = document.querySelector('#result1');
const result2 = document.querySelector('#result2');
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
if (result2) {
    GenerTable(books, result2);
}
const form = document.querySelector('form');
form?.addEventListener('submit', (event) => {
    event.preventDefault();
    const newBook = {
        id: getMaxBookId(books) + 1,
        title: (document.querySelector('#title')?.value) || '',
        author: (document.querySelector('#author')?.value) || '',
        pages: Number((document.querySelector('#pages')?.value) || 0),
        year: Number((document.querySelector('#year')?.value) || 0),
        price: Number((document.querySelector('#price')?.value) || 0),
    };
    books.push(newBook);
    if (result2) {
        GenerTable(books, result2);
        document.querySelector('#title').value = '';
        document.querySelector('#author').value = '';
        document.querySelector('#pages').value = '';
        document.querySelector('#year').value = '';
        document.querySelector('#price').value = '';
    }
});
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
function GenerTable(data, elem) {
    elem.innerHTML = ''; //czyścimy zawartość elementu
    const table = document.createElement('table');
    table.classList.add('table', 'table-striped');
    const thead = document.createElement('thead');
    const headerRow = document.createElement('tr');
    headerRow.innerHTML = `
        <th>Lp.</th>
        <th>Tytuł</th>
        <th>Autor</th>
        <th>Rok Wydania</th>
        <th>Liczba Stron</th>
        <th>Cena (PLN)</th>       
    `;
    thead.appendChild(headerRow);
    table.appendChild(thead);
    const tbody = document.createElement('tbody');
    let lp = 0;
    for (const book of data) {
        lp++;
        const row = document.createElement('tr');
        row.addEventListener('click', (event) => {
            const id = event.currentTarget.id; //pobieramy id kliknietego wiersza
            const selectedBook = data.find(b => b.id == Number(id)); //szukamy ksiazki o danym id
            if (selectedBook) {
                ShowBookDetails(selectedBook);
            }
        });
        row.id = `${book.id}`;
        row.style.cursor = 'pointer';
        row.innerHTML = `
            <td>${lp}</td>
            <td>${book.title}</td>
            <td>${book.author}</td>
            <td>${book.year}</td>
            <td>${book.pages}</td>
            <td>${book.price.toFixed(2)}</td>
            
        `;
        tbody.appendChild(row);
    }
    table.appendChild(tbody);
    elem.appendChild(table);
}
function ShowBookDetails(selectedBook) {
    const elem = document.querySelector('#showBook');
    if (elem) {
        elem.innerHTML = `
            <h2>Szczegóły książki</h2>
            <p><strong>Tytuł:</strong> ${selectedBook.title}</p>
            <p><strong>Autor:</strong> ${selectedBook.author}</p>
            <p><strong>Rok Wydania:</strong> ${selectedBook.year}</p>
            <p><strong>Liczba Stron:</strong> ${selectedBook.pages}</p>
            <p><strong>Cena:</strong> ${selectedBook.price.toFixed(2)} PLN</p>
        `;
    }
    else {
        console.error("Brak elementu o id 'showBook' w dokumencie HTML.");
    }
}
//# sourceMappingURL=index.js.map