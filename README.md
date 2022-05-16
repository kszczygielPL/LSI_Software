# LSI_Software

Simple project for job application. 

Database connection string is placed in project settings.

Create table script:

USE [master]
GO

/****** Object:  Table [dbo].[export_history]    Script Date: 16.05.2022 12:17:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[export_history](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[export_date] [datetime] NOT NULL,
	[user_name] [nvarchar](50) NOT NULL,
	[export_local_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_export_history] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SAMPLE DATE TO SELECT:

INSERT INTO master.dbo.export_history (name,export_date,user_name,export_local_name) VALUES
	 (N'test_1','2022-01-02 10:00:00.0',N'User1',N'Local1'),
	 (N'test_2','2022-01-05 11:00:00.0',N'User2',N'Local 2'),
	 (N'test_3','2022-01-07 12:00:00.0',N'User3',N'Local 3'),
	 (N'test_4','2022-02-01 10:00:00.0',N'User4',N'Local 4'),
	 (N'test_5','2022-02-10 00:00:00.0',N'User1',N'Local1'),
	 (N'test_6','2022-02-15 00:00:00.0',N'User2',N'Local1');
   
   
