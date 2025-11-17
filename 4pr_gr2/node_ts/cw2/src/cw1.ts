import { ff } from "./cw1-data.js";
import  readLine  from "node:readline/promises";
console.log("cw1", ff);
const readObject = readLine.createInterface({
    input: process.stdin,
    output: process.stdout
});
const main = async () => {
    const answer = await readObject.question("Podaj liczbe: ");
    console.log(`Twoja odpowiedź: ${answer}`);
    readObject.close(); // zamyka interfejs po zakończeniu
};
main();