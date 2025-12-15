import fs from 'fs';
const info: string = "This is a sample TypeScript file.";
//zapis do pliku synchronicznie
fs.writeFileSync('info.txt', info, 'utf8');
//odczyt z pliku synchronicznie
const data = fs.readFileSync('dane.txt', 'utf8');
console.log(info);
console.log(data);