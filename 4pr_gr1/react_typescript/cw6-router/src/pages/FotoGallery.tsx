import { useState } from 'react'
import { images, type Image } from '../data/images'



const FotoGallery = () => {
  const [imagesList, setImagesList] = useState<Image[]>(images);
  const [flowers, setFlowers] = useState(true);
  const [animals, setAnimals] = useState(true);
  const [cars, setCars] = useState(true);
  console.log(flowers, animals, cars);
  return (
    <>
      <h1>Kategorie zdjęć</h1>
      <section className='d-flex gap-4'>
        <div className="form-check form-switch">
          <input id='flowers' className="form-check-input" type="checkbox" checked={flowers} onChange={() => setFlowers(!flowers)} />
          <label className="form-check-label" htmlFor='flowers' >Kwiaty</label>
        </div>
        <div className="form-check form-switch">
          <input id='animals' className="form-check-input" type="checkbox" checked={animals} onChange={() => setAnimals(!animals)} />
          <label className="form-check-label" htmlFor='animals' >Zwierzęta</label>
        </div>
        <div className="form-check form-switch">
          <input id='cars' className="form-check-input" type="checkbox" checked={cars} onChange={() => setCars(!cars)} />
          <label className="form-check-label" htmlFor='cars' >Samochody</label>
        </div>
      </section>
      <section className='d-flex gap-2 flex-wrap'>
        {imagesList.map((image) => (
          <div key={image.id}>
            <img src={'assets/' + image.filename} alt={image.alt} style={{
              margin: '5px',
              borderRadius: '5px',
            }} />
            <h4>Pobrań: {image.downloads}</h4>
            <button className='btn btn-success' >Pobierz</button>
          </div>

        ))}
      </section>
    </>
  )
}

export default FotoGallery