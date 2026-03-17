import "bootstrap/dist/css/bootstrap.min.css";
import "./App.css";
import { type User,users,getLastUserId,roles } from "./data";
import { useState } from "react";

function App() {
  const [usersData, setUsersData] = useState<User[]>(users);
  return (
    <>
      <h1 className="text-center mb-3">Zarządzanie użytkownikami</h1>
      <h4>Ilość użytkowników: {usersData.length}</h4>
      <main className="d-flex gap-2">
        <section className="w-50">formuarz</section>
        <section className="w-50">
          <table className="table table-striped">
            <thead>
              <tr>Lp</tr>
              <tr>Imię i nazwisko</tr>
            </thead>
          </table>
        </section>
      </main>
    </>
  );
}

export default App;
