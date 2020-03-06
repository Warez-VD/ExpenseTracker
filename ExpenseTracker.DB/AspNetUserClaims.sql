CREATE TABLE [dbo].[AspNetUserClaims]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserId] NVARCHAR(450) NOT NULL, 
    [ClaimType] NVARCHAR(MAX) NULL, 
    [ClaimValue] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers]([Id])
)
