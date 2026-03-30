-- SQLite
CREATE TABLE users (
    id INTEGER PRIMARY KEY,
    name TEXT NOT NULL,
    email TEXT NOT NULL,
    role_id INTEGER,
    FOREIGN KEY (role_id) REFERENCES roles(id)
);
CREATE TABLE roles (
    id INTEGER PRIMARY KEY,
    name TEXT NOT NULL
);
INSERT INTO roles (name) VALUES ('Admin'), ('User'), ('Guest'), ('Moderator'), ('Editor');