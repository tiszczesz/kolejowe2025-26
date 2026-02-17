import express from 'express'
import cors from 'cors'

const app = express();
const PORT = 3000;

app.use(cors()); //potrzebne gdy klient uzywa np localhost

app.use(express.json())
app.get('/hello',(req,res)=>{
    res.send("Hello from express")
});
app.get('/html',(req,res)=>{
    res.send("<h2>Hello from express</h2>")
})
app.listen(PORT,()=>{
    console.log("uruchomiono express na porcie: "+PORT)
});