IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Customers] (
    [CustomerId] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [Email] varchar(80) NOT NULL,
    [CreaditCardNumber] nvarchar(max) NOT NULL,
    [Sales] int NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerId])
);
GO

CREATE TABLE [Products] (
    [ProductId] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [Quantity] float NULL,
    [Price] float NOT NULL,
    [Sales] int NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([ProductId])
);
GO

CREATE TABLE [Sales] (
    [SaleId] int NOT NULL IDENTITY,
    [Date] datetime2 NOT NULL,
    [Product] int NOT NULL,
    [Store] int NOT NULL,
    [Customer] int NOT NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY ([SaleId])
);
GO

CREATE TABLE [Stores] (
    [StoreId] int NOT NULL IDENTITY,
    [Name] nvarchar(80) NOT NULL,
    [Sales] int NOT NULL,
    CONSTRAINT [PK_Stores] PRIMARY KEY ([StoreId])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250121085359_InitialCreate', N'8.0.12');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Products] ADD [Description] nvarchar(max) NOT NULL DEFAULT N'';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250121085703_ProductsAddColumnDescription', N'8.0.12');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sales]') AND [c].[name] = N'Date');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Sales] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Sales] DROP COLUMN [Date];
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250121085846_SalesDeleteDateDefault', N'8.0.12');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Sales] ADD [Date] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250121085917_SalesAddDateDefault', N'8.0.12');
GO

COMMIT;
GO

