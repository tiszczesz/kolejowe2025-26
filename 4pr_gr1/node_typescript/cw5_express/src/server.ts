import express from 'express'
import cors from 'cors'
import { router } from './router.js';

const app = express();
const PORT = 3000;

app.use(cors()); //potrzebne gdy klient uzywa np localhost

app.use(express.json())//potrzebne do parsowania jsona z body requesta
//app.get("/",router)
app.use("/api",router) //wszystkie requesty zaczynające się od /api będą obsługiwane przez router
app.listen(PORT,()=>{
    console.log("uruchomiono express na porcie: "+PORT)
});