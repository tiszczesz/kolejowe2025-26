import readline from 'node:readline/promises';

//cin cout z c++
const rl:readline.Interface = readline.createInterface({
    input:process.stdin,
    output:process.stdout
})
async function main(){
    const firstName = await rl.question("Podaj imię: ");
    console.log(firstName);
    rl.close();
}
main();