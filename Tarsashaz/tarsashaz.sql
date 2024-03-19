-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Dec 12. 16:32
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.1.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `tarsashaz`
--
CREATE DATABASE IF NOT EXISTS `tarsashaz` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `tarsashaz`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `epuletek`
--

CREATE TABLE `epuletek` (
  `epuletid` bigint(20) UNSIGNED NOT NULL,
  `utcanev` varchar(40) NOT NULL,
  `hazszam` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `epuletek`
--

INSERT INTO `epuletek` (`epuletid`, `utcanev`, `hazszam`) VALUES
(1, 'Fő', 1),
(2, 'Fő', 14),
(3, 'Kossuth', 5);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `lakok`
--

CREATE TABLE `lakok` (
  `lakoid` bigint(20) UNSIGNED NOT NULL,
  `lakonev` varchar(40) NOT NULL,
  `szulev` year(4) NOT NULL,
  `epuletid` bigint(20) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `lakok`
--

INSERT INTO `lakok` (`lakoid`, `lakonev`, `szulev`, `epuletid`) VALUES
(1, 'Ábrahám', '2001', 2),
(2, 'Mátyás', '1978', 2),
(3, 'Elemér', '2003', 3),
(4, 'Baltazár', '1988', 3),
(5, 'Gabriella', '2001', 1);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `epuletek`
--
ALTER TABLE `epuletek`
  ADD PRIMARY KEY (`epuletid`);

--
-- A tábla indexei `lakok`
--
ALTER TABLE `lakok`
  ADD PRIMARY KEY (`lakoid`),
  ADD KEY `fk_lakok_epulet` (`epuletid`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `epuletek`
--
ALTER TABLE `epuletek`
  MODIFY `epuletid` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `lakok`
--
ALTER TABLE `lakok`
  MODIFY `lakoid` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `lakok`
--
ALTER TABLE `lakok`
  ADD CONSTRAINT `fk_lakok_epulet` FOREIGN KEY (`epuletid`) REFERENCES `epuletek` (`epuletid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
