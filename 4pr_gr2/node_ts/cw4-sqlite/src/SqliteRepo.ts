import {open, Database} from 'sqlite';
import sqlite3 from 'sqlite3';
import path from 'path';
import { fileURLToPath } from 'url';

// console.log(import.meta.url);
const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);
export type User =  {
    id: number;
    name: string;
    email: string;
    created_at: string; // DATETIME (ISO string) from SQLite
}


// console.log(__dirname);
// console.log(__filename);
const dbPath = path.join(__dirname,'..', 'appDB.db'); //sciezka do bazy danych
console.log(dbPath);

let db: Database | null = null; // Zmienna do przechowywania instancji bazy danych

export const initDB = async (): Promise<Database> => {
    if(db) return db; // jeśli baza już jest zainicjalizowana, zwróć ją
    db = await open({
        filename: dbPath,
        driver: sqlite3.Database
    });
    return db;
}
 
export const getAllUsers = async (): Promise<User[]|undefined> => {
    const database = await initDB();
    const users: User[]|undefined = await database.get<User[]>('SELECT * FROM users');
    return users;
}