import fs from 'fs/promises';
const getWords = async (fileName:string) => {
    const result = await fs.readFile(fileName,'utf8');
    return result.split(' ');
}
const getMaxWord = (data:string[]) =>{
    let maxWord = "";
    

    return maxWord;
}
async function main() {
    const result = await getWords('myText.txt');
    console.log(result);
    console.log(`Ilość słów: ${result.length}`)
}
main();