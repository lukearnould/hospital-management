﻿CREATE TABLE [dbo].[Hospital] (
    [HospitalId]  INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (500) NOT NULL,
    [Color]       VARCHAR (7)   NOT NULL,
    [PhoneNumber] varchar(11) not null,
    [EmailAddress] varchar(100) not null,
    [URL] varchar(100) not null,
    PRIMARY KEY CLUSTERED ([HospitalId] ASC)
);

