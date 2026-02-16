import readline from 'node:readline/promises';

//cin cout z c++
const rl: readline.Interface = readline.createInterface({
    input: process.stdin,
    output: process.stdout
})
async function main() {
    const firstName = await rl.question("Podaj imię: ");
    const age = parseInt(await rl.question("Podaj wiek: "));
    const correctAge = !isNaN(age) && age > 0;
    if (!correctAge) {
        console.log("Niepoprawny wiek");
        rl.close();
        return;
    }
    console.log(firstName);
    console.log(`Witaj ${firstName} 
        ${(age < 18) ? "niepełnoletni" : "pełnoletni"}`)
    rl.close();
}
main();