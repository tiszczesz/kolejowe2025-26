import { useState } from "react";
interface Person {
  firstname: string;
  lastname: string;
  age: number;
  dateOfBirth: string;
  education: string;
}
const MyForm = () => {
  const handleSubmit = (formData: FormData) => {
    console.log(formData);
    const person: Person = {
      firstname: formData.get("firstname") as string,
      lastname: formData.get("lastname") as string,
      age: Number(formData.get("age")),
      dateOfBirth: formData.get("dateOfBirth") as string,
      education: formData.get("education") as string,
    }
    setPerson(person);

  };

  const [person, setPerson] = useState<Person | undefined>(undefined);

  return (
    <div>
      <h2 className="text-center">Formularz z obsługą React_v19</h2>
      <pre>{person && JSON.stringify(person, null, 2)}</pre>
      <form action={handleSubmit}>
        <div className="row m-2">
          <label className="col-3 text-end" htmlFor="firstname">
            Podaj imię:
          </label>
          <input
            className="col-6"
            type="text"
            id="firstname"
            name="firstname"
          />
        </div>
        <div className="row m-2">
          <label className="col-3 text-end" htmlFor="lastname">
            Podaj nazwisko:
          </label>
          <input className="col-6" type="text" id="lastname" name="lastname" />
        </div>
        <div className="row m-2">
          <label className="col-3 text-end" htmlFor="age">
            Podaj wiek:
          </label>
          <input className="col-6" type="number" id="age" name="age" />
        </div>
        <div className="row m-2">
          <label className="col-3 text-end" htmlFor="dateOfBirth">
            Podaj datę urodzenia:
          </label>
          <input className="col-6" type="date" id="dateOfBirth" name="dateOfBirth" />
        </div>
        <div className="row m-2">
          <label className="col-3 text-end" htmlFor="education">
            Podaj wykształcenie:
          </label>
          <select className="col-6" id="education" name="education">
            <option value="podstawowe">Podstawowe</option>
            <option value="średnie">Średnie</option>
            <option value="wyższe">Wyższe</option>
          </select>
        </div>
        <div className="row m-2">
          <input
            className="btn btn-outline-primary col-6 offset-3"
            type="submit"
          />
        </div>
      </form>
    </div>
  );
};

export default MyForm;
