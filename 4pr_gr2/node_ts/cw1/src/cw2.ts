import { readFileSync, writeFileSync,appendFileSync } from "node:fs";
import { data } from "./cw1-data.js";

const fileContent: string = readFileSync("dane.txt", "utf-8");
console.log(fileContent);
//nadpisywanie pliku
writeFileSync("output.txt", data.join("\n"));
//dopisywanie do pliku
appendFileSync("output.txt", "\nAppended line.");