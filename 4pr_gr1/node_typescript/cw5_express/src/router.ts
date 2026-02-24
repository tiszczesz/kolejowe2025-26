import { Router, type Request,type Response } from "express";
import { getUserById,createUser,getAllUsers } from "./SqliteRepo.js";
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
router.get("/users/:id",(req:Request,res:Response)=>{
    const id:number =  parseInt(req.params.id as string); ;
    const user = getUserById(id);
    if(user){
        res.json(user)
    } else {
        res.status(404).json({message:"User not found"})
    }
});
router.post("/users",(req:Request,res:Response)=>{
    const {name,email} = req.body;
    if(name && email){
        const newUser = createUser(name,email);
        res.status(201).json(newUser);
    }
    else {
        res.status(400).json({message:"Name and email are required"})
    }
})
router.get("/allusers",(req:Request,res:Response)=>{
    const allUsers = getAllUsers();
    res.json(allUsers)  
});