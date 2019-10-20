﻿
#https://docs.microsoft.com/en-us/sql/linux/tutorial-restore-backup-in-sql-server-container?view=sql-server-ver15

FILE LIST ONLY
```powershell
docker exec -it baseliner_db_1 /opt/mssql-tools/bin/sqlcmd -S localhost `
   -U SA -P "P@ssw0rd!" `
   -Q "RESTORE FILELISTONLY FROM DISK = '/var/opt/mssql/backup/wwi.bak'"

docker 
```

Publish as self-contained application (win-x64)
```console
dotnet publish -c release -r win-x64 /p:publishsinglefile=true /p:publishtrimmed=true
```