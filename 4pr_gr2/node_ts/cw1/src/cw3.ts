import fs from "node:fs/promises";
import { get } from "node:http";

const getAsyncFileContent = async (filePath: string) => {
    // Asynchroniczne czytanie pliku czekajace na wynik
    const fileContent = await fs.readFile(filePath, 'utf-8');
    console.log(fileContent);
}
const setAsyncFileContent = async (filePath: string, date: string): Promise<boolean> => {
    await fs.writeFile(filePath, date);
    return true;
};
getAsyncFileContent("output.txt");
setAsyncFileContent("output_async.txt",
    "Async to jest ciekawy\n file content").then(
        (result)=>console.log(result)        
    );

//console.log(`resultat funkcji async: ${result}`);
