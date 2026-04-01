Create database LearnADO ; 

USE [LearnADO]
GO

/****** Object:  Table [dbo].[tblEmployee]    Script Date: 4/1/2026 9:46:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblEmployee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[City] [varchar](20) NOT NULL,
	[Department] [varchar](20) NOT NULL,
	[Gender] [varchar](6) NOT NULL
) ON [PRIMARY]
GO

---------------------------

USE [LearnADO]
GO

/****** Object:  StoredProcedure [dbo].[spAddEmployee]    Script Date: 4/1/2026 9:47:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[spAddEmployee]     
(    
    @Name VARCHAR(20),     
    @City VARCHAR(20),    
    @Department VARCHAR(20),    
    @Gender VARCHAR(6)    
)    
as     
Begin     
    Insert into tblEmployee (Name,City,Department, Gender)     
    Values (@Name,@City,@Department, @Gender)     
End
GO
-------------------------------

USE [LearnADO]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[spDeleteEmployee]     
(      
   @EmpId int      
)      
as       
begin      
   Delete from tblEmployee where EmployeeId=@EmpId      
End
GO

----------------------------------

USE [LearnADO]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[spGetAllEmployees]    
as    
Begin    
    select *    
    from tblEmployee 
    order by EmployeeId    
End
GO

----------------------------------

USE [LearnADO]
GO

/****** Object:  StoredProcedure [dbo].[spUpdateEmployee]    Script Date: 4/1/2026 9:48:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Create procedure [dbo].[spUpdateEmployee]      
(      
   @EmpId INTEGER ,    
   @Name VARCHAR(20),     
   @City VARCHAR(20),    
   @Department VARCHAR(20),    
   @Gender VARCHAR(6)    
)      
as      
begin      
   Update tblEmployee       
   set Name=@Name,      
   City=@City,      
   Department=@Department,    
   Gender=@Gender      
   where EmployeeId=@EmpId      
End
GO




