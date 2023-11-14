-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Nov 14. 10:33
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
CREATE DATABASE IF NOT EXISTS `iktato` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `iktato`;

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
-- A tábla adatainak kiíratása `beosztasok`
--

INSERT INTO `beosztasok` (`Id_Beosztas`, `Beosztas`) VALUES
(1, 'Igazgató            '),
(2, 'Főmérnök            '),
(5, 'Értékesítő          '),
(6, 'Árubeszerző         '),
(7, 'Belső ellenőr       '),
(8, 'Rakodó              '),
(9, 'Szalagvezető        '),
(10, 'Raktáros            ');

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
-- A tábla adatainak kiíratása `iktat`
--

INSERT INTO `iktat` (`Id_Iktat`, `Iktatoszam`, `IdUser`, `Datum`, `IdTema`, `Leiras`) VALUES
(2, '458                 ', 3, '2023-10-25', 2, 'uvtft                                             '),
(3, '2023/014            ', 3, '2023-10-10', 2, 'iofrdzkj                                          '),
(4, '2023/015            ', 5, '2023-10-11', 1, 'iőhourcz u9z8 v7                                  '),
(5, '2023/016            ', 6, '2023-10-11', 1, 'nukguf uhuzz                                      '),
(6, '2023/017            ', 5, '2023-10-11', 1, 'hkhui                                             '),
(7, '20231010/1          ', 6, '2023-10-10', 4, 'iubvzd ftdfr                                      ');

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
-- A tábla adatainak kiíratása `osztalyok`
--

INSERT INTO `osztalyok` (`Id_Osztaly`, `Osztaly`) VALUES
(1, 'Igazgatóság         '),
(2, 'Értékesítés         '),
(3, 'Beszerzés           '),
(4, 'Beruházás           '),
(5, 'Kontrolling         '),
(6, 'Termelés            ');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `temak`
--

CREATE TABLE `temak` (
  `Id_Tema` int(11) NOT NULL,
  `Tema` varchar(20) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `temak`
--

INSERT INTO `temak` (`Id_Tema`, `Tema`) VALUES
(1, 'Beszerzés           '),
(2, 'Értékesítés         '),
(4, 'Raktározás          '),
(3, 'Ügyfél reklamációk  ');

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
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`ID_user`, `Nev`, `Jelszo`, `Admin`) VALUES
(1, 'Zsuzsi', '123456', 1),
(2, 'Sári', '5678', 0),
(3, 'Áron', '1234', 0),
(4, 'Zsombor', '123456', 1),
(5, 'Katalin', '1234', 1),
(6, 'TesztElek', '1234', 1),
(7, '\'MElek\'', '1234', 0),
(8, 'Zsolti              ', '1234      ', 0),
(9, 'Berci               ', '1234      ', 0),
(10, 'Zoli                ', '1234      ', 0),
(1008, 'Margó               ', '1234      ', 1);

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
  ADD PRIMARY KEY (`Id_Tema`),
  ADD UNIQUE KEY `Tema` (`Tema`);

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
  MODIFY `Id_Beosztas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `iktat`
--
ALTER TABLE `iktat`
  MODIFY `Id_Iktat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT a táblához `letters`
--
ALTER TABLE `letters`
  MODIFY `ID_letter` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `osztalyok`
--
ALTER TABLE `osztalyok`
  MODIFY `Id_Osztaly` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `temak`
--
ALTER TABLE `temak`
  MODIFY `Id_Tema` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `ID_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1009;

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
