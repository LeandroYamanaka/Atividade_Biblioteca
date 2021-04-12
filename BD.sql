-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 12, 2021 at 11:44 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `biblioteca`
--

-- --------------------------------------------------------

--
-- Table structure for table `emprestimos`
--

CREATE TABLE `emprestimos` (
  `Id` int(11) NOT NULL,
  `DataEmprestimo` datetime(6) NOT NULL,
  `DataDevolucao` datetime(6) NOT NULL,
  `NomeUsuario` longtext DEFAULT NULL,
  `Telefone` longtext DEFAULT NULL,
  `Devolvido` tinyint(1) NOT NULL,
  `LivroId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `emprestimos`
--

INSERT INTO `emprestimos` (`Id`, `DataEmprestimo`, `DataDevolucao`, `NomeUsuario`, `Telefone`, `Devolvido`, `LivroId`) VALUES
(1, '2021-04-07 00:00:00.000000', '2021-04-14 00:00:00.000000', 'Administrador', '11 91234-5678', 0, 2),
(2, '2021-04-01 00:00:00.000000', '2021-04-06 00:00:00.000000', 'Carlos', '11 98743-0184', 0, 15);

-- --------------------------------------------------------

--
-- Table structure for table `livros`
--

CREATE TABLE `livros` (
  `Id` int(11) NOT NULL,
  `Titulo` longtext DEFAULT NULL,
  `Autor` longtext DEFAULT NULL,
  `Ano` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `livros`
--

INSERT INTO `livros` (`Id`, `Titulo`, `Autor`, `Ano`) VALUES
(2, 'Os Segredos da Mente Milionária', 'Eker, T. Harv', 1992),
(3, 'Mais Esperto Que o Diabo', 'Hill, Napoleon', 2014),
(4, 'Pai Rico, Pai Pobre', 'Kiyosaki, Robert T.', 2017),
(5, 'Do Mil Ao Milhão', 'Nigro, Thiago', 2018),
(6, 'Harry Potter e A Pedra Filosofal 1', 'Rowling, J. K.', 2017),
(7, 'Harry Potter e O Prisioneiro De Azkaban 3', 'Rowling, J. K.', 2017),
(8, 'Harry Potter e A Ordem da Fênix 5', 'Rowling, J. K.', 2017),
(9, 'Harry Potter e O Cálice De Fogo 4', 'Rowling, J. K.', 2017),
(10, 'Harry Potter e A Criança Amaldiçoada - Parte Um e Dois', 'Rowling, J. K.', 2016),
(11, 'O Senhor Dos Anéis: A Sociedade Do Anel', 'Tolkien, J.R.R.', 2019),
(12, 'O Senhor Dos Anéis: As Duas Torres', 'Tolkien, J.R.R.', 2019),
(13, 'O Senhor Dos Anéis: O Retorno Do Rei', 'Tolkien, J.R.R.', 2019),
(14, 'O Poder da Autorresponsabilidade', 'Vieira, Paulo', 2018),
(15, 'A Garota do Lago', 'Donlea, Charlie', 2017),
(16, 'Mindset', 'Carol Dweck', 2017);

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `IdUsuario` int(11) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `Telefone` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Nascimento` varchar(50) NOT NULL,
  `Login` varchar(50) NOT NULL,
  `Senha` varchar(50) NOT NULL,
  `Nivel` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`IdUsuario`, `Nome`, `Telefone`, `Email`, `Nascimento`, `Login`, `Senha`, `Nivel`) VALUES
(6, 'Administrador', '11 91234-5678', 'admin@biblioteca.com', '25/07/1990', 'admin', '123', 'Administrador'),
(7, 'Leandro', '11963264010', 'leandroyamanaka@gmail.com', '25/08/1990', 'leandro', '123456', 'Usuario'),
(8, 'Carlos', '11 98743-0184', 'Carlos@Biblioteca.com', '26/09/1987', 'Carlos', '123456', 'Usuario');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20210406220058_CreateDatabase', '3.0.0'),
('20210407011219_ChangeVarchar', '3.0.0');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `emprestimos`
--
ALTER TABLE `emprestimos`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Emprestimos_LivroId` (`LivroId`);

--
-- Indexes for table `livros`
--
ALTER TABLE `livros`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`IdUsuario`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `emprestimos`
--
ALTER TABLE `emprestimos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `livros`
--
ALTER TABLE `livros`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `IdUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `emprestimos`
--
ALTER TABLE `emprestimos`
  ADD CONSTRAINT `FK_Emprestimos_Livros_LivroId` FOREIGN KEY (`LivroId`) REFERENCES `livros` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
