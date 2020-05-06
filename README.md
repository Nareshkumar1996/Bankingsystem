# Bankingsystem

1. Clone the project.
2. DB setup
	2.1 Change the connection string in appsettings.json. Give your SQL Server instance name.
    	2.2 Then apply migration and update database.
		* Add-Migration migrationname
		* Update-Database
3. Email sender configuration
		- Give your username and password in appsettings.json