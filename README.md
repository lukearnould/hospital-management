# Hospital Management
 Interview challenge project to build CRUD app for hospitals.

 ## Initialization
 1. Ensure the server for the database to be used has SQL Server logins enabled.
 1. Change the connection string in `HospitalManagement.Mvc` > `appsettings.json` to point to a database of your choice.
     * If the database is not of type Microsoft SQL Server, you will want to change the extension method in `HospitalManagement.Config.HospitalContext` from `UseSqlServer()` to your database engine of choice.
 2. At the root of the `Mvc` project, run the below command in your command prompt:

```cmd
dotnet user-secrets set "Database__Password" "<your password goes here>"
```

 4. Update the password set in `HospitalManagement.Database` > `Security` > `HospitalManagementUser.sql` to match the password you entered above.
 5. Publish the `Database` project to your database.
 6. It is recommended to now delete the aforementioned `HospitalManagementUser.sql` file to avoid committing your database user's password into source control.
 7. Run the below command at the root of the `Mvc` project:

```cmd
npm install
``` 

### Optional
1. Execute the `SampleData.sql` script in the `Database` project to insert some sample data into the application's database.
