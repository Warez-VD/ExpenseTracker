CREATE TABLE [dbo].[FinanceOperations]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Type] INT NOT NULL, 
    [Sum] MONEY NOT NULL, 
    [Currency] INT NOT NULL, 
    [Description] NVARCHAR(255) NOT NULL, 
    [CreatedOn] DATETIME2 NOT NULL, 
    [CreatedBy] UNIQUEIDENTIFIER NOT NULL, 
    [ModifiedOn] DATETIME2 NULL, 
    [ModifiedBy] UNIQUEIDENTIFIER NULL, 
    [WalletId] UNIQUEIDENTIFIER NOT NULL, 
    [FinanceOperationGroupId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_FinanceOperations_FinanceOperationGroups] FOREIGN KEY ([FinanceOperationGroupId]) REFERENCES [FinanceOperationGroups]([Id]), 
    CONSTRAINT [FK_FinanceOperations_Wallets] FOREIGN KEY ([WalletId]) REFERENCES [Wallets]([Id]) 
)
