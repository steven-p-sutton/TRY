CREATE TABLE [dbo].[Country]
(
   [id] [int] IDENTITY(1,1) NOT NULL,  
   [country] [varchar](100) NULL,  
   [active] [bit] NULL,  
   CONSTRAINT [PK_tb_country] PRIMARY KEY CLUSTERED  
   (  
   [id] ASC  
   )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,    ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY]  
