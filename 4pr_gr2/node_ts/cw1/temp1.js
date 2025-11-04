console.log("Witaj w nodejs");
//alert("Witaj w nodejs");
console.log(globalThis);
setTimeout(() => {
  console.log("Po 2 sekundach");
}, 2000);

let counter = 0;
for (let i = 0; i < 10; i++) {
    counter++;
}
console.log("Licznik: ", counter);