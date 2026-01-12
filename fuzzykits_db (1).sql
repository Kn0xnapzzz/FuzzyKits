-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 12, 2026 at 02:57 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fuzzykits_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `cart_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT 1,
  `added_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cart`
--

INSERT INTO `cart` (`cart_id`, `user_id`, `product_id`, `quantity`, `added_at`) VALUES
(145, 21, 1, 1, '2026-01-12 13:39:53'),
(146, 21, 3, 5, '2026-01-12 13:39:56'),
(147, 21, 4, 9, '2026-01-12 13:39:57'),
(148, 21, 10, 7, '2026-01-12 13:39:59'),
(149, 21, 5, 1, '2026-01-12 13:40:02');

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `category_id` int(11) NOT NULL,
  `category_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`category_id`, `category_name`) VALUES
(21, 'มังกร'),
(7, 'หมา'),
(20, 'ฮิปโป'),
(19, 'แมลง'),
(13, 'แมว'),
(9, 'ไก่');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `order_date` timestamp NOT NULL DEFAULT current_timestamp(),
  `shipping_address` text DEFAULT NULL,
  `total_amount` decimal(10,2) NOT NULL,
  `discount_amount` decimal(10,2) NOT NULL DEFAULT 0.00,
  `status` varchar(50) NOT NULL DEFAULT 'Pending',
  `payment_proof_url` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`order_id`, `user_id`, `order_date`, `shipping_address`, `total_amount`, `discount_amount`, `status`, `payment_proof_url`) VALUES
