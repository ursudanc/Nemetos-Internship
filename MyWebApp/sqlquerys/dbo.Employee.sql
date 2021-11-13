CREATE TABLE [dbo].[Employee] (
    [EmployeeId] INT             IDENTITY (1, 1) NOT NULL,
    [Image]      VARBINARY (MAX) NULL,
    [Name]       VARCHAR (50)    NULL,
    [Intro]      VARCHAR (MAX)    NULL,
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);

