let btn = document.querySelector("#showDate");
let btn2 = document.querySelector("#showTime");
console.log(btn);
d1 = new Date();
d2 = new Date("2026-07-01");
console.log(d1,d2);

btn.addEventListener("click",()=>{
    document.querySelector("#result1")
    .innerHTML = `data:  ${d1.toLocaleDateString()}
    dni do wakacji: ${inDay(d1,d2)}`;

});
btn2.addEventListener("click",()=>{
    document.querySelector("#result2")
    .innerHTML = new Date().toLocaleTimeString();
   setInterval(()=>{
    document.querySelector("#result2")
    .innerHTML = new Date().toLocaleTimeString();
   },1000);

});

function inDay(d1, d2) {
    const t2 = d2.getTime();
    const t1 = d1.getTime();

    return Math.floor((t2-t1)/(24*3600*1000));
};
const inDay2 = (d1, d2)=> {
    const t2 = d2.getTime();
    const t1 = d1.getTime();

    return Math.floor((t2-t1)/(24*3600*1000));
};
inDay2(d1,d2);
