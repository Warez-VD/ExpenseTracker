CREATE TABLE [dbo].[AspNetRoleClaims]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [RoleId] NVARCHAR(450) NOT NULL, 
    [ClaimType] NVARCHAR(MAX) NULL, 
    [ClaimValue] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles]([Id])
)
