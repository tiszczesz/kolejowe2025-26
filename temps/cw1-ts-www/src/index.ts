import { greet } from './index-mod.js';
const div:HTMLDivElement = document.createElement('div');
if(div){
    div.innerText = 'Hello, TypeScript with Modules!: ' + greet('UserNew');
    document.body.appendChild(div);
}
