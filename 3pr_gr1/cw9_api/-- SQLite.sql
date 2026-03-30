-- SQLite
CREATE TABLE Students (
    Id INTEGER PRIMARY KEY,
    Firstname TEXT NOT NULL,
    Lastname TEXT NOT NULL,
    AVG_Grade REAL,
    Departament_id INTEGER,
    FOREIGN KEY (Departament_id) REFERENCES Departaments(Id)
);
CREATE TABLE Departaments (
    Id INTEGER PRIMARY KEY,
    Name TEXT NOT NULL
);
INSERT INTO Departaments (Name) VALUES ('Computer Science');
INSERT INTO Departaments (Name) VALUES ('Mathematics');
INSERT INTO Departaments (Name) VALUES ('Physics');
INSERT INTO Departaments (Name) VALUES ('Chemistry');

INSERT INTO Students (Firstname, Lastname, AVG_Grade, Departament_id) VALUES ('John', 'Smith', 4.5, 1);
INSERT INTO Students (Firstname, Lastname, AVG_Grade, Departament_id) VALUES ('Alice', 'Johnson', 3.8, 2);
INSERT INTO Students (Firstname, Lastname, AVG_Grade, Departament_id) VALUES ('Bob', 'Williams', 4.2, 1);
INSERT INTO Students (Firstname, Lastname, AVG_Grade, Departament_id) VALUES ('Emma', 'Brown', 3.5, 3);
INSERT INTO Students (Firstname, Lastname, AVG_Grade, Departament_id) VALUES ('Michael', 'Jones', 4.8, 4);
INSERT INTO Students (Firstname, Lastname, AVG_Grade, Departament_id) VALUES ('Sophia', 'Davis', 3.9, 2);
INSERT INTO Students (Firstname, Lastname, AVG_Grade, Departament_id) VALUES ('James', 'Miller', 4.1, 3);
INSERT INTO Students (Firstname, Lastname, AVG_Grade, Departament_id) VALUES ('Olivia', 'Wilson', 4.6, 1);
INSERT INTO Students (Firstname, Lastname, AVG_Grade, Departament_id) VALUES ('William', 'Moore', 3.7, 4);
INSERT INTO Students (Firstname, Lastname, AVG_Grade, Departament_id) VALUES ('Isabella', 'Taylor', 4.3, 2);