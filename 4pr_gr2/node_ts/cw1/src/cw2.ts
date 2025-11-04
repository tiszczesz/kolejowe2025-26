import { readFileSync } from "node:fs";

const fileContent:string = readFileSync("dane.txt", "utf-8");
console.log(fileContent);