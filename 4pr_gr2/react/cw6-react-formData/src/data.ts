export type Movie = {
    id: number;
    title: string;
    director: string;
    releaseYear: number;
    genre: "komedia" | "dramat" | "akcja" | "horror" | "sci-fi" | "romans";    
}
export const genres = ["komedia", "dramat", "akcja", "horror", "sci-fi", "romans"] as const;
export const movies: Movie[] = [
    {
        id: 1,
        title: "Vida Loca",
        director: "Judd Apatow",
        releaseYear: 2009,
        genre: "komedia"
    },
    {
        id: 2,
        title: "Życie piękne",
        director: "Roberto Benigni",
        releaseYear: 1997,
        genre: "dramat"
    },
    {
        id: 3,
        title: "Mission: Impossible",
        director: "Brian De Palma",
        releaseYear: 1996,
        genre: "akcja"
    },
    {
        id: 4,
        title: "Dzień Żywych Zmarłych",
        director: "George A. Romero",
        releaseYear: 1968,
        genre: "horror"
    },
    {
        id: 5,
        title: "Blade Runner",
        director: "Ridley Scott",
        releaseYear: 1982,
        genre: "sci-fi"
    },
    {
        id: 6,
        title: "Titanic",
        director: "James Cameron",
        releaseYear: 1997,
        genre: "romans"
    }
];