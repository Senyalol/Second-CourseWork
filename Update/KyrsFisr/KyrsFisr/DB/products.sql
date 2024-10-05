-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Авг 01 2024 г., 00:34
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
-- База данных: `products`
--

-- --------------------------------------------------------

--
-- Структура таблицы `product`
--

CREATE TABLE `product` (
  `ID` int(100) NOT NULL,
  `Бренд` text NOT NULL,
  `Год` int(8) NOT NULL,
  `Материал` text NOT NULL,
  `Батарея` int(10) NOT NULL,
  `Категория` text NOT NULL,
  `Цена` float NOT NULL,
  `Count` int(254) NOT NULL,
  `Фото` text CHARACTER SET utf16 COLLATE utf16_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Дамп данных таблицы `product`
--

INSERT INTO `product` (`ID`, `Бренд`, `Год`, `Материал`, `Батарея`, `Категория`, `Цена`, `Count`, `Фото`) VALUES
(1, 'LG', 2024, 'Алюминий', 0, 'Бытовая техника', 2666.8, 95, 'C:\\\\Users\\\\semka\\\\source\\repos\\\\KyrsFisr\\\\KyrsFisr\\\\images\\\\holod2.jpg'),
(2, 'Asus', 2022, 'Пластик', 5600, 'Ноутбуки', 3799, 246, 'C:\\\\Users\\\\semka\\\\source\\\\repos\\\\KyrsFisr\\\\KyrsFisr\\\\images\\\\MegaNout.jpg'),
(3, 'Asus', 2021, 'Алюминий', 5000, 'Ноутбуки', 2343.8, 200, 'C:\\Users\\semka\\source\\repos\\KyrsFisr\\KyrsFisr\\images\\laptop2.jpg'),
(4, 'Atlant', 2022, 'Латунь', 0, 'Бытовая техника', 2700, 100, 'C:\\\\Users\\\\semka\\\\source\\\\repos\\\\KyrsFisr\\\\KyrsFisr\\images\\\\holod3.jpg'),
(5, 'Apple', 2021, 'Пластик', 3000, 'Смартфоны', 2500, 100, 'C:\\\\Users\\\\semka\\\\source\\\\repos\\\\KyrsFisr\\\\KyrsFisr\\images\\\\iphone13.png'),
(6, 'Xiaomi', 2023, 'Пластик', 5000, 'Смартфоны', 549, 100, 'C:\\\\Users\\\\semka\\\\source\\\\repos\\\\KyrsFisr\\\\KyrsFisr\\images\\\\20230927170949099_WhatsApp_Image_2023-09-27_at_17.09.05.jpeg'),
(7, 'Samsung', 2022, 'Сталь', 0, 'Телевизоры', 2682, 100, 'C:\\\\Users\\\\semka\\\\source\\\\repos\\\\KyrsFisr\\\\KyrsFisr\\images\\\\TV.jpg'),
(8, 'LG', 2023, 'Сталь', 0, 'Телевизоры', 6999, 100, 'C:\\\\Users\\\\semka\\\\source\\\\repos\\\\KyrsFisr\\\\KyrsFisr\\images\\\\6450c5d576292_full.jpg'),
(9, 'Xiaomi', 2020, 'Алюминий', 1000, 'Гаджеты', 159, 99, 'C:\\\\Users\\\\semka\\\\source\\\\repos\\\\KyrsFisr\\\\KyrsFisr\\images\\\\1037527_r1978.jpg'),
(10, 'Sony', 2019, 'Пластик', 2000, 'Гаджеты', 999, 98, 'C:\\\\Users\\\\semka\\\\source\\\\repos\\\\KyrsFisr\\\\KyrsFisr\\images\\\\sony.jpg'),
(11, 'HP', 2022, 'Пластик', 5000, 'Планшеты', 599, 98, 'C:\\\\Users\\\\semka\\\\source\\\\repos\\\\KyrsFisr\\\\KyrsFisr\\images\\\\Honor_X8_Lite_Launch.jpg'),
(12, 'Samsung', 2023, 'Сталь', 4000, 'Планшеты', 1200, 100, 'C:\\\\Users\\\\semka\\\\source\\\\repos\\\\KyrsFisr\\\\KyrsFisr\\images\\\\x205-a8-lte-gray-1.jpg'),
(13, 'Xiaomi', 2018, 'Пластик', 1000, 'Ноутбуки', 899, 100, 'C:\\Users\\semka\\source\\repos\\KyrsFisr\\KyrsFisr\\images\\laptop.jpg'),
(14, 'LG', 2024, 'Латунь', 0, 'Телевизоры', 1740, 80, 'C:\\Users\\semka\\source\\repos\\KyrsFisr\\KyrsFisr\\images\\DZ_1_N.jpg');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `product`
--
ALTER TABLE `product`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4526;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
