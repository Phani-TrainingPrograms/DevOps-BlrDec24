# Implementation of the service:
1. Create a new ASP.NET Core Web API project WebApiSqlServerDockerDemo in Visual Studio 2022 using .NET 7.0 and make sure you enable the Docker support while you are creating the project.
![image](https://github.com/Phani-TrainingPrograms/DevOps-BlrDec24/assets/131134278/0bd67527-1398-4178-984a-5fc67e3def41)
2. Open the NuGet package manager and search and install the following packages in your project.
   - Microsoft.EntityFrameworkCore.SqlServer
   - Microsoft.EntityFrameworkCore.Design
   - Microsoft.EntityFrameworkCore.Tools
3. Create a Models folder in the project root folder and create the following Product entity in that folder with the code shared.
4. create a folder called Data in our project and create a new class called OnlineShopDbContext in this folder with the code shared.
5. Define our database connection string and we can save the connection string in the appsettings.json file.
6. Register the SQL Server database provider in Program.cs file using the UseSqlServer method. The UseSqlServer method requires a database connection string and we can read and pass this information using the GetConnectionString method.
7. Implement the controller class.
8. Add Docker compose support in Visual Studio, right-click on the Web API project in the solution explorer and choose and choose Add > Container Orchestrator Support… option from the menu.![image](https://github.com/Phani-TrainingPrograms/DevOps-BlrDec24/assets/131134278/cf89e192-a80f-43ae-a236-a94a7654eff8)
9. Follow the steps to choose Docker Compose and Linux machine
10. Build the Application with the Docker Compose as Start up to allow the containers created in the Docker
11. Run the Application.
12. U can configure the Sql Server from the SSMS 
