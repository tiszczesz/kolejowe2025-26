import fs from 'fs';
const info = "This is a sample TypeScript file.";
//zapis do pliku
fs.writeFileSync('info.txt', info, 'utf8');
//odczyt z pliku
const data = fs.readFileSync('dane.txt', 'utf8');
console.log(info);
console.log(data);
//# sourceMappingURL=cw1.js.map