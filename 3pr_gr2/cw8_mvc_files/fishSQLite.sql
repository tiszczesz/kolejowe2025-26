-- SQLite
CREATE TABLE Fishes (
    Id INTEGER PRIMARY KEY ,
    Name TEXT NOT NULL,
    Species TEXT NOT NULL,
    Age INTEGER NOT NULL
);
INSERT INTO Fishes (Name, Species, Age) VALUES ('Nemo', 'Clownfish', 2);
INSERT INTO Fishes (Name, Species, Age) VALUES ('Dory', 'Blue Tang', 3);
INSERT INTO Fishes (Name, Species, Age) VALUES ('Marlin', 'Clownfish', 5);  
INSERT INTO Fishes (Name, Species, Age) VALUES ('2', 'Clownfish', 3);  
INSERT INTO Fishes (Name, Species, Age) VALUES ('3', 'Clownfish', 7);  
