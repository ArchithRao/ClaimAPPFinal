IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Members] (
    [MId] int NOT NULL IDENTITY,
    [MName] nvarchar(100) NOT NULL,
    [Username] nvarchar(100) NOT NULL,
    [Password] nvarchar(100) NOT NULL,
    [Address] nvarchar(max) NULL,
    [State] nvarchar(max) NULL,
    [Country] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [Contact] nvarchar(max) NULL,
    [DOB] datetime2 NOT NULL,
    CONSTRAINT [PK_Members] PRIMARY KEY ([MId])
);

GO

CREATE TABLE [Login] (
    [LId] int NOT NULL IDENTITY,
    [Username] nvarchar(100) NOT NULL,
    [Password] nvarchar(100) NOT NULL,
    [MId] int NULL,
    CONSTRAINT [PK_Login] PRIMARY KEY ([LId]),
    CONSTRAINT [FK_Login_Members_MId] FOREIGN KEY ([MId]) REFERENCES [Members] ([MId]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Plans] (
    [PId] int NOT NULL IDENTITY,
    [PName] nvarchar(max) NOT NULL,
    [Amount] float NOT NULL,
    [Start] datetime2 NOT NULL,
    [End] datetime2 NOT NULL,
    [MId] int NULL,
    CONSTRAINT [PK_Plans] PRIMARY KEY ([PId]),
    CONSTRAINT [FK_Plans_Members_MId] FOREIGN KEY ([MId]) REFERENCES [Members] ([MId]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Login_MId] ON [Login] ([MId]);

GO

CREATE INDEX [IX_Plans_MId] ON [Plans] ([MId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221116070944_mig1', N'3.1.30');

GO

