

setTimeout(()=>{
    const elem = document.createElement('p');
    elem.textContent = "This is a paragraph added by JavaScript.";
    const main = document.querySelector('main');
    main.appendChild(elem);
},2000);