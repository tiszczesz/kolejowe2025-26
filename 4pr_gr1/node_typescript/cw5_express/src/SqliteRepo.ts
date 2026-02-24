import Database from "better-sqlite3";
import path from "path";
import {type User } from "./data/users.js";
import { fileURLToPath } from "url";


const __filename = fileURLToPath(import.meta.url);
console.log("__filename: ", __filename);
const __dirname = path.dirname(__filename);
console.log("__dirname: ", __dirname);
const dbPath = path.join(__dirname,'..', "appUsers.db");
console.log("dbPath: ", dbPath);

let db: Database.Database|null = null;
export function getDb(): Database.Database {
    if (!db) {
        db = new Database(dbPath);
        console.log("Connected to SQLite database");
    }   
    return db;
}
export const closeDb = () => {
    if (db) {
        db.close();
        console.log("Closed SQLite database connection");
    }
}

export function getAllUsers(): User[] {
    const db = getDb();
    const stmt = db.prepare("SELECT * FROM users");
    return stmt.all() as User[];
}
export function getUserById(id: number): User | null {
    const db = getDb();
    const stmt = db.prepare("SELECT * FROM users WHERE id = ?");
    return stmt.get(id) as User || null;
}
export function createUser(name: string, email: string): User {
    const db = getDb();
    const stmt = db.prepare("INSERT INTO users (name, email) VALUES (?, ?)");
    const info = stmt.run(name, email);
    return { id: info.lastInsertRowid as number, name, email };
}
export function updateUser(id: number, name: string, email: string): User | null {
    const db = getDb();
    const stmt = db.prepare("UPDATE users SET name = ?, email = ? WHERE id = ?");
    const info = stmt.run(name, email, id); 
    if (info.changes > 0) {
        return { id, name, email };
    }   else {
        return null;
    }
}
export function deleteUser(id: number): boolean {
    const db = getDb();
    const stmt = db.prepare("DELETE FROM users WHERE id = ?");
    const info = stmt.run(id);
    return info.changes > 0;
}