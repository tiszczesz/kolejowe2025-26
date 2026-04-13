import { useState } from "react";
import { images, type Image } from "../data/images";


const ImagesPage = () => {
    const [flowers, setFlowers] = useState(true);
    const [animals, setAnimals] = useState(true);
    const [cars, setCars] = useState(true);
    const [filteredImages, setFilteredImages] = useState<Image[]>(images);
    console.log({ flowers, animals, cars });
    console.log(filteredImages);
    function handleClick(id: number): void {
        const newImages = filteredImages.map(im => {
            if (im.id === id) {
                return { ...im, downloads: im.downloads + 1 }
            } else {
                return im;
            }
        });
        setFilteredImages(newImages);
    }

    return (
        <div className="container">
            <h1>Kategorie zdjęć</h1>
            <section className="d-flex flex-wrap gap-2">
                <div className="form-check form-switch">
                    <input className="form-check-input" type="checkbox" id="flowers" checked={flowers}
                        onChange={() => setFlowers(!flowers)} />
                    <label className="form-check-label" htmlFor="flowers">Kwiaty</label>
                </div>
                <div className="form-check form-switch">
                    <input className="form-check-input" type="checkbox" id="animals" checked={animals}
                        onChange={() => setAnimals(!animals)} />
                    <label className="form-check-label" htmlFor="animals">Zwierzęta</label>
                </div>
                <div className="form-check form-switch">
                    <input className="form-check-input" type="checkbox" id="cars" checked={cars}
                        onChange={() => setCars(!cars)} />
                    <label className="form-check-label" htmlFor="cars">Samochody</label>
                </div>
            </section>
            <section className="d-flex gap-2 flex-wrap">
                {filteredImages.map(im => (
                    ((flowers && im.category === 1)
                        || (animals && im.category === 2)
                        || (cars && im.category === 3)
                    ) && <div key={im.id}>
                        <img style={{
                            margin: "5px",
                            borderRadius: "5px",
                        }} src={"assets/" + im.filename} alt={im.alt} />
                        <h4>Pobrań: {im.downloads}</h4>
                        <button className="btn btn-success"
                            onClick={() => handleClick(im.id)}
                        >Pobierz</button>
                    </div>
                ))}
            </section>
        </div>
    )
}

export default ImagesPage