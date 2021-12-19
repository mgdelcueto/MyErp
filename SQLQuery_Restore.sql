RESTORE DATABASE MyErpDB FROM DISK = N'/var/opt/mssql/data/MyErpDB_Bck_20210312.bak' 
WITH MOVE 'MyErpDB' TO '/var/opt/mssql/data/MyErpDB.mdf' ,
MOVE 'MyErpDB_log' TO '/var/opt/mssql/data/MyErpDB_log.ldf' ,REPLACE

