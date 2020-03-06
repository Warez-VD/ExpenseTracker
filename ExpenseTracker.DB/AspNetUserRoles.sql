CREATE TABLE [dbo].[AspNetUserRoles]
(
	[UserId] NVARCHAR(450) NOT NULL , 
    [RoleId] NVARCHAR(450) NOT NULL, 
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]), 
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles]([Id]), 
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers]([Id])
)
