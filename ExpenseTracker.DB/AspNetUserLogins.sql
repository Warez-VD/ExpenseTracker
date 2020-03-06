CREATE TABLE [dbo].[AspNetUserLogins]
(
	[LoginProvider] NVARCHAR(128) NOT NULL , 
    [ProviderKey] NVARCHAR(128) NOT NULL, 
    [ProviderDisplayName] NVARCHAR(MAX) NULL, 
    [UserId] NVARCHAR(450) NOT NULL, 
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]), 
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers]([Id]) 
)
