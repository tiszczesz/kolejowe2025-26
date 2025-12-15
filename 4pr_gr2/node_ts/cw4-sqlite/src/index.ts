// import { hello } from "./functions.js";

// console.log(hello("World"));
// // console.log(__dirname);
// // console.log(__filename);

import {  addUser, getAllUsers, type User } from "./SqliteRepo.js";
import readline from "readline/promises";
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
const main = async () => {
    const users = await getAllUsers();
    console.log(users);
    const answer1 = await rl.question("Czy dodać nowego użytkownika? (t/n) ");
        if (answer1.toLowerCase() === "t") {
           const userName = await rl.question("Podaj nazwę użytkownika: ")
           const userEmail = await rl.question("Podaj email użytkownika: ")
           const user:User = {
                id: 0,
                name: userName,
                email: userEmail
            }
            await addUser(user);
        }    
    rl.close();
};
main();