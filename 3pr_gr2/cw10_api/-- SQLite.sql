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
INSERT INTO users (name, email, role_id) VALUES
    ('Alice Johnson', 'alice@example.com', 1),
    ('Bob Smith', 'bob@example.com', 2),
    ('Charlie Brown', 'charlie@example.com', 3),
    ('Diana Prince', 'diana@example.com', 4),
    ('Edward Norton', 'edward@example.com', 5),
    ('Fiona Green', 'fiona@example.com', 2),
    ('George Harris', 'george@example.com', 3),
    ('Hannah White', 'hannah@example.com', 1),
    ('Ivan Black', 'ivan@example.com', 4),
    ('Julia Roberts', 'julia@example.com', 2);