import "bootstrap/dist/css/bootstrap.min.css";
import "./App.css";
import { type User, users, getLastUserId, roles } from "./data";
import { useState, type SubmitEvent } from "react";

function App() {
  console.log("renderowanie komponentu App");
  const [usersData, setUsersData] = useState<User[]>(users);
  const [firstName, setFirstName] = useState<string>("");
  const [lastName, setLastName] = useState<string>("");
  const [email, setEmail] = useState<string>("");
  const [role, setRole] = useState<string>(roles[0]);
  let lp = 0;
  function handleSubmit(e: SubmitEvent<HTMLFormElement>): void {
    e.preventDefault();
    //dodanie użytkownika do listy
    const newUser: User = {
      id: getLastUserId(usersData) + 1,
      firstname: firstName,
      lastname: lastName,
      email: email,
      role: role as "admin" | "user" | "guest",
    };
    //dodanie użytkownika do listy wymusza ponowne renderowanie komponentu i aktualizację tabeli
    setUsersData([...usersData, newUser]);
    //nie uzywać usersData.push(newUser) bo to nie zadziała, ponieważ
    // React nie wykryje zmiany w tablicy i nie zrenderuje ponownie komponentu

    //czyszczenie formularza
    setFirstName("");
    setLastName("");
    setEmail("");
    setRole(roles[0]);
  }

  function handleDelete(user: User): void {
    setUsersData(usersData.filter((u) => u.id !== user.id));
  }

  return (
    <>
      <h1 className="text-center mb-3">Zarządzanie użytkownikami</h1>
      <h4>Ilość użytkowników: {usersData.length}</h4>
      <main className="d-flex gap-2">
        <section className="w-50">
          <h2>Dodaj użytkownika</h2>
          <form
            onSubmit={(e) => handleSubmit(e)}
            className="p-4 border border-secondary-subtle m-2"
          >
            <div className="mb-3">
              <input
                className="form-control"
                type="text"
                placeholder="Podaj imię"
                required
                onChange={(e) => setFirstName(e.target.value)}
                value={firstName}
              />
            </div>
            <div className="mb-3">
              <input
                className="form-control"
                type="text"
                placeholder="Podaj nazwisko"
                required
                onChange={(e) => setLastName(e.target.value)}
                value={lastName}
              />
            </div>
            <div className="mb-3">
              <input
                className="form-control"
                type="email"
                placeholder="Podaj email"
                required
                onChange={(e) => setEmail(e.target.value)}
                value={email}
              />
            </div>
            <div className="mb-3">
              <select
                className="form-select"
                onChange={(e) => setRole(e.target.value)}
                value={role}
              >
                {roles.map((r) => (
                  <option key={r} value={r}>
                    {r}
                  </option>
                ))}
              </select>
            </div>
            <div className="m-2">
              <button type="submit" className="btn btn-primary w-100">
                Dodaj użytkownika
              </button>
            </div>
          </form>
        </section>
        <section className="w-50">
          <table className="table table-striped m-2">
            <thead>
              <tr>
                <th>Lp</th>
                <th>Imię</th>
                <th>Nazwisko</th>
                <th>Email</th>
                <th>Rola</th>
                <th>Akcje</th>
              </tr>
            </thead>
            <tbody>
              {usersData.map((user) => (
                <tr
                  key={user.id}
                  style={{
                    textDecoration:
                      user.role === "admin" ? "underline" : "none",
                  }}
                >
                  <td>{++lp}</td>
                  <td>{user.firstname}</td>
                  <td>{user.lastname}</td>
                  <td>{user.email}</td>
                  <td>{user.role}</td>
                  <td>
                    <button className="btn btn-danger" onClick={()=>handleDelete(user)}>Usuń</button>
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
