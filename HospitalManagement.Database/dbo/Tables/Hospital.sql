CREATE TABLE [dbo].[Hospital] (
    [HospitalId]  INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (500) NOT NULL,
    [Color]       VARCHAR (6)   NOT NULL,
    PRIMARY KEY CLUSTERED ([HospitalId] ASC)
);

