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

CREATE TABLE [Courses] (
    [CourseId] int NOT NULL IDENTITY,
    [Name] nvarchar(80) NOT NULL,
    [Description] nvarchar(max) NULL,
    [StartDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [Price] float NOT NULL,
    CONSTRAINT [PK_Courses] PRIMARY KEY ([CourseId])
);
GO

CREATE TABLE [Students] (
    [StudentId] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [PhoneNumber] varchar(10) NULL,
    [RegisteredOn] datetime2 NOT NULL,
    [BirthDay] datetime2 NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY ([StudentId])
);
GO

CREATE TABLE [Resources] (
    [ResourceId] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [Url] varchar(max) NOT NULL,
    [ResourceType] int NOT NULL,
    [CourseId] int NOT NULL,
    CONSTRAINT [PK_Resources] PRIMARY KEY ([ResourceId]),
    CONSTRAINT [FK_Resources_Courses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Courses] ([CourseId]) ON DELETE CASCADE
);
GO

CREATE TABLE [Homeworks] (
    [HomeworkId] int NOT NULL IDENTITY,
    [ContentType] int NOT NULL,
    [Content] varchar(max) NOT NULL,
    [SubmissionTime] datetime2 NOT NULL,
    [CourseId] int NOT NULL,
    [StudentId] int NOT NULL,
    CONSTRAINT [PK_Homeworks] PRIMARY KEY ([HomeworkId]),
    CONSTRAINT [FK_Homeworks_Courses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Courses] ([CourseId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Homeworks_Students_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Students] ([StudentId]) ON DELETE CASCADE
);
GO

CREATE TABLE [StudentCourses] (
    [CourseId] int NOT NULL,
    [StudentId] int NOT NULL,
    CONSTRAINT [PK_StudentCourses] PRIMARY KEY ([StudentId], [CourseId]),
    CONSTRAINT [FK_StudentCourses_Courses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Courses] ([CourseId]) ON DELETE CASCADE,
    CONSTRAINT [FK_StudentCourses_Students_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Students] ([StudentId]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Homeworks_CourseId] ON [Homeworks] ([CourseId]);
GO

CREATE INDEX [IX_Homeworks_StudentId] ON [Homeworks] ([StudentId]);
GO

CREATE INDEX [IX_Resources_CourseId] ON [Resources] ([CourseId]);
GO

CREATE INDEX [IX_StudentCourses_CourseId] ON [StudentCourses] ([CourseId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250123162343_UpdateStudentInBD', N'8.0.12');
GO

COMMIT;
GO

