CREATE TABLE [dbo].[Socials]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY, 
    [Facebook] VARCHAR(50) NULL, 
    [Google] VARCHAR(50) NULL, 
    [Twitter] VARCHAR(50) NULL, 
    [LinkedIn] VARCHAR(50) NULL, 
    CONSTRAINT [FK_Socials_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([EmployeeId])
)
