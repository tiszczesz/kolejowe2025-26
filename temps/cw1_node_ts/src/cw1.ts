import { createFile, readFromFile } from "./cw1_module.js";
import readline from "node:readline/promises";

const data = ["Line 1", "Line 2", "Line 3"];
const rline = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});


const fromFile = async () => {
   const lines = await readFromFile("data.txt");
   console.log(lines);
}
run();

async function run() {
    await createFile("hello.txt", "Hello, World!");
    await createFile("data.txt", data.join("\n"));
    await fromFile();
    const answer  = await rline.question("Press Enter to name...");
    console.log(`You typed: ${answer}`);
    rline.close();
}