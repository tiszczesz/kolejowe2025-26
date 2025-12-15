import fs from 'fs/promises'
import { colors } from './data.js'

const main = async () =>{
    //zapis do pliku asynchroniczny
    await fs.writeFile("kolory.txt","utf8")
    console.log("zapisywanie do pliku...");
    //odczyt z pliku asynchroniczny
    const result = await fs.readFile('info.txt','utf8');
    console.log(result);
}

main();
