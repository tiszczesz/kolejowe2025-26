-- SQLite
CREATE TABLE Students (
    Id INTEGER PRIMARY KEY ,
    FirstName TEXT NOT NULL,
    LastName TEXT NOT NULL,
    BirthDate DATE    
);
INSERT INTO Students (FirstName, LastName, BirthDate) VALUES
('Anna', 'Kowalska', '2000-05-12'),
('Jan', 'Nowak', '1999-11-23'),
('Maria', 'Wiśniewska', '2001-03-17'),
('Piotr', 'Zieliński', '2000-08-30');