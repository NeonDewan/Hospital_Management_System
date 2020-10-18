CREATE TABLE [dbo].[UserTable]
(
	[Id] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [First Name] VARCHAR(50) NOT NULL, 
    [Last Name] VARCHAR(50) NOT NULL, 
    [Username] VARCHAR(50) NOT NULL, 
    [Gender] VARCHAR(50) NOT NULL, 
    [Age] VARCHAR(50) NOT NULL, 
    [Cell-Phone] VARCHAR(50) NOT NULL, 
    [Blood Group] VARCHAR(50) NOT NULL, 
    [Emergency Contact] VARCHAR(50) NOT NULL, 
    [Post] VARCHAR(50) NOT NULL, 
    [Education] VARCHAR(50) NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [Type] INT NOT NULL
)
