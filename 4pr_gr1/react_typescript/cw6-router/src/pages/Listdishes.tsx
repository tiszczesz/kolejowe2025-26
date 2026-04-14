import { useState } from "react";
import { dishes, type Dish } from "../data/dishes";

const Listdishes = () => {
  const [dishesList, setDishesList] = useState<Dish[]>(dishes);
  function handleClick(id: number): void {
    const newList = dishesList.map((dish) =>
      dish.id === id ? { ...dish, likes: dish.likes + 1 } : dish,
    );
    setDishesList(newList);
  }

  return (
    <div>
      <h1>Lista posiłków</h1>
      <section className="d-flex gap-2 flex-wrap">
        {dishesList.map((dish) => (
          <div className="card" style={{ width: "18rem" }} key={dish.id}>
            <img
              src={`assets/posilki/${dish.filename}`}
              className="card-img-top"
              alt={dish.alt}
            />
            <div className="card-body d-flex">
              <section>
                <h5 className="card-title">{dish.name}</h5>
                <p className="card-text">{dish.price.toFixed(2)} zł</p>
                <div>
                  <span className="m-2 p-3">{dish.likes} polubień</span>
                  <button
                    onClick={() => handleClick(dish.id)}
                    className="btn btn-outline-primary"
                  >
                    Polub
                  </button>
                </div>
              </section>
              <section
                style={{
                  marginLeft: "20px",
                  width: "20px",
                  backgroundColor: "green",
                  height: `${dish.likes}px`,
                }}
              ></section>
            </div>
          </div>
        ))}
      </section>
    </div>
  );
};

export default Listdishes;