(1, 17, '2025-12-05 03:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0947725274 | ที่อยู่: 50 หมู่ที่ 14 ซอยอยู่เย็น บ้านดอนหนองบัว ต.แสนสุข อ.วารินชำราบ จ.อุบลราชธานี 34190', 856.00, 150.00, 'Completed', 'D:\\C#\\Pic\\Payment\\8c051401-f2da-420e-ba65-ea31125ef7eb.jpg'),
(2, 18, '2025-12-12 07:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0884814097 | ที่อยู่: 6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท ต.ในเมือง อ.เมือง จ.อุบลราชธานี 34000', 535.00, 0.00, 'Completed', 'D:\\C#\\Pic\\Payment\\1d12c0ff-a55f-463e-a3db-cd3e3e9937ef.jpg'),
(3, 17, '2025-12-20 02:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0947725274 | ที่อยู่: 50 หมู่ที่ 14 ซอยอยู่เย็น บ้านดอนหนองบัว ต.แสนสุข อ.วารินชำราบ จ.อุบลราชธานี 34190', 2461.00, 0.00, 'Completed', 'D:\\C#\\Pic\\Payment\\717ac983-e45a-4aca-86f8-e1981a8e62d5.jpg'),
(4, 18, '2025-12-28 11:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0884814097 | ที่อยู่: 6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท ต.ในเมือง อ.เมือง จ.อุบลราชธานี 34000', 3584.50, 150.00, 'Completed', 'D:\\C#\\Pic\\Payment\\c4ab9548-629e-457c-a1ca-3e2bb5009521.jpg'),
(5, 17, '2026-01-02 04:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0947725274 | ที่อยู่: 50 หมู่ที่ 14 ซอยอยู่เย็น บ้านดอนหนองบัว ต.แสนสุข อ.วารินชำราบ จ.อุบลราชธานี 34190', 1284.00, 150.00, 'Completed', 'D:\\C#\\Pic\\Payment\\8c051401-f2da-420e-ba65-ea31125ef7eb.jpg'),
(6, 18, '2026-01-05 08:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0884814097 | ที่อยู่: 6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท ต.ในเมือง อ.เมือง จ.อุบลราชธานี 34000', 481.50, 0.00, 'Completed', 'D:\\C#\\Pic\\Payment\\1d12c0ff-a55f-463e-a3db-cd3e3e9937ef.jpg'),
(7, 17, '2026-01-07 02:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0947725274 | ที่อยู่: 50 หมู่ที่ 14 ซอยอยู่เย็น บ้านดอนหนองบัว ต.แสนสุข อ.วารินชำราบ จ.อุบลราชธานี 34190', 5189.50, 150.00, 'Completed', 'D:\\C#\\Pic\\Payment\\c4ab9548-629e-457c-a1ca-3e2bb5009521.jpg'),
(8, 18, '2026-01-08 07:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0884814097 | ที่อยู่: 6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท ต.ในเมือง อ.เมือง จ.อุบลราชธานี 34000', 11984.00, 150.00, 'Shipping', 'D:\\C#\\Pic\\Payment\\1d12c0ff-a55f-463e-a3db-cd3e3e9937ef.jpg'),
(9, 17, '2026-01-09 03:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0947725274 | ที่อยู่: 50 หมู่ที่ 14 ซอยอยู่เย็น บ้านดอนหนองบัว ต.แสนสุข อ.วารินชำราบ จ.อุบลราชธานี 34190', 3156.50, 0.00, 'Paid', 'D:\\C#\\Pic\\Payment\\717ac983-e45a-4aca-86f8-e1981a8e62d5.jpg'),
(10, 18, '2026-01-10 09:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0884814097 | ที่อยู่: 6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท ต.ในเมือง อ.เมือง จ.อุบลราชธานี 34000', 963.00, 0.00, 'Pending', 'D:\\C#\\Pic\\Payment\\8c051401-f2da-420e-ba65-ea31125ef7eb.jpg'),
(11, 17, '2025-12-05 03:30:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0947725274 | ที่อยู่: 50 หมู่ที่ 14 ซอยอยู่เย็น บ้านดอนหนองบัว ต.แสนสุข อ.วารินชำราบ จ.อุบลราชธานี 34190', 802.50, 150.00, 'Cancelled', 'D:\\C#\\Pic\\Payment\\8c051401-f2da-420e-ba65-ea31125ef7eb.jpg'),
(12, 18, '2025-12-12 07:15:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0884814097 | ที่อยู่: 6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท ต.ในเมือง อ.เมือง จ.อุบลราชธานี 34000', 214.00, 0.00, 'Completed', 'D:\\C#\\Pic\\Payment\\1d12c0ff-a55f-463e-a3db-cd3e3e9937ef.jpg'),
(13, 17, '2025-12-20 02:45:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0947725274 | ที่อยู่: 50 หมู่ที่ 14 ซอยอยู่เย็น บ้านดอนหนองบัว ต.แสนสุข อ.วารินชำราบ จ.อุบลราชธานี 34190', 428.00, 0.00, 'Completed', 'D:\\C#\\Pic\\Payment\\717ac983-e45a-4aca-86f8-e1981a8e62d5.jpg'),
(14, 18, '2025-12-28 11:20:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0884814097 | ที่อยู่: 6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท ต.ในเมือง อ.เมือง จ.อุบลราชธานี 34000', 642.00, 150.00, 'Completed', 'D:\\C#\\Pic\\Payment\\c4ab9548-629e-457c-a1ca-3e2bb5009521.jpg'),
(15, 17, '2026-01-01 04:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0947725274 | ที่อยู่: 50 หมู่ที่ 14 ซอยอยู่เย็น บ้านดอนหนองบัว ต.แสนสุข อ.วารินชำราบ จ.อุบลราชธานี 34190', 492.20, 0.00, 'Completed', 'D:\\C#\\Pic\\Payment\\8c051401-f2da-420e-ba65-ea31125ef7eb.jpg'),
(16, 18, '2026-01-03 08:30:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0884814097 | ที่อยู่: 6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท ต.ในเมือง อ.เมือง จ.อุบลราชธานี 34000', 695.50, 0.00, 'Completed', 'D:\\C#\\Pic\\Payment\\1d12c0ff-a55f-463e-a3db-cd3e3e9937ef.jpg'),
(17, 17, '2026-01-05 02:10:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0947725274 | ที่อยู่: 50 หมู่ที่ 14 ซอยอยู่เย็น บ้านดอนหนองบัว ต.แสนสุข อ.วารินชำราบ จ.อุบลราชธานี 34190', 909.50, 150.00, 'Completed', 'D:\\C#\\Pic\\Payment\\c4ab9548-629e-457c-a1ca-3e2bb5009521.jpg'),
(18, 18, '2026-01-07 07:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0884814097 | ที่อยู่: 6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท ต.ในเมือง อ.เมือง จ.อุบลราชธานี 34000', 642.00, 150.00, 'Shipping', 'D:\\C#\\Pic\\Payment\\1d12c0ff-a55f-463e-a3db-cd3e3e9937ef.jpg'),
(19, 17, '2026-01-08 03:20:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0947725274 | ที่อยู่: 50 หมู่ที่ 14 ซอยอยู่เย็น บ้านดอนหนองบัว ต.แสนสุข อ.วารินชำราบ จ.อุบลราชธานี 34190', 1123.50, 0.00, 'Paid', 'D:\\C#\\Pic\\Payment\\717ac983-e45a-4aca-86f8-e1981a8e62d5.jpg'),
(20, 18, '2026-01-10 09:00:00', 'คุณ กนกนภา อนันทวรรณ | โทร: 0884814097 | ที่อยู่: 6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท ต.ในเมือง อ.เมือง จ.อุบลราชธานี 34000', 1498.00, 0.00, 'Pending', 'D:\\C#\\Pic\\Payment\\8c051401-f2da-420e-ba65-ea31125ef7eb.jpg'),
(21, 18, '2026-01-10 15:33:49', 'คุณ กนกนภา อนันทวรรณ | โทร: 0884814097 | ที่อยู่: 6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท ต.ในเมือง อ.เมือง จ.อุบลราชธานี 34000', 214.00, 0.00, 'Pending', 'D:\\C#\\Pic\\Payment\\1d12c0ff-a55f-463e-a3db-cd3e3e9937ef.jpg'),
(22, 17, '2026-01-10 17:09:12', 'คุณ กนกนภา อนันทวรรณ | โทร: 0947725274 | ที่อยู่: 50 หมู่ที่ 14 ซอยอยู่เย็น บ้านดอนหนองบัว ต.แสขสุข อ.วารินชำราบ จ.อุบลราชธานี 34190', 5502.48, 907.50, 'Shipping', 'D:\\C#\\Pic\\Payment\\1d12c0ff-a55f-463e-a3db-cd3e3e9937ef.jpg'),
(23, 19, '2026-01-10 19:31:50', 'คุณ กนกนภา อนันทวรรณ | โทร: 0947725274 | ที่อยู่: 50 หมู่ที่ 14 บ้านดอนหนองบัว ต.แสนสุข อ.วารินชำราบ จ.อุบลราชธานี 34190', 20597.50, 150.00, 'Paid', 'D:\\C#\\Pic\\Payment\\1d12c0ff-a55f-463e-a3db-cd3e3e9937ef.jpg'),
(24, 20, '2026-01-11 10:58:15', 'คุณ กนกนภา อนันทวรรณ | โทร: 043009700 | ที่อยู่: มหาวิทยาลัยขอนแก่น 123 หมู่ 16 ถ.มิตรภาพ ต.ในเมือง อ.เมือง จ.ขอนแก่น 40002', 5136.00, 1200.00, 'Pending', 'D:\\C#\\Pic\\Payment\\717ac983-e45a-4aca-86f8-e1981a8e62d5.jpg'),
(25, 18, '2026-01-11 18:20:31', 'คุณ กนกนภา อนันทวรรณ | โทร: 0884814097 | ที่อยู่: 6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท ต.ในเมือง อ.เมือง จ.อุบลราชธานี 34000', 21600.63, 3562.50, 'Pending', 'D:\\C#\\Pic\\Payment\\717ac983-e45a-4aca-86f8-e1981a8e62d5.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `order_items`
--

CREATE TABLE `order_items` (
  `item_id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `price_per_unit` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `order_items`
--

INSERT INTO `order_items` (`item_id`, `order_id`, `product_id`, `quantity`, `price_per_unit`) VALUES
(1, 1, 1, 2, 350.00),
(2, 1, 3, 1, 200.00),
(3, 2, 4, 2, 250.00),
(4, 2, 7, 1, 230.00),
(5, 3, 12, 3, 650.00),
(6, 3, 1, 1, 350.00),
(7, 4, 1, 10, 350.00),
(8, 5, 11, 5, 200.00),
(9, 5, 4, 1, 250.00),
(10, 6, 3, 1, 200.00),
(11, 6, 5, 1, 250.00),
(12, 7, 12, 5, 650.00),
(13, 7, 13, 5, 350.00),
(14, 8, 1, 20, 350.00),
(15, 8, 11, 20, 200.00),
(16, 8, 12, 2, 650.00),
(17, 9, 12, 4, 650.00),
(18, 9, 1, 1, 350.00),
(19, 10, 9, 2, 350.00),
(20, 10, 10, 2, 200.00),
(21, 18, 1, 1, 350.00),
(22, 18, 3, 2, 200.00),
(23, 19, 12, 1, 650.00),
(24, 19, 11, 2, 200.00),
(25, 11, 1, 2, 350.00),
(26, 12, 3, 1, 200.00),
(27, 13, 11, 2, 200.00),
(28, 14, 4, 3, 250.00),
(29, 15, 7, 2, 230.00),
(30, 16, 12, 1, 650.00),
(31, 17, 10, 5, 200.00),
(32, 20, 1, 4, 350.00),
(33, 21, 3, 1, 200.00),
(34, 22, 10, 10, 200.00),
(35, 22, 3, 10, 200.00),
(36, 22, 1, 1, 350.00),
(37, 22, 4, 1, 250.00),
(38, 22, 5, 1, 250.00),
(39, 22, 11, 1, 200.00),
(40, 22, 12, 1, 650.00),
(41, 22, 13, 1, 350.00),
(49, 23, 1, 11, 350.00),
(50, 23, 3, 10, 200.00),
(51, 23, 4, 11, 250.00),
(52, 23, 5, 11, 250.00),
(53, 23, 10, 10, 200.00),
(54, 23, 11, 11, 200.00),
(55, 23, 13, 11, 350.00),
(56, 24, 12, 10, 600.00),
(57, 25, 14, 10, 1500.00),
(58, 25, 11, 10, 200.00),
(59, 25, 4, 15, 250.00),
(60, 25, 10, 15, 200.00);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `product_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `description` text DEFAULT NULL,
  `price` decimal(10,2) NOT NULL,
  `stock` int(11) NOT NULL,
  `image_url` varchar(255) DEFAULT NULL,
  `category_id` int(11) DEFAULT NULL,
  `is_active` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`product_id`, `name`, `description`, `price`, `stock`, `image_url`, `category_id`, `is_active`) VALUES
(1, 'ตุ๊กตาแมวสีส้ม', 'ตุ๊กตาแมวสีส้ม', 350.00, 120, 'Product_Images/8f1ee6ad-1cb7-417c-88a9-78e0074b2850.jpg', 13, 1),
(2, 'ตุ๊กตาแมวสามสี', 'ตุ๊กตาแมวสามสี', 350.00, 0, 'Product_Images/3f18f17a-9713-4fcf-8a1b-e219a71810a7.jpg', 13, 1),
(3, 'ไก่หัวเล็ก', 'ไก่หัวเล็ก', 200.00, 60, 'Product_Images/f9da1c2a-a349-4be3-a47d-35c50cc4f0da.jpg', 9, 1),
(4, 'หมานั่ง', 'หมานั่ง', 250.00, 65, 'Product_Images/18386055-b5e0-455c-80ea-e7fca004589b.jpg', 7, 1),
(5, 'แมวสามสี', 'แมวสามสี', 250.00, 60, 'Product_Images/7c1dc09b-f568-4f06-8251-584d42eb7184.jpg', 13, 1),
(6, 'หมาอ้วง', 'หมาอ้วง', 300.00, 25, 'Product_Images/e522f6dc-2978-4798-9874-c727948c7c33.jpg', 7, 0),
(7, 'ตั๊กแตน', 'ตั๊กแตน', 230.00, 30, 'Product_Images/8fc447f4-97a8-4a16-a57f-7b32e03989e5.jpg', 19, 0),
(8, 'แมลงสาบ', 'แมลงสาบ', 220.00, 20, 'Product_Images/2ca338c1-fa8c-494c-9f55-17d38a46acd3.jpg', 19, 0),
(9, 'แมวมงคล', 'แมวมงคล', 350.00, 0, 'Product_Images/44c8279d-549d-43c8-b4b9-557743a34cfe.jpg', 13, 1),
(10, 'ไก่ตัวผู้', 'ไก่ตัวผู้', 200.00, 65, 'Product_Images/7af925ef-9404-4f21-84ff-54441baf1799.jpg', 9, 1),
(11, 'ฮิปโปแคระ', 'ฮิปโปแคระ', 200.00, 90, 'Product_Images/daa959c5-3a6e-41ac-a068-2f117934e498.jpg', 20, 1),
(12, 'คู่หูแมลงสาบ', 'คู่หูแมลงสาบ', 600.00, 0, 'Product_Images/36c23cc7-13ea-4e8c-94b8-f7b6aef920f9.jpg', 19, 1),
(13, 'ตั๊กแตน', 'ตั๊กแตน', 350.00, 5, 'Product_Images/a2ca36a3-acfd-4ad7-bb7b-6ac2ec09d6f5.jpg', 19, 1),
(14, 'ครอบครัวมังกร', 'ครอบครัวมังกร', 1500.00, 30, 'Product_Images/908f7fe2-9de1-43ce-9221-98c0306b4cfa.jpg', 21, 1),
(15, 'มังกรโปเกม่อน', 'มังกรโปเกม่อน', 350.00, 20, 'Product_Images/279e9226-6e64-4dc6-83e2-80ad0e20b684.jpg', 21, 1);

-- --------------------------------------------------------

--
-- Table structure for table `promotions`
--

CREATE TABLE `promotions` (
  `promotion_id` int(11) NOT NULL,
  `code` varchar(50) NOT NULL,
  `name` varchar(255) NOT NULL,
  `discount_type` enum('percent','amount') NOT NULL,
  `discount_value` decimal(10,2) NOT NULL,
  `min_amount` decimal(10,2) DEFAULT NULL,
  `usage_limit_per_user` int(11) NOT NULL DEFAULT 1,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  `is_active` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `promotions`
--

INSERT INTO `promotions` (`promotion_id`, `code`, `name`, `discount_type`, `discount_value`, `min_amount`, `usage_limit_per_user`, `start_date`, `end_date`, `is_active`) VALUES
(5, 'HNY69', 'ต้อนรับปีใหม่69', 'percent', 15.00, 1000.00, 1, '2025-12-25', '2026-01-31', 1),
(7, 'BUY1KGETDISCOINT', 'ซื้อครบ 1000 บาท ลดทันที 150 บาท', 'amount', 150.00, 1000.00, 1, '2025-01-01', '2027-01-01', 1),
(8, 'FORJAN', 'ลดพิเศษเดือนมกราคม', 'percent', 20.00, 3000.00, 1, '2026-01-01', '2026-01-31', 1);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` char(64) NOT NULL,
  `first_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) DEFAULT NULL,
  `User_image` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `role` enum('customer','admin') NOT NULL DEFAULT 'customer',
  `reset_token` varchar(6) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `email`, `password`, `first_name`, `last_name`, `User_image`, `role`, `reset_token`, `created_at`) VALUES
(16, 'Admin', 'kanok.kanok@gmail.com', '15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225', 'กนกนภา', 'อนันทวรรณ', 'User_Images/user_KK.jpg', 'admin', NULL, '2025-12-20 13:28:37'),
(17, 'Kanok', 'KanokAnun@gmail.com', '15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225', 'กนกนภา', 'อนันทวรรณ', 'User_Images/user_17_639036870476579871.jpg', 'customer', NULL, '2025-12-20 13:32:12'),
(18, 'Kn', 'kanok.napa@gmail.com', '15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225', 'กนกนภา', 'อนันทวรรณ', 'User_Images/user_Kn.jpg', 'customer', NULL, '2026-01-08 18:12:48'),
(19, 'Kanoknapa', 'kanoknapa.a@gmail.com', '15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225', 'กนกนภา', 'อนันทวรรณ', 'User_Images/user_19_639036957331270391.jpg', 'customer', NULL, '2026-01-10 19:14:01'),
(20, 'User', 'kanoknapa.a@kkumail.com', '15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225', 'กนกนภา', 'อนันทวรรณ', 'User_Images/user_User.jpg', 'customer', NULL, '2026-01-11 10:22:30'),
(21, 'YoklnwZa', 'lnwZa007@gmail.com', 'eb3766c4df769c3f2c7b2677faea8f288e3c071d40cf744837010b388fd8752e', 'Yok', 'lnwZa', 'User_Images/default_user.png', 'customer', NULL, '2026-01-12 13:37:42');

-- --------------------------------------------------------

--
-- Table structure for table `user_addresses`
--

CREATE TABLE `user_addresses` (
  `address_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `address_detail` text NOT NULL,
  `sub_district` varchar(100) DEFAULT NULL,
  `district` varchar(100) DEFAULT NULL,
  `province` varchar(100) DEFAULT NULL,
  `zip_code` varchar(10) DEFAULT NULL,
  `phone_number` varchar(20) NOT NULL,
  `is_default` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_addresses`
--

INSERT INTO `user_addresses` (`address_id`, `user_id`, `address_detail`, `sub_district`, `district`, `province`, `zip_code`, `phone_number`, `is_default`) VALUES
(11, 16, 'vjk place', 'ในเมือง', 'เมือง', 'ขอนแก่น', '40000', '0947725274', 1),
(13, 17, '50 หมู่ที่ 14 ซอยอยู่เย็น บ้านดอนหนองบัว', 'แสขสุข', 'วารินชำราบ', 'อุบลราชธานี', '34190', '0947725274', 1),
(23, 18, '6 ซอยแจ้งสนิท 7 ถนนแจ้งสนิท', 'ในเมือง', 'เมือง', 'อุบลราชธานี', '34000', '0884814097', 1),
(24, 19, '50 หมู่ที่ 14 บ้านดอนหนองบัว', 'แสนสุข', 'วารินชำราบ', 'อุบลราชธานี', '34190', '0947725274', 1),
(25, 20, 'มหาวิทยาลัยขอนแก่น 123 หมู่ 16 ถ.มิตรภาพ', 'ในเมือง', 'เมือง', 'ขอนแก่น', '40002', '043009700', 1),
(26, 21, '555/1 bannongsung', 'donsak', 'don', 'chaiyaphum', '55555', '0616489100', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`cart_id`),
  ADD UNIQUE KEY `user_product_unique` (`user_id`,`product_id`),
  ADD KEY `product_id` (`product_id`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`category_id`),
  ADD UNIQUE KEY `category_name` (`category_name`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `order_items`
--
ALTER TABLE `order_items`
  ADD PRIMARY KEY (`item_id`),
  ADD KEY `order_id` (`order_id`),
  ADD KEY `product_id` (`product_id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_id`),
  ADD KEY `category_id` (`category_id`);

--
-- Indexes for table `promotions`
--
ALTER TABLE `promotions`
  ADD PRIMARY KEY (`promotion_id`),
  ADD UNIQUE KEY `code` (`code`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `user_addresses`
--
ALTER TABLE `user_addresses`
  ADD PRIMARY KEY (`address_id`),
  ADD KEY `user_id` (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cart`
--
ALTER TABLE `cart`
  MODIFY `cart_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=153;

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `order_items`
--
ALTER TABLE `order_items`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `promotions`
--
ALTER TABLE `promotions`
  MODIFY `promotion_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `user_addresses`
--
ALTER TABLE `user_addresses`
  MODIFY `address_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cart`
--
ALTER TABLE `cart`
  ADD CONSTRAINT `cart_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`),
  ADD CONSTRAINT `cart_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`);

--
-- Constraints for table `order_items`
--
ALTER TABLE `order_items`
  ADD CONSTRAINT `order_items_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`),
  ADD CONSTRAINT `order_items_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`);

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `categories` (`category_id`);

--
-- Constraints for table `user_addresses`
--
ALTER TABLE `user_addresses`
  ADD CONSTRAINT `user_addresses_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
