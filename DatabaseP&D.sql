USE [P&D]
GO
/****** Object:  Table [dbo].[doctor]    Script Date: 4/26/2017 2:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[doctor](
	[DR_ID] [int] IDENTITY(1,1) NOT NULL,
	[DR_Name] [varchar](50) NULL,
	[DR_Adress] [varchar](50) NULL,
	[DR_Age] [int] NULL,
	[DR_sex] [varchar](50) NULL,
	[DR_specialist] [varchar](50) NULL,
	[DR_Type] [varchar](50) NULL,
 CONSTRAINT [PK_doctor] PRIMARY KEY CLUSTERED 
(
	[DR_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[patient]    Script Date: 4/26/2017 2:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[patient](
	[P_ID] [int] IDENTITY(1,1) NOT NULL,
	[P_Name] [varchar](50) NULL,
	[P_Address] [varchar](50) NULL,
	[DiseaseDescription] [varchar](max) NULL,
	[age] [nchar](10) NULL,
	[sex] [varchar](50) NULL,
	[D_ID] [int] NULL,
	[roomNumber] [int] NULL,
	[P_type] [varchar](50) NULL,
	[p_date] [date] NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[patient]  WITH CHECK ADD  CONSTRAINT [FK_patient_doctor] FOREIGN KEY([D_ID])
REFERENCES [dbo].[doctor] ([DR_ID])
GO
ALTER TABLE [dbo].[patient] CHECK CONSTRAINT [FK_patient_doctor]
GO
/****** Object:  StoredProcedure [dbo].[deleteD]    Script Date: 4/26/2017 2:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[deleteD]
@DR_ID int,
@DR_ID2 int
AS 
BEGIN
SET NOCOUNT ON
UPDATE patient SET D_ID=@DR_ID2 where D_ID=@DR_ID
delete from doctor where DR_ID= @DR_ID
end
GO
/****** Object:  StoredProcedure [dbo].[deletee]    Script Date: 4/26/2017 2:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletee]
@P_ID int

AS 
BEGIN
SET NOCOUNT ON
delete from patient where P_ID=@P_ID 
end

GO
/****** Object:  StoredProcedure [dbo].[savee]    Script Date: 4/26/2017 2:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[savee]
@p_Name varchar(50),
	  @P_Address varchar(50),
	  @DiseaseDescription varchar(50),
	  @age int,
	  @sex varchar(50),
	  @D_ID int,
	  @roomNumber varchar(50),
	  @P_type varchar(50),
	  @p_date date
AS 
BEGIN 
	SET NOCOUNT ON 
	INSERT INTO patient(P_Name,P_Address,DiseaseDescription,age,sex,D_ID,roomNumber,P_type,p_date) values (@P_Name,@P_Address,@DiseaseDescription,@age,@sex,@D_ID,@roomNumber,@P_type,@p_date)
	end
GO
/****** Object:  StoredProcedure [dbo].[saveeD]    Script Date: 4/26/2017 2:13:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[saveeD]
@DR_Name varchar(50),
	  @DR_Adress varchar(50), 
	  @DR_Age int,
	  @DR_sex varchar(50),
	  @DR_specialist varchar(50),
	  @DR_Type varchar(50)
AS 
BEGIN 
	SET NOCOUNT ON 
	INSERT INTO doctor(DR_Name,DR_Adress,DR_Age,DR_sex,DR_specialist,DR_Type) values (@DR_Name ,@DR_Adress ,@DR_Age,@DR_sex ,@DR_specialist ,@DR_Type )
	end
GO
/****** Object:  StoredProcedure [dbo].[saveN]    Script Date: 4/26/2017 2:13:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[saveN]
 @p_Name varchar(50),
	  @P_Address varchar(50),
	  @DiseaseDescription varchar(50),
	  @age int,
	  @sex varchar(50),
	  @D_ID int,
	  @P_type varchar(50),
	  @p_date date
AS 
BEGIN 
	SET NOCOUNT ON 
	INSERT INTO patient(P_Name,P_Address,DiseaseDescription,age,sex,D_ID,P_type,p_date) values (@P_Name,@P_Address,@DiseaseDescription,@age,@sex,@D_ID,@P_type,@p_date)
	end
GO
/****** Object:  StoredProcedure [dbo].[updateD1]    Script Date: 4/26/2017 2:13:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updateD1]
	 @DR_Type varchar(50),
	 @DR_specialist varchar(50),
	 @DR_ID int
	  
AS 
BEGIN 
	SET NOCOUNT ON 
	UPDATE doctor SET DR_Type=@DR_Type,DR_specialist=@DR_specialist where DR_ID=@DR_ID
	end

GO
/****** Object:  StoredProcedure [dbo].[updateP]    Script Date: 4/26/2017 2:13:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[updateP]
	 
	  @DiseaseDescription varchar(50),
	  @D_ID int,
	  @roomNumber int,
	  @P_type varchar(50),
	  @P_ID int
AS 
BEGIN 
	SET NOCOUNT ON 
	UPDATE patient SET DiseaseDescription=@DiseaseDescription,D_ID=@D_ID,roomNumber=@roomNumber,P_type=@P_type where P_ID=@P_ID;
	end

GO
