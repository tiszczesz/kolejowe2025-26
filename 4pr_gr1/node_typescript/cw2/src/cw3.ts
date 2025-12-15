import fs from 'fs/promises';
const getWords = async (fileName:string) => {
    const result = await fs.readFile(fileName,'utf8');
    return result.split(' ');
}
const getMaxWord = (data:string[]) =>{
    let maxWord = "";
    for(let w of data){
        if(w.length>maxWord.length){
            maxWord = w;
        }
    }
    return maxWord;
}
function CountWords(dl:number,data:string[]):number{
    let result = 0;
    data.forEach((elem)=>{
        if(elem.length===dl) result++;
    });
    return result;
}
async function main() {
    const result = await getWords('myText.txt');
    console.log(result);
    console.log(`Ilość słów: ${result.length}`)
    console.log(`najdluzsze slowo: ${getMaxWord(result)}`)
    console.log(`ilosc słów o dlugosci 3: ${CountWords(3,result)}`)
}
main();