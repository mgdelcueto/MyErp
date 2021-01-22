USE MyErpDB;
DROP TABLE IF EXISTS T_Facility
GO
CREATE TABLE T_Facility (
  FaId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  FaDescr nvarchar (125),
  FaCrDate datetime,
  FaCode nvarchar(225),
  FaAcct nvarchar(225),
  FaType nvarchar(25),
  FaSupm2 float,
  FaCostMin float,
  FaStatus nvarchar(25),
  FaStDate DATETIME
);
GO
DROP TABLE IF EXISTS T_WorkCenter 
GO
CREATE TABLE T_WorkCenter (
  WCdId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  WCFaId int NULL,
  WCCrDate datetime,
  WCStatus nvarchar(125), 
  WCStDate datetime ,
	WCCode nvarchar(125) ,
	WCDescr nvarchar(225),
  WCType nvarchar(25),
  WCSupm2 float,
  WCAcct nvarchar (225),
  WCCostMin float 
);
DROP TABLE IF EXISTS T_WCComponent
GO
CREATE TABLE T_WCComponent (
  WCoId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  WCoWCId int NULL,
  WCoCrDate datetime ,
  WCoStDate datetime,
  WCoStatus  nvarchar(125),
  WCoDescr nvarchar(225),
  WCoDim1 float ,
  WCoDim2 float ,
  WCoDim3 float ,
  WCoWeight float,
  WCoConsumW float,
  WCoCostMin float,
  WCoAcct nvarchar(255)
);
GO
