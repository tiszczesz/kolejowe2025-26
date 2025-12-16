import mysql from 'mysql2/promise';

export  type Book = {
    id: number;
    title: string;
    author: string;
    price: number;
}

let connection: mysql.Connection | null = null;

async function createNewConnection() {
    return await mysql.createConnection({
        host: 'localhost',
        user: 'root',
        password: '',
        database: '4pr_gr2_books'
    });
}

export async function getConnection(): Promise<mysql.Connection> {
    if (!connection) {
        connection = await createNewConnection();
        return connection;
    }
    return connection;    
}

// convenience helper: executes a query, ensuring the connection is open


export const getBooks = async (): Promise<Book[]> =>{
    connection = await getConnection();
    const [rows] = await connection.execute('SELECT * FROM books');
    await connection.end();
    connection = null;
    return rows as Book[];
};

export const getBookById = async (id: string): Promise<Book|undefined> =>{
    connection = await getConnection();
    const [rows] = await connection.execute('SELECT * FROM books WHERE id = ?', [id]);
    console.log(`Fetching book with id=${id}`, rows);
    await connection.end();
    connection = null;
    if((rows as Book[]).length === 0){
        console.log(`No book found with id=${id}`);
        return  undefined;
    }
     console.log(`Book found with id=${id}`);
    return (rows as Book[])[0];
};