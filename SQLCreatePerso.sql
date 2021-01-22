USE MyErpDB;
DROP TABLE IF EXISTS T_Person 
GO
CREATE TABLE T_Person (
  PerId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  PerDNI nvarchar(10) ,
  PerBird datetime,
  PerBiCity nvarchar(100),
  PerBiCtry nvarchar(4),
  PerName nvarchar(100),
  PerName1 nvarchar(100),
  PerAddr nvarchar(255),
  PerAddr1 nvarchar(255),
  PerAddCtry nvarchar(4),
  PerContDate datetime,
  PerEntDate datetime,
  PerExiDate datetime 
);
GO
DROP TABLE IF EXISTS T_P_Pay 
GO
CREATE TABLE T_P_Pay (
  PayId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  PayPerId int,
  PayStDate datetime, 
  PayType nvarchar(10) ,
  PayRet nvarchar(10),
  PayAccount NVARCHAR (25)
);
GO
DROP TABLE IF EXISTS T_P_Train 
GO
CREATE TABLE T_P_Train (
  TrainId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  TrainPerId int,
  TrainDate datetime, 
  TrainArea nvarchar(10) ,
  TrainCourse nvarchar(10),
  TrainCalif FLOAT,
  TrainObser nvarchar(1250)
);
DROP TABLE IF EXISTS T_P_Career
GO
CREATE TABLE T_P_Career (
  CareId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  CarePerId int,
  CareDate datetime, 
  CarePosit nvarchar(10) ,
  CareObser nvarchar(1250)
);
GO
DROP TABLE IF EXISTS T_P_Review
GO
CREATE TABLE T_P_Review (
  RevId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  RevPerId int,
  RevDate datetime, 
  RevObj nvarchar(1250) ,
  RevObRat FLOAT
);
GO
DROP TABLE IF EXISTS T_P_Contract
GO
CREATE TABLE T_P_Contract (
  ConId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  ConPerId int,
  ConRevDate datetime, 
  ConObs nvarchar(1250)
);
GO
DROP TABLE IF EXISTS T_P_Curric
GO
CREATE TABLE T_P_Curric (
  CurrId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  CurrPerId int,
  CurrRevDate datetime, 
  CurrArea nvarchar(10),
  CurrAreaDesc NVARCHAR(255),
  CurrAreaLevel FLOAT,
  CurrObs nvarchar(1250)
);
GO
DROP TABLE IF EXISTS T_P_Presen
GO
CREATE TABLE T_P_Presen (
  PresId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  PresPerId int,
  PresLocal nvarchar(10),
  PresDateEvent datetime
);
GO