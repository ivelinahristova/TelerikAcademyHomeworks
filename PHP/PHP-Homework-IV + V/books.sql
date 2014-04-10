-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Време на генериране: 
-- Версия на сървъра: 5.5.32
-- Версия на PHP: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- БД: `books`
--
CREATE DATABASE IF NOT EXISTS `books` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `books`;

-- --------------------------------------------------------

--
-- Структура на таблица `authors`
--

CREATE TABLE IF NOT EXISTS `authors` (
  `author_id` int(11) NOT NULL AUTO_INCREMENT,
  `author_name` varchar(250) NOT NULL,
  PRIMARY KEY (`author_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Схема на данните от таблица `authors`
--

INSERT INTO `authors` (`author_id`, `author_name`) VALUES
(1, 'Stephen King'),
(2, 'Suzanne Collins'),
(3, 'John Lock'),
(4, 'John Tolkin');

-- --------------------------------------------------------

--
-- Структура на таблица `books`
--

CREATE TABLE IF NOT EXISTS `books` (
  `book_id` int(11) NOT NULL AUTO_INCREMENT,
  `book_title` varchar(250) NOT NULL,
  PRIMARY KEY (`book_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Схема на данните от таблица `books`
--

INSERT INTO `books` (`book_id`, `book_title`) VALUES
(1, 'The Hunger Games'),
(2, 'Catching Fire'),
(3, 'The Hobbit'),
(4, 'Random Book');

-- --------------------------------------------------------

--
-- Структура на таблица `books_authors`
--

CREATE TABLE IF NOT EXISTS `books_authors` (
  `book_id` int(11) NOT NULL,
  `author_id` int(11) NOT NULL,
  KEY `book_id` (`book_id`),
  KEY `author_id` (`author_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `books_authors`
--

INSERT INTO `books_authors` (`book_id`, `author_id`) VALUES
(1, 1),
(1, 2),
(2, 2),
(3, 4),
(4, 2),
(4, 3);

-- --------------------------------------------------------

--
-- Структура на таблица `comments`
--

CREATE TABLE IF NOT EXISTS `comments` (
  `comment_id` int(11) NOT NULL AUTO_INCREMENT,
  `comment_text` varchar(150) NOT NULL,
  `comment_date` datetime NOT NULL,
  `book_id` int(11) NOT NULL,
  PRIMARY KEY (`comment_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Схема на данните от таблица `comments`
--

INSERT INTO `comments` (`comment_id`, `comment_text`, `comment_date`, `book_id`) VALUES
(1, 'cool, dude', '2013-10-28 00:00:00', 2),
(2, 'commentssss', '0000-00-00 00:00:00', 0),
(3, 'csdfghtrhjtyhj', '2013-10-27 22:36:03', 0),
(4, 'vfhbgtjhyj', '2013-10-27 22:36:54', 0),
(5, 'vfhbgtjhyj', '2013-10-27 22:37:40', 0),
(6, 'newnewnewnew', '2013-10-27 22:39:58', 2),
(7, 'comentarrrrr', '2013-10-27 22:41:54', 2),
(8, 'hunger games is interesting book!', '2013-10-27 22:43:21', 1);

-- --------------------------------------------------------

--
-- Структура на таблица `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(50) NOT NULL,
  `user_password` varchar(50) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Схема на данните от таблица `users`
--

INSERT INTO `users` (`user_id`, `user_name`, `user_password`) VALUES
(1, 'user', 'qwerty');

-- --------------------------------------------------------

--
-- Структура на таблица `users_comments`
--

CREATE TABLE IF NOT EXISTS `users_comments` (
  `user_id` int(11) NOT NULL,
  `comment_id` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `users_comments`
--

INSERT INTO `users_comments` (`user_id`, `comment_id`) VALUES
(1, 1),
(0, 4),
(0, 6),
(0, 7),
(0, 8);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
