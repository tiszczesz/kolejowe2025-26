import {connection,getBooks} from './MySqlRepo.js';

export async function testConnection() {
    try {
        const [rows] = await connection.execute('SELECT NOW() AS now');
        console.log('Connection successful:', rows);
        connection.end();
    } catch (error) {
        console.error('Connection failed:', error);
    }
}
async function main() {
    const books =  await getBooks();
    console.log(books);
}
main();
//testConnection();