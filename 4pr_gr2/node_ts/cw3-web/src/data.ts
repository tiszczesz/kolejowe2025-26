export const colors =
    ['red', 'green', 'blue',
        'yellow', 'purple'];

export type Book = {
    id: number;
    title: string;
    author: string;
    year: number;
    pages: number;
    price: number;
}
export const books: Book[] = [
    {
        id: 1,
        title: 'Podróżnik w czasie',
        author: 'Anna Kowalska',
        year: 2018,
        pages: 320,
        price: 34.99
    },
    {
        id: 2,
        title: 'Cienie nad Wisłą',
        author: 'Marek Nowicki',
        year: 2021,
        pages: 276,
        price: 29.5
    },
    {
        id: 3,
        title: 'Sekrety starych map',
        author: 'Ewa Zielińska',
        year: 2015,
        pages: 412,
        price: 42.0
    },
    {
            id: 4,
        title: 'Algorytmy codzienności',
        author: 'Tomasz Wiśniewski',
        year: 2023,
        pages: 198,
        price: 49.99
    },
    {
        id: 5,
        title: 'Smak morza',
        author: 'Joanna Malinowska',
        year: 2009,
        pages: 256,
        price: 24.9
    },
    {
        id: 6,
        title: 'Między wierszami',
        author: 'Piotr Szymański',
        year: 2012,
        pages: 184,
        price: 19.99
    },
    {
            id: 7,
        title: 'Nocne obserwacje',
        author: 'Katarzyna Bąk',
        year: 2017,
        pages: 340,
        price: 37.5
    },
    {
        id: 8,
        title: 'Mechanika uczuć',
        author: 'Łukasz Krawczyk',
        year: 2020,
        pages: 298,
        price: 31.0
    },
    {
        id: 9,
        title: 'Przyszłość w skrócie',
        author: 'Magdalena Rutkowska',
        year: 2024,
        pages: 160,
        price: 27.5
    },
    {
        id: 10,
        title: 'Pod lasem',
        author: 'Adam Piasecki',
        year: 2005,
        pages: 448,
        price: 39.0
    }
    ]
    export const getMaxBookId = (data: Book[]): number => {
        let max = 0;
        for (const book of data) {
            if (book.id > max) {
                max = book.id;
            }
        }
        return max;
    }