-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 12, 2022 at 05:52 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payroll`
--

-- --------------------------------------------------------

--
-- Table structure for table `active`
--

CREATE TABLE `active` (
  `ID` int(11) NOT NULL,
  `EID` int(11) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `Status` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `daysalary`
--

CREATE TABLE `daysalary` (
  `ID` int(11) NOT NULL,
  `EID` int(11) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `Date` date NOT NULL,
  `Salary` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `deductions`
--

CREATE TABLE `deductions` (
  `ID` int(11) NOT NULL,
  `SSS%` double NOT NULL,
  `PhilHealth%` double NOT NULL,
  `Pag-IBIG` double NOT NULL,
  `Tax%` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `deductions`
--

INSERT INTO `deductions` (`ID`, `SSS%`, `PhilHealth%`, `Pag-IBIG`, `Tax%`) VALUES
(1, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `employee_profile`
--

CREATE TABLE `employee_profile` (
  `ID` int(4) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `Age` int(3) NOT NULL,
  `Gender` varchar(6) NOT NULL,
  `Position` varchar(20) NOT NULL,
  `Salary` double NOT NULL,
  `Username` varchar(40) NOT NULL,
  `Password` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `logs`
--

CREATE TABLE `logs` (
  `ID` int(11) NOT NULL,
  `EID` int(11) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `Date` date NOT NULL,
  `Time` time NOT NULL,
  `Status` varchar(10) NOT NULL,
  `timeStatus` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `netsalary`
--

CREATE TABLE `netsalary` (
  `ID` int(11) NOT NULL,
  `EID` int(11) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `Year` int(11) NOT NULL,
  `Month` varchar(40) NOT NULL,
  `Date` int(11) NOT NULL,
  `Salary` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `salary`
--

CREATE TABLE `salary` (
  `ID` int(11) NOT NULL,
  `EID` int(11) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `Year` int(11) NOT NULL,
  `Date` varchar(40) NOT NULL,
  `Total_Hours` double NOT NULL,
  `Salary` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `settings`
--

CREATE TABLE `settings` (
  `ID` int(11) NOT NULL,
  `adminPassword` varchar(40) NOT NULL,
  `CallTime` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `settings`
--

INSERT INTO `settings` (`ID`, `adminPassword`, `CallTime`) VALUES
(1, '123', '08:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `total_hours`
--

CREATE TABLE `total_hours` (
  `ID` int(11) NOT NULL,
  `EID` int(11) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `Date` date NOT NULL,
  `Hours_gained` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `total_minutes`
--

CREATE TABLE `total_minutes` (
  `ID` int(11) NOT NULL,
  `EID` int(11) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `Date` date NOT NULL,
  `Minutes` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `active`
--
ALTER TABLE `active`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `daysalary`
--
ALTER TABLE `daysalary`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `deductions`
--
ALTER TABLE `deductions`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `employee_profile`
--
ALTER TABLE `employee_profile`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `netsalary`
--
ALTER TABLE `netsalary`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `salary`
--
ALTER TABLE `salary`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `settings`
--
ALTER TABLE `settings`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `total_hours`
--
ALTER TABLE `total_hours`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `total_minutes`
--
ALTER TABLE `total_minutes`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `active`
--
ALTER TABLE `active`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=137;

--
-- AUTO_INCREMENT for table `daysalary`
--
ALTER TABLE `daysalary`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=104;

--
-- AUTO_INCREMENT for table `deductions`
--
ALTER TABLE `deductions`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `employee_profile`
--
ALTER TABLE `employee_profile`
  MODIFY `ID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `logs`
--
ALTER TABLE `logs`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=307;

--
-- AUTO_INCREMENT for table `netsalary`
--
ALTER TABLE `netsalary`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;

--
-- AUTO_INCREMENT for table `salary`
--
ALTER TABLE `salary`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `settings`
--
ALTER TABLE `settings`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `total_hours`
--
ALTER TABLE `total_hours`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=113;

--
-- AUTO_INCREMENT for table `total_minutes`
--
ALTER TABLE `total_minutes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=99;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
