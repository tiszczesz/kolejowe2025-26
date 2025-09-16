setTimeout(()=>{
    const elem = document.createElement('div');
    elem.id = 'dynamicDiv';
    elem.innerText = 'This div was created dynamically using JavaScript.';
    document.body.appendChild(elem);

}, 2000);
