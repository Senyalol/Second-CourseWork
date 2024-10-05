-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Авг 01 2024 г., 00:33
-- Версия сервера: 10.4.32-MariaDB
-- Версия PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `accounts3`
--

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `ID` int(9) NOT NULL,
  `Admin` tinyint(1) NOT NULL,
  `ФИО` text NOT NULL,
  `PhoneNum` varchar(13) NOT NULL,
  `HomeAdress` text NOT NULL,
  `Почта` varchar(50) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Карта` varchar(16) NOT NULL,
  `Login` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`ID`, `Admin`, `ФИО`, `PhoneNum`, `HomeAdress`, `Почта`, `Email`, `Карта`, `Login`, `Password`) VALUES
(1, 0, 'Науменко Семен Александрович', '+375297809378', 'г.Витебск ул.Короткевича 16, кв 99 подьезд 2', 'Пункт выдачи заказов г.Витебск', 's.a.naumenko@student.psu.by', '9112380122467634', 'Sema', '1111'),
(2, 0, 'Щербо Никита Валерьевич', '+375296565369', 'г.Борисов ул.Пушкина 11', 'Пункт выдачи г.Борисов', 'n.v.scherbo@students.psu.by', '9112380164748931', 'Nik', '1010'),
(7, 0, 'Купчин Даниил Юрьевич', '375296783534', 'г.Орша Проспект Победы 5', 'Пункт выдачи заказовг.Орша', 'd.y.kupchin@students.psu.by', '521277689495325', 'Kupcha', '9999'),
(13, 0, 'Халимов Мурад Калсынович', '375296873259', 'г.Полоцк', 'Пункт выдачи г.Полоцк', 'students@psu.by', '4214412521521', 'user5', '88337507'),
(14, 0, 'Купчин Даниил Юрьевич', '19', 'г.Орша ул. Гагарина 227', 'Почтовое отделение №7 г.Орша', 'd.y.kupchin@students.psu.by', '4214867965790012', 'BMW', '0707'),
(15, 0, 'Сергей Валерьевич', '19', 'г.Брест', 'Почтовое отделение №11 г.Брест', 'students@psu.by', '5215876598907857', 'User', '13212'),
(16, 1, 'Мистер Админ Александрович', '666', 'Красный дом в Витебске', 'нет', 'SemaCool@mail.ru', '42153654756856', 'Admin', '8337507S');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Login` (`Login`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
