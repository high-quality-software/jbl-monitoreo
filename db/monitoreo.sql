-- monitoreo.devices definition

CREATE TABLE `devices` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(15) NOT NULL,
  `Alias` varchar(60) DEFAULT NULL,
  `Community` varchar(30) DEFAULT NULL,
  `Disabled` tinyint(1) DEFAULT NULL,
  `Deleted` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Name` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


-- monitoreo.samples definition

CREATE TABLE `samples` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Device_ID` int(11) NOT NULL,
  `Timestamp` datetime NOT NULL,
  `OID` varchar(30) NOT NULL,
  `OName` varchar(60) NOT NULL,
  `Unit` varchar(15) NOT NULL,
  `Value` varchar(15) NOT NULL,
  `Status` tinyint(4) NOT NULL DEFAULT 0,
  `Deleted` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;