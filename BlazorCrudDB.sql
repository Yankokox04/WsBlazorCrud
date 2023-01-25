
CREATE DATABASE [BlazorCrud]
 
--USE [BlazorCrud]

CREATE TABLE [dbo].[beer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[brand] [varchar](50) NOT NULL,
 CONSTRAINT [PK_beer_1] PRIMARY KEY CLUSTERED ([id] ASC))
