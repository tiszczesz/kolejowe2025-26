import {type Request,type Response,Router } from "express";
import { getBookById, getBooks,type Book,getConnection } from "./MySqlRepo.js";

export const router = Router();

router.get('/books', async (req: Request, res: Response) => {
    const connection = await getConnection();
    const books = await getBooks();
    connection.end();
    res.json(books);
});

router.get('/books/:id', async (req: Request, res: Response) => {
    const connection = await getConnection();
    const bookId = req.params.id ?? '1';
    console.log(`Fetching book with id=${bookId}`);
    const  book:Book|undefined = await getBookById(bookId);
    if(!book){
        res.status(404).send(`Book with id=${bookId} not found`);
        connection.end();
        return;
    }
    res.json(book);
    connection.end();
});