import {type Request,type Response,Router } from "express";
import { getBookById, getBooks,type Book,
    getConnection, 
    deleteBookById ,
    updateBook,
    addBook
} from "./MySqlRepo.js";

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
router.delete('/books/:id', async (req: Request, res: Response) => {
    const connection = await getConnection();
    const bookId = req.params.id ?? '1';    
    console.log(`Deleting book with id=${bookId}`);
    const deleted: boolean = await deleteBookById(bookId);
    if(!deleted){
        res.status(404).send(`Book with id=${bookId} not found`);
        connection.end();
        return;
    }   
    res.status(204).send();
    connection.end();
});
router.post('/books', async (req: Request, res: Response) => {
    const connection = await getConnection();
    const newBookData: Book = req.body;
    console.log('Creating new book with data:', newBookData);
    const createdBookId: number = await addBook(newBookData);
    res.status(201).json({ id: createdBookId });
    connection.end();
});
router.put('/books/:id', async (req: Request, res: Response) => {
    const connection = await getConnection();   
    const bookId = req.params.id ?? '1'; 
    const updateData: Book = req.body;
    updateData.id = parseInt(bookId);
    console.log(`Updating book with id=${bookId} with data:`, updateData);
    const result: boolean = await updateBook( updateData);
    if(!result){
        res.status(404).send(`Book with id=${bookId} not found`);
        connection.end();
        return;
    }   
    res.json(updateData);
    connection.end();
});