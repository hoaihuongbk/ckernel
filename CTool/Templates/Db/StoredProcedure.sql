IF EXISTS ( SELECT  *
            FROM    sys.objects
            WHERE   object_id = OBJECT_ID(N'GetPaginationData')
                    AND type IN ( N'P', N'PC' ) ) 
DROP PROCEDURE [dbo].[GetPaginationData]
GO

IF EXISTS ( SELECT  *
            FROM    sys.views 
            WHERE   name = N'gcTempData')
DROP VIEW [dbo].[gcTempData]
GO

CREATE VIEW [dbo].[gcTempData]
AS 
(SELECT ROW_NUMBER() OVER(ORDER BY create_date asc) AS ROWNUM, name FROM (SELECT TOP 100 PERCENT * FROM sys.tables) a);
GO

IF object_id('sys.sp_addextendedproperty') IS NOT NULL
EXEC sys.sp_addextendedproperty @name = N'CKernel_Build_In_View', @value = 1, @level0type = N'SCHEMA', @level0name = 'dbo', @level1type = N'VIEW',  @level1name = 'gcTempData';
GO

CREATE PROCEDURE [dbo].[GetPaginationData]
	@table nvarchar(1024),
	@column nvarchar(1024),
	@sort	nvarchar(1024),
	@filter nvarchar(max),
	@index int,
	@numOfRow int,
	@total int output 
AS
BEGIN
	declare @sql nvarchar(max)
	begin transaction
	select @sql = 'ALTER VIEW [dbo].[gcTempData] AS select '+ @column + ', ROW_NUMBER() OVER ('+ @sort +') as ROWNUM' 
            	+ ' from  (select top 100 percent  ' + @column + ' from ' + @table + ' ' + @filter + ' ) a'
	print @sql
	exec (@sql)
	
	set @total = (SELECT MAX(ROWNUM) from [dbo].[gcTempData])
	SELECT * from [dbo].[gcTempData]
		 WHERE ROWNUM between @index + 1 and @index + @numOfRow
	commit transaction 
END
GO

IF object_id('sys.sp_addextendedproperty') IS NOT NULL
EXEC sys.sp_addextendedproperty @name = N'CKernel_Build_In_Procedure', @value = 1, @level0type = N'SCHEMA', @level0name = 'dbo', @level1type = N'PROCEDURE',  @level1name = 'GetPaginationData';
