export type Dish = {
  id: number;
  name: string;
  filename: string;
  alt: string;
  price: number;
  likes: number;
}
export const dishes: Dish[] = [
    {
      id: 1,
      name: "Posiłek 1",
      filename: "posilek1.jpg",
      alt: "Posiłek 1",
      price: 19.99,
      likes: 0,
    },
    {
      id: 2,
      name: "Posiłek 2",
      filename: "posilek2.jpg",
      alt: "Posiłek 2",
      price: 21.99,
      likes: 0,
    },
    {
      id: 3,
      name: "Posiłek 3",
      filename: "posilek3.jpg",
      alt: "Posiłek 3",
      price: 23.99,
      likes: 0,
    },
    {
      id: 4,
      name: "Posiłek 4",
      filename: "posilek4.jpg",
      alt: "Posiłek 4",
      price: 18.99,
      likes: 0,
    },
    {
      id: 5,
      name: "Posiłek 5",
      filename: "posilek5.jpg",
      alt: "Posiłek 5",
      price: 25.99,
      likes: 0,
    },
]
