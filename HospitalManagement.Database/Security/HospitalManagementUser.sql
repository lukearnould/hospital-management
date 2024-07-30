CREATE LOGIN [HospitalManagementUser] WITH PASSWORD = ''
go

CREATE USER [HospitalManagementUser] FOR LOGIN [HospitalManagementUser];
go

GRANT VIEW ANY COLUMN ENCRYPTION KEY DEFINITION TO PUBLIC;
GO

GRANT VIEW ANY COLUMN MASTER KEY DEFINITION TO PUBLIC;
GO

GRANT CONNECT TO [HospitalManagementUser];
go

ALTER ROLE [db_accessadmin] ADD MEMBER [HospitalManagementUser];
GO

ALTER ROLE [db_datareader] ADD MEMBER [HospitalManagementUser];
go

ALTER ROLE [db_datawriter] ADD MEMBER [HospitalManagementUser];
go
