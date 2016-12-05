use mwd
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Berryman, Tasian>
-- Create date: <12/02/2016>
-- Description:	<MyFirstWebApplication>
-- =============================================
CREATE PROCEDURE spClassScheduleDisplay 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT SectionName.SectionName,ClassSchedule.CreditHrs,
	ClassSchedule.CourseName, ClassSchedule.TotalSeats,
	Room.Room,ClassSchedule.Days,
	ClassSchedule.StartTime,ClassSchedule.EndTime,Teacher.FName + ' ' + Teacher.LName AS TeachFullName,
	Location.Location
	FROM ClassSchedule
	INNER JOIN Location ON ClassSchedule.LocationID=Location.ID
	INNER JOIN Instructor ON ClassSchedule.TeacherID=Teacher.ID
	INNER JOIN Room ON ClassSchedule.RoomNumberID=Room.ID
	INNER JOIN SectionName ON ClassSchedule.SectionNameId=SectionName.ID
END
GO
