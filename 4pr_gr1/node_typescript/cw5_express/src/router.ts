import { Router, type Request,type Response } from "express";
import fs from 'fs'
import { users } from "./data/users.js";

//przykładowy router
// export const router = (req:Request,res:Response)=>{
//     res.send("Hello from router")
// }
export const router = Router();

router.get("/hello",(req:Request,res:Response)=>{
    res.send("Hello from router")
})
router.get("/index",(req:Request,res:Response)=>{
    const html = fs.readFileSync("index.html","utf-8");
    res.send(html)
});
router.get("/users",(req:Request,res:Response)=>{
    res.json(users)
});