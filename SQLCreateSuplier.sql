USE MyErpDB;
DROP TABLE IF EXISTS T_Suplier
GO
CREATE TABLE T_Suplier (
  SupId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  SupRasoc nvarchar (125),
  SupNIF nvarchar(10) ,
  SupCrDate datetime,
  SupCode nvarchar(225),
  SupAcct nvarchar(225),
  SupAdStrt nvarchar(225),
  SupAdAdit nvarchar(225),
  SupAdCity nvarchar(225),
  SupAdCtry nvarchar(4),
  SupCtPhone nvarchar(55),
  SupCtEmailLog nvarchar(125),
  SupCtEmailFin nvarchar(125),
  SupCtWeb nvarchar(225),
  SupCtEDILog nvarchar(100),
  SupCtEDIFin nvarchar(100),
  SupCtBankAcc nvarchar(225),
  SupStatus nvarchar(25),
  SupStDate DATETIME
);
GO
DROP TABLE IF EXISTS T_S_Product 
GO
CREATE TABLE T_S_Product (
  ProdId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  ProdSupId int,
  ProdCrDate datetime,
  ProdStatus nvarchar(125), 
  ProdStDate datetime ,
	[ProdRefer] [nvarchar](125) NULL,
	[ProdDescr] [nvarchar](225) NULL
);
DROP TABLE IF EXISTS T_S_Planning
GO
CREATE TABLE T_S_Planning (
  PlanId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  PlanSupId int,
  PlanProdId int,
  PlanDateFrom datetime ,
  PlanDateTo datetime,
  PlanQty  float,
  PlanFirmSt nvarchar(55)
);
GO
