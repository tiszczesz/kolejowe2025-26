import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import {type Movie, genres, movies, getLatestMovieId} from './data';
import { useState } from 'react';

function App() {
  const [movieList, setMovieList] = useState<Movie[]>(movies);

  return (
    <>
     <h1 className='text-center mb-2'>Przegląd filmów</h1>
      <main className='d-flex gap-2'>
        <section className='w-50'>Formularz</section>
        <section className='w-50'>Tabelka</section>
      </main>
    </>
  )
}

export default App
