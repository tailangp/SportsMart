/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--Insert into ProductCategory(Name) Values('Electronics')
--Insert into Product (Name, Price, CategoryId) Values('Samsung Fridge','40240',1)
--Insert into Product (Name, Price, CategoryId) Values('Samsung TV','40340',1)
--Insert into Product (Name, Price, CategoryId) Values('Samsung AC','25000',1)
--Insert into Product (Name, Price, CategoryId) Values('Samsung Mobile','22000',1)
