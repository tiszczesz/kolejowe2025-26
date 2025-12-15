-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 15, 2025 at 03:43 PM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `4pr_gr2_books`
--
CREATE DATABASE IF NOT EXISTS `4pr_gr2_books` DEFAULT CHARACTER SET utf8 COLLATE utf8_polish_ci;
USE `4pr_gr2_books`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `books`
--

DROP TABLE IF EXISTS `books`;
CREATE TABLE `books` (
  `id` int(11) NOT NULL,
  `title` varchar(50) NOT NULL,
  `author` varchar(50) NOT NULL,
  `price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`id`, `title`, `author`, `price`) VALUES
(1, 'Pan Tadeusz', 'Adam Mickiewicz', 39.90),
(2, 'Lalka', 'Bolesław Prus', 29.50),
(3, 'Krzyżacy', 'Henryk Sienkiewicz', 34.99),
(4, 'Ferdydurke', 'Witold Gombrowicz', 24.00),
(5, 'Zbrodnia i kara', 'Fiodor Dostojewski', 44.90),
(6, 'Ogniem i mieczem', 'Henryk Sienkiewicz', 31.20),
(7, 'Mały Książę', 'Antoine de Saint-Exupéry', 19.99),
(8, 'Sto lat samotności', 'Gabriel García Márquez', 49.50),
(9, 'Quo Vadis', 'Henryk Sienkiewicz', 27.75),
(10, 'Medaliony', 'Zofia Nałkowska', 22.00);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
