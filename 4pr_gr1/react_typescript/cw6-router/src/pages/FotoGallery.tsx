import  { useState } from 'react'
import { images,type Image } from '../data/images'



const FotoGallery = () => {
  const [imgasList, setImgasList] = useState<Image[]>(images);
  return (
    <>
    <h1>Kategorie zdjęć</h1>
    <section>

    </section>
    <section className='d-flex'>
      {imgasList.map((image) => (
        <div key={image.id}>
          <img src={'assets/' + image.filename} alt={image.alt} />
        </div>
      ))}
    </section>
    </>
  )
}

export default FotoGallery