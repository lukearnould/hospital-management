# Hospital Management
 Interview challenge project to build CRUD app for hospitals.

 ## Initialization
 1. Change the connection string in `appsettings.json` to point to a database of your choice.
     * If the database is not of type Microsoft SQL Server, you will want to change the extension method in `HospitalManagement.Config.HospitalContext` from `UseSqlServer()` to your database engine of choice.
2. Publish the `HospitalManagement.Database` project to your database.
3. Run `npm install` at the root of the `HospitalManagement.Mvc` project. 
