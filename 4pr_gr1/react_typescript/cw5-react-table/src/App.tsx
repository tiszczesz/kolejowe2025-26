import "bootstrap/dist/css/bootstrap.min.css";
import "./App.css";
import { type User, users, getLastUserId, roles } from "./data";
import { useState } from "react";

function App() {
  const [usersData, setUsersData] = useState<User[]>(users);
  let lp = 0;
  return (
    <>
      <h1 className="text-center mb-3">Zarządzanie użytkownikami</h1>
      <h4>Ilość użytkowników: {usersData.length}</h4>
      <main className="d-flex gap-2">
        <section className="w-50">formuarz</section>
        <section className="w-50">
          <table className="table table-striped">
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
                  <td></td>
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
