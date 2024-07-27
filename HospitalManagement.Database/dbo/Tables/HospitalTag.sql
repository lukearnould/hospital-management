CREATE TABLE [dbo].[HospitalTag]
(
	[HospitalTagId] int not null Identity(1,1) primary key,
	[HospitalId] int not null foreign key references Hospital(HospitalId),
	[TagId] int not null foreign key references Tag(TagId)
)
