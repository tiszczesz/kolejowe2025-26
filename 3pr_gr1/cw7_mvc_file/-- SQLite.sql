-- SQLite
CREATE TABLE Movies (
    id INTEGER PRIMARY KEY,
    title TEXT NOT NULL,
    director TEXT NOT NULL,
    year  INTEGER
);

INSERT INTO Movies (title, director, year) VALUES ('The Shawshank Redemption', 'Frank Darabont', 1994);
INSERT INTO Movies (title, director, year) VALUES ('The Godfather', 'Francis Ford Coppola', 1972);
INSERT INTO Movies (title, director, year) VALUES ('The Dark Knight', 'Christopher Nolan', 2008);
INSERT INTO Movies (title, director, year) VALUES ('Pulp Fiction', 'Quentin Tarantino', 1994);
INSERT INTO Movies (title, director, year) VALUES ('Forrest Gump', 'Robert Zemeckis', 1994);
INSERT INTO Movies (title, director, year) VALUES ('Inception', 'Christopher Nolan', 2010);
INSERT INTO Movies (title, director, year) VALUES ('The Matrix', 'Lana Wachowski, Lilly Wachowski', 1999);
INSERT INTO Movies (title, director, year) VALUES ('Gladiator', 'Ridley Scott', 2000);
INSERT INTO Movies (title, director, year) VALUES ('Interstellar', 'Christopher Nolan', 2014);
INSERT INTO Movies (title, director, year) VALUES ('The Avengers', 'Joss Whedon', 2012);
