import { data } from "./cw1-data.js";
function Hello(name: string): string {
    return `Hello, ${name}!`;
}
for(const elem of data) {
    console.log(Hello(elem));
}
