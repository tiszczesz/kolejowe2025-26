import {open, Database} from 'sqlite';
import sqlite3 from 'sqlite3';
import path from 'path';
import { fileURLToPath } from 'url';

// console.log(import.meta.url);
const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

// console.log(__dirname);
// console.log(__filename);
const dbPath = path.join(__dirname,'..', 'appDB.db'); //sciezka do bazy danych
console.log(dbPath);