
declare @ff datetime
declare @ver int
declare @com nvarchar(255)
set @ff = convert (datetime, '2021-03-01',126)
set @ver =1;
set @com = 'Initial'
exec Xs_Explosion_Start @ff,@ver,@com

select ShopWctr,ShopFG,ShopCProdId,ShopDest,ShopDate,ShopQty,ShopTUnit,ShopaTUnit,ShopMinLot,ShopUEmb  from T_C_ScShop
order by ShopWctr,ShopDate desc,ShopCProdId
