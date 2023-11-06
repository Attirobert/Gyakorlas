-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Nov 06. 21:39
-- Kiszolgáló verziója: 10.4.6-MariaDB
-- PHP verzió: 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `iktato`
--

DELIMITER $$
--
-- Eljárások
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `UserInsert` (IN `pNev` VARCHAR(20), IN `pJelszo` VARCHAR(40), IN `pAdmin` BOOLEAN)  MODIFIES  DATA INSERT INTO `users`(`Nev`, `Jelszo`, `Admin`) VALUES (pNev, pJelszo, pAdmin)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UserTeljesLista` ()  READS SQL DATA SELECT * FROM users$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UserUpdate` (IN `pID` INT(11), IN `pNev` VARCHAR(20) CHARSET utf8, IN `pJelszo` VARCHAR(40) CHARSET utf8, IN `pAdmin` TINYINT(1))   UPDATE `users` SET `Nev`= pNev, `Jelszo`= pJelszo, `Admin`= pAdmin WHERE `ID_user` = pID$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `beosztasok`
--

CREATE TABLE `beosztasok` (
  `Id_Beosztas` int(11) NOT NULL,
  `Beosztas` varchar(20) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- TÁBLA KAPCSOLATAI `beosztasok`:
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `iktat`
--

CREATE TABLE `iktat` (
  `Id_Iktat` int(11) NOT NULL,
  `Iktatoszam` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `IdUser` int(11) NOT NULL,
  `Datum` date NOT NULL,
  `IdTema` int(11) NOT NULL,
  `Leiras` varchar(50) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- TÁBLA KAPCSOLATAI `iktat`:
--   `IdTema`
--       `temak` -> `Id_Tema`
--   `IdUser`
--       `users` -> `ID_user`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `letters`
--

CREATE TABLE `letters` (
  `ID_letter` int(11) NOT NULL,
  `erkezett` date NOT NULL DEFAULT current_timestamp(),
  `ID_user` int(11) NOT NULL,
  `targy` varchar(250) COLLATE utf8_hungarian_ci NOT NULL,
  `leiras` text COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- TÁBLA KAPCSOLATAI `letters`:
--   `ID_user`
--       `users` -> `ID_user`
--

--
-- A tábla adatainak kiíratása `letters`
--

INSERT INTO `letters` (`ID_letter`, `erkezett`, `ID_user`, `targy`, `leiras`) VALUES
(1, '2019-07-06', 2, 'Reklamáció', 'A Lorem Ipsum egy egyszerû szövegrészlete, szövegutánzata a betûszedõ és nyomdaiparnak. A Lorem Ipsum az 1500-as évek óta standard szövegrészletként szolgált az iparban; mikor egy ismeretlen nyomdász összeállította a betûkészletét és egy példa-könyvet vagy szöveget nyomott papírra, ezt használta. '),
(2, '2019-07-07', 2, 'Tájékoztatás', 'A Lorem Ipsum egy egyszerû szövegrészlete, szövegutánzata a betûszedõ és nyomdaiparnak. A Lorem Ipsum az 1500-as évek óta standard szövegrészletként szolgált az iparban; mikor egy ismeretlen nyomdász összeállította a betûkészletét és egy példa-könyvet vagy szöveget nyomott papírra, ezt használta. '),
(3, '2019-07-08', 3, 'Reklamáció', 'A Lorem Ipsum egy egyszerû szövegrészlete, szövegutánzata a betûszedõ és nyomdaiparnak. A Lorem Ipsum az 1500-as évek óta standard szövegrészletként szolgált az iparban; mikor egy ismeretlen nyomdász összeállította a betûkészletét és egy példa-könyvet vagy szöveget nyomott papírra, ezt használta. '),
(4, '2019-07-09', 2, 'Reklamáció', ''),
(5, '2021-05-15', 3, 'Feljegyzés 23', 'Informatikai'),
(6, '2021-05-15', 3, 'Feljegyzés 23', 'Nyelvi');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `osztalyok`
--

CREATE TABLE `osztalyok` (
  `Id_Osztaly` int(11) NOT NULL,
  `Osztaly` varchar(20) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- TÁBLA KAPCSOLATAI `osztalyok`:
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `temak`
--

CREATE TABLE `temak` (
  `Id_Tema` int(11) NOT NULL,
  `Tema` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- TÁBLA KAPCSOLATAI `temak`:
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `ID_user` int(11) NOT NULL,
  `Nev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `Jelszo` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `Admin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- TÁBLA KAPCSOLATAI `users`:
--

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`ID_user`, `Nev`, `Jelszo`, `Admin`) VALUES
(1, 'Zsuzsi', '123456', 1),
(2, 'Sári', '5678', 0),
(3, 'Áron', '1234', 0),
(4, 'Zsombor', '123456', 1),
(5, 'Katalin', '1234', 1),
(6, 'TesztElek', '1234', 1),
(7, '\'MElek\'', '1234', 0);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `beosztasok`
--
ALTER TABLE `beosztasok`
  ADD PRIMARY KEY (`Id_Beosztas`);

--
-- A tábla indexei `iktat`
--
ALTER TABLE `iktat`
  ADD PRIMARY KEY (`Id_Iktat`),
  ADD UNIQUE KEY `UX_Iktat_Iktatoszam` (`Iktatoszam`),
  ADD KEY `Idx_Iktat_User` (`IdUser`),
  ADD KEY `IX_Iktat_Tema` (`IdTema`);

--
-- A tábla indexei `letters`
--
ALTER TABLE `letters`
  ADD PRIMARY KEY (`ID_letter`),
  ADD KEY `datum` (`erkezett`),
  ADD KEY `user` (`ID_user`);

--
-- A tábla indexei `osztalyok`
--
ALTER TABLE `osztalyok`
  ADD PRIMARY KEY (`Id_Osztaly`);

--
-- A tábla indexei `temak`
--
ALTER TABLE `temak`
  ADD PRIMARY KEY (`Id_Tema`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID_user`),
  ADD UNIQUE KEY `nev` (`Nev`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `beosztasok`
--
ALTER TABLE `beosztasok`
  MODIFY `Id_Beosztas` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `iktat`
--
ALTER TABLE `iktat`
  MODIFY `Id_Iktat` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `letters`
--
ALTER TABLE `letters`
  MODIFY `ID_letter` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `osztalyok`
--
ALTER TABLE `osztalyok`
  MODIFY `Id_Osztaly` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `temak`
--
ALTER TABLE `temak`
  MODIFY `Id_Tema` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `ID_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `iktat`
--
ALTER TABLE `iktat`
  ADD CONSTRAINT `FK_Iktat_Temak` FOREIGN KEY (`IdTema`) REFERENCES `temak` (`Id_Tema`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Iktat_Users` FOREIGN KEY (`IdUser`) REFERENCES `users` (`ID_user`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Megkötések a táblához `letters`
--
ALTER TABLE `letters`
  ADD CONSTRAINT `letters_ibfk_1` FOREIGN KEY (`ID_user`) REFERENCES `users` (`ID_user`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
