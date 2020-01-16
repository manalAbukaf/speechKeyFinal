CREATE TABLE [dbo].[reports] (
    [deaf_id]   NVARCHAR (50) NOT NULL,
    [report_id] NVARCHAR(50)           IDENTITY (1, 1) NOT NULL,
    [report]    DATETIME      NOT NULL
);

