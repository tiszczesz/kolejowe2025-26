import { writeFile,readFile } from "node:fs/promises";
export async function createFile(fileName: string, content: string) {
    await writeFile(fileName, content);
}
export async function readFromFile(fileName: string): Promise<string[]> {
    const data = [];    
    const file = await readFile(fileName, { encoding: "utf8" });
    const lines = file.split(/\r?\n/);
    data.push(...lines);
    return data;   
}