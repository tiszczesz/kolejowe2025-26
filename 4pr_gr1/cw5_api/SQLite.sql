-- SQLite
CREATE TABLE books(
    id INTEGER PRIMARY KEY,
    title TEXT NOT NULL,
    author TEXT NOT NULL,
    published_year INTEGER    
);
INSERT INTO books (title, author, published_year) VALUES
('To Kill a Mockingbird', 'Harper Lee', 1960),
('1984', 'George Orwell', 1949),
('The Great Gatsby', 'F. Scott Fitzgerald', 1925);
INSERT INTO books (title, author, published_year) VALUES
('Pride and Prejudice', 'Jane Austen', 1813),
('Moby-Dick', 'Herman Melville', 1851),
('War and Peace', 'Leo Tolstoy', 1869),
('The Catcher in the Rye', 'J.D. Salinger', 1951),
('The Hobbit', 'J.R.R. Tolkien', 1937),
('The Lord of the Rings', 'J.R.R. Tolkien', 1954),
('Crime and Punishment', 'Fyodor Dostoevsky', 1866),
('Brave New World', 'Aldous Huxley', 1932),
('Jane Eyre', 'Charlotte Brontë', 1847),
('Anna Karenina', 'Leo Tolstoy', 1877);
