# Hospital Management
 Interview challenge project to build CRUD app for hospitals.

 ## Initialization
 1. Ensure the server for the database to be used has SQL Server logins enabled.
 1. Change the connection string in `appsettings.json` to point to a database of your choice.
     * If the database is not of type Microsoft SQL Server, you will want to change the extension method in `HospitalManagement.Config.HospitalContext` from `UseSqlServer()` to your database engine of choice.
 1. At the root of the `HospitalManagement.Web` project, run the below command in your command prompt:

```cmd
dotnet user-secrets set "Database__Password" "<your password goes here>"
```

 4. Update the password set in `HospitalManagement.Database.Security.HospitalManagementUser.sql` to match the password you entered above.
 5. Publish the `HospitalManagement.Database` project to your database.
 6. Run the below command at the root of the `HospitalManagement.Web` project:

```cmd
npm install
``` 
