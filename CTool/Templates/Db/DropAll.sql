-- drop all user defined tables
EXEC sp_MSforeachtable @command1 = "DROP TABLE ?" 

GO

 -- drop all user defined stored procedures
Declare @procName varchar(500) 
Declare cur Cursor For Select [name] From sys.objects where type = 'p' 
Open cur 
Fetch Next From cur Into @procName 
While @@fetch_status = 0 
Begin 
 Exec('drop procedure ' + @procName) 
 Fetch Next From cur Into @procName 
End
Close cur 
Deallocate cur 

GO

 -- drop all user defined views
Declare @viewName varchar(500) 
Declare cur Cursor For Select [name] From sys.objects where type = 'v' 
Open cur 
Fetch Next From cur Into @viewName 
While @@fetch_status = 0 
Begin 
 Exec('drop view ' + @viewName) 
 Fetch Next From cur Into @viewName 
End
Close cur 
Deallocate cur

GO

 -- drop all user defined triggers
Declare @trgName varchar(500) 
Declare cur Cursor For Select [name] From sys.objects where type = 'tr' 
Open cur 
Fetch Next From cur Into @trgName 
While @@fetch_status = 0 
Begin 
 Exec('drop trigger ' + @trgName) 
 Fetch Next From cur Into @trgName 
End
Close cur 
Deallocate cur 