import "bootstrap/dist/css/bootstrap.min.css";
import "./App.css";
import { type Movie, genres, movies, getLatestMovieId } from "./data";
import { useRef, useState, type SubmitEvent } from "react";

function App() {
  let lp = 1;
  const [movieList, setMovieList] = useState<Movie[]>(movies);
  const [editingMovieId, setEditingMovieId] = useState<number | null>(null);
  const titleRef = useRef<HTMLInputElement>(null);
  const directorRef = useRef<HTMLInputElement>(null);
  const releaseYearRef = useRef<HTMLInputElement>(null);
  const genreRef = useRef<HTMLSelectElement>(null);
  const formRef = useRef<HTMLFormElement>(null);
  const [info, setInfo] = useState<string>("Dodaj film");
  function handleSubmit(e: SubmitEvent<HTMLFormElement>): void {
    e.preventDefault();
    const form = e.currentTarget;
    const formData = new FormData(form);
    console.log(formData);
    //pobieranie danych z formularza
    const title = formData.get("title") as string;
    const director = formData.get("director") as string;
    const releaseYear = Number(formData.get("releaseYear")); //parseInt(formData.get("releaseYear") as string);
    const genre = formData.get("genre") as Movie["genre"];
    //sprawdzenie czy edytujemy istniejący film czy dodajemy nowy
    if (editingMovieId !== null) { //aktualizacja istniejącego filmu
      const updatedMovie: Movie = {
        id: editingMovieId,
        title,
        director,
        releaseYear,
        genre,
      };
      //utworzenie nowej listy filmów z zaktualizowanym filmem
      const newMovieList = movieList.map((m) =>
        m.id === editingMovieId ? updatedMovie : m,
      );
      //aktualizacja stanu movieList
      setMovieList(newMovieList);
      //resetowanie stanu edycji
      setEditingMovieId(null);
      setInfo("Dodaj film");
    } else {
      //tworzenie nowego obiektu filmu
      const newMovie: Movie = {
        id: getLatestMovieId(movieList) + 1,
        title,
        director,
        releaseYear,
        genre,
      };
      //dodawanie nowego filmu do listy zmiana stanu movieList
      setMovieList([...movieList, newMovie]);
    }
    //czyszczenie formularza
    form.reset();
  }

  function handleDelete(movie: Movie): void {
    //utworzenie nowej listy filmów bez usuwanego filmu
    const newMovieList = movieList.filter((m) => m.id !== movie.id);
    //aktualizacja stanu movieList
    setMovieList(newMovieList);
  }

  function handleUpdate(movie: Movie): void {
    setInfo("Edytuj film");
    //ustawienie id filmu do edycji aby użyć go później do aktualizacji listy filmów
    setEditingMovieId(movie.id);
    // Wypełnij formularz danymi filmu do edycji
    if (titleRef.current) {
      titleRef.current.value = movie.title;
    }
    if (directorRef.current) {
      directorRef.current.value = movie.director;
    }
    if (releaseYearRef.current) {
      releaseYearRef.current.value = movie.releaseYear.toString();
    }
    if (genreRef.current) {
      genreRef.current.value = movie.genre;
    }
  }

  return (
    <>
      <h1 className="text-center mb-2">Przegląd filmów</h1>
      <main className="d-flex gap-2 p-3">
        <section className="w-50">
          <h2>{info}</h2>
          <form onSubmit={(e) => handleSubmit(e)} ref={formRef}>
            <div className="mb-3">
              <input
                ref={titleRef}
                required
                type="text"
                placeholder="Tytuł filmu"
                className="form-control"
                name="title"
              />
            </div>
            <div className="mb-3">
              <input
                ref={directorRef}
                required
                type="text"
                placeholder="Reżyser"
                className="form-control"
                name="director"
              />
            </div>
            <div className="mb-3">
              <input
                ref={releaseYearRef}
                required
                type="number"
                placeholder="Rok premiery"
                className="form-control"
                name="releaseYear"
              />
            </div>
            <div className="mb-3">
              <select ref={genreRef} name="genre" className="form-select">
                {genres.map((genre) => (
                  <option key={genre} value={genre}>
                    {genre}
                  </option>
                ))}
              </select>
            </div>
            <button type="submit" className="btn btn-primary w-100">
              {info}
            </button>
          </form>
        </section>
        <section className="w-50">
          <h2>Lista filmów ilość: {movieList.length}</h2>
          <table className="table table-success table-striped m-2">
            <thead>
              <tr>
                <th>Lp.</th>
                <th>Tytuł</th>
                <th>Reżyser</th>
                <th>Rok premiery</th>
                <th>Gatunek</th>
                <th>Akcje</th>
              </tr>
            </thead>
            <tbody>
              {movieList.map((movie) => (
                <tr key={movie.id}>
                  <td>{lp++}</td>
                  <td>{movie.title}</td>
                  <td>{movie.director}</td>
                  <td>{movie.releaseYear}</td>
                  <td>{movie.genre}</td>
                  <td>
                    <button
                      className="btn btn-danger"
                      onClick={() => handleDelete(movie)}
                    >
                      Usuń
                    </button>
                    <button
                      onClick={() => handleUpdate(movie)}
                      className="btn btn-secondary"
                    >
                      Edytuj
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </section>
      </main>
    </>
  );
}

export default App;
