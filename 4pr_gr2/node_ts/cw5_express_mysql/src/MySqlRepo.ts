import mysql from 'mysql2/promise';

export const connection = await mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: '',
    database: '4pr_gr2_books'
});

export const getBooks = async () =>{
    const [rows] = await connection.execute('SELECT * FROM books');
    await connection.end();
    return rows;
};