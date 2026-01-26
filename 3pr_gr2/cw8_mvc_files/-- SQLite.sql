-- SQLite
CREATE TABLE Books (
    id INTEGER PRIMARY KEY,
    title TEXT NOT NULL,
    author TEXT NOT NULL,
    yearPublished INTEGER
);

INSERT INTO Books (title, author, yearPublished) VALUES
('To Kill a Mockingbird', 'Harper Lee', 1960),
('1984', 'George Orwell', 1949),
('The Great Gatsby', 'F. Scott Fitzgerald', 1925),
('The Catcher in the Rye', 'J.D. Salinger', 1951),
('Moby Dick', 'Herman Melville', 1851);

