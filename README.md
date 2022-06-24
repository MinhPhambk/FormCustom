# FormCustom
To run project, you need to complete the following steps:
<br>
<strong>Step 1:</strong> Restore FormCustomDB (if your has installed SQL Server)
<br>
<strong>Step 2:</strong> Access Tools --> NuGet Package Manager --> Package Manager Console
<br>
<strong>Step 3:</strong> Paste this to console:
<br>
      Scaffold-DbContext "Server=ServerName;Database=DatabaseName;User ID=YourID;Password=YourPassword;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/DL -Context AppDBContext -Force
<br>
<strong>Step 4:</strong> Enjoy!
