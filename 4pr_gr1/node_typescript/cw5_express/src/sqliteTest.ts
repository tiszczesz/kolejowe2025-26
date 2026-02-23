import { getAllUsers, createUser } from "./SqliteRepo.js";


const user = {
    name: "Alice",
    email: "alice@example.com",
}
createUser(user.name, user.email);
const users = getAllUsers();
console.log(users);