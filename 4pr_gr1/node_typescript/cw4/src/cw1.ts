import { type User, users } from "./mod1.js";
import fs from "fs/promises";

async function main(){
    const myName: string = "John";
    const myAge: number = 30;
    console.log(`My name is ${myName} and I am ${myAge} years old.`);
    for (const user of users) {
        console.log(`User: ${user.name}, Email: ${user.email}`);
        await fs.appendFile(`users.txt`,
             `Name: ${user.name}, Email: ${user.email}\n`,'utf-8');
    }

}
main();
