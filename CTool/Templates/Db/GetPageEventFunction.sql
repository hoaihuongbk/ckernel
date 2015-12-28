-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPageEventFunction]
	@T1 int,
	@total int output
AS
BEGIN
	declare @sql nvarchar(max)
	begin transaction
	
	select @sql = 'ALTER VIEW [dbo].[gcTempData] AS WITH ret AS(
    	SELECT	TemplateId1, TemplateId2
    	FROM	dbo.gc_Template_Slot_View
    	WHERE	TemplateId1 = ' + CAST(@T1 as nvarchar(32)) + 
        ' UNION ALL
    	SELECT	t.TemplateId1, t.TemplateId2
    	FROM	dbo.gc_Template_Slot_View t INNER JOIN
    			ret r ON t.TemplateId1 = r.TemplateId2
	)
	SELECT e.Id as EventId, e.Type as EventType, pt.TemplateId, t.Name as TemplateName, e.FunctionId, f.Name as FunctionName, f.Description as FunctionBody, fi.Inputs, fo.Outputs FROM
	(SELECT TemplateId1 as TemplateId from ret union select TemplateId2 from ret) pt
	JOIN dbo.gc_Template_Event_View e ON pt.TemplateId = e.TemplateId AND e.IsActive = 1
	JOIN dbo.gc_Function_View f ON f.Id = e.FunctionId 
	JOIN dbo.gc_Template_View t ON t.Id = e.TemplateId
	LEFT JOIN dbo.gc_Function_Input_View00 fi ON fi.FunctionId = f.Id 
	LEFT JOIN dbo.gc_Function_Output_View00 fo ON fo.FunctionId = f.Id';

	print @sql
	exec (@sql)

	set @total = (SELECT COUNT(*) from gcTempData)
	SELECT * from gcTempData
	commit transaction
END
GO
