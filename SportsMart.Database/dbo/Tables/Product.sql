CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [Name] NVARCHAR(255) NULL, 
    [Price] INT NULL, 
    [CategoryId] INT NOT NULL, 
    CONSTRAINT [FK_Product_ToTable] FOREIGN KEY ([CategoryId]) REFERENCES [ProductCategory]([Id])
)
