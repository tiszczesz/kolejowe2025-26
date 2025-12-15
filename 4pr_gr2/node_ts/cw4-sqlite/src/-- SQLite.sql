-- SQLite
CREATE TABLE users (
    id INTEGER PRIMARY KEY,
    name TEXT NOT NULL,
    email TEXT UNIQUE NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);
INSERT INTO users (name, email) VALUES
('Jan Kowalski', 'jan.kowalski@example.com'),
('Anna Nowak', 'anna.nowak@example.com'),
('Piotr Zielinski', 'piotr.zielinski@example.com'),
('Katarzyna Wisniewska', 'katarzyna.wisniewska@example.com'),
('Michal Wojcik', 'michal.wojcik@example.com'),
('Agnieszka Kowalczyk', 'agnieszka.kowalczyk@example.com'),
('Tomasz Kaminski', 'tomasz.kaminski@example.com'),
('Ewa Lewandowska', 'ewa.lewandowska@example.com'),
('Marcin Kaczmarek', 'marcin.kaczmarek@example.com'),
('Joanna Szymanska', 'joanna.szymanska@example.com');