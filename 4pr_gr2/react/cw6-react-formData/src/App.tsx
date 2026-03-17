import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import {type Movie, genres, movies, getLatestMovieId} from './data';
import { useState } from 'react';

function App() {
  let lp = 1;
  const [movieList, setMovieList] = useState<Movie[]>(movies);

  return (
    <>
     <h1 className='text-center mb-2'>Przegląd filmów</h1>
      <main className='d-flex gap-2'>
        <section className='w-50'>Formularz</section>
        <section className='w-50'>
          <h2>Lista filmów ilość: {movieList.length}</h2>
          <table className='table table-striped m-2'>
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
              {movieList.map((movie)=>(
                <tr key={movie.id}>
                  <td>{lp++}</td>
                  <td>{movie.title}</td>
                  <td>{movie.director}</td>
                  <td>{movie.releaseYear}</td>
                  <td>{movie.genre}</td>
                  <td></td>
                </tr>
              ))}
            </tbody>
          </table>
        </section>
      </main>
    </>
  )
}

export default App
