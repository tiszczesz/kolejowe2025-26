// import { hello } from "./functions.js";

// console.log(hello("World"));
// // console.log(__dirname);
// // console.log(__filename);

import {  getAllUsers } from "./SqliteRepo.js";

const main = async () => {
    const users = await getAllUsers();
    console.log(users);
};
main();