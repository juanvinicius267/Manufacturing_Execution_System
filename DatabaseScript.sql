CREATE DATABASE MESProductionKD

CREATE TABLE TB_MAXLOAD(
   MAXLOADID   INT  IDENTITY(1,1)  NOT NULL,
   BatchId VARCHAR (MAX)     NOT NULL,
   ContainerNumber  INT     ,
   Component  VARCHAR (MAX) ,    
   MuCode VARCHAR (MAX),   
   BoxeNumber VARCHAR (MAX),   
   PriorityNumber INT ,   
   PriorityNumber2 INT,   
   SavedHour DATETIME ,     
   PRIMARY KEY (MAXLOADID)
)
GO
 
DROP TABLE TB_MAXLOAD
GO

SELECT * FROM TB_MAXLOAD

INSERT INTO TB_MAXLOAD (BatchId,ContainerNumber,Component,MuCode,BoxeNumber,PriorityNumber,PriorityNumber2,SavedHour)
VALUES ('ZAT0002/20',1,'CABINA 1A','4017','269',1,1,'2020-03-16 00:00:00')
GO
--//--------------------------------------------------------------------------------------------------------------------------------------------------------------------//
CREATE TABLE TB_ROUNDSRULE (
   RoundsId   INT  IDENTITY(1,1)  NOT NULL,
   Component VARCHAR (MAX)     NOT NULL,   
   MuCode  VARCHAR (MAX) NOT NULL,   
   CabRounds INT NOT NULL,
   SkdRounds INT NOT NULL,
   SkidRounds INT NOT NULL,
   EcuRounds INT NOT NULL,
   CabLine BIT ,   
   SkdLine BIT ,   
   SkidLine BIT ,   
   EcuLine BIT,   
   CabDock BIT ,   
   SkdDock BIT ,   
   SkidDock BIT ,   
   EcuDock BIT,   
   SavedHour DATETIME ,     
   PRIMARY KEY (RoundsId)

)
SELECT * FROM ROUNDSRULE

DROP TABLE ROUNDSRULE
GO

INSERT INTO ROUNDSRULE (Component,MuCode,CabRounds,SkdRounds,SkidRounds,EcuRounds,CabLine,SkdLine,SkidLine,EcuLine, CabDock,SkdDock, SkidDock, EcuDock, SavedHour)
VALUES ('CABINA 1','4017',1,0,0,0,1,0,0,0,1,0,0,0,'2020-03-16 00:00:00');
GO

--//--------------------------------------------------------------------------------------------------------------------------------------------------------------------//





CREATE TABLE TB_SCHEDULE_CONTAINER (
   ID   INT   NOT NULL,
   BATCHID VARCHAR (255)     NOT NULL,   
   CONTAINER_NUMBER  VARCHAR (255) NOT NULL,   
   STAR_DATE DATETIME NOT NULL,
   END_DATE DATETIME NULL,   
   LINE VARCHAR(255) NOT NULL,
   DOCK INT NOT NULL ,   
   CREATE_DATE DATETIME NOT NULL,
   EDIT_DATE DATETIME ,  
   USER_CREATE VARCHAR(255),
   USER_EDIT VARCHAR(255),
   CONTAINER_TYPE VARCHAR(255),
   LICENSE_PLATE VARCHAR(255),
   SHIPPING_COMPANY VARCHAR(255),
   PRIMARY KEY (ID)
);
SELECT * FROM TB_SCHEDULE_CONTAINER;

//---------------------------------------------------------------------------------------------------------------------//

CREATE TABLE TB_DOCK (
   ID   INT   NOT NULL,
   DOCK_NUMBER INT      NOT NULL,   
   DOCK_DESCRIPTION  VARCHAR (255) NOT NULL,      
   PRIMARY KEY (ID)
)

CREATE TABLE TB_LINE (
   ID   INT   NOT NULL,
   LINE_NUMBER INT      NOT NULL,   
   LINE_DESCRIPTION  VARCHAR (255) NOT NULL,      
   PRIMARY KEY (ID)
)

