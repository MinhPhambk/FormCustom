# FormCustom
To run project, you need to complete the following steps:
<br>
Step 1: Restore FormCustomDB
<br>
Step 2: Access Tools --> NuGet Package Manager --> Package Manager Console
<br>
Step 3: Paste this to console:
<br>
      Scaffold-DbContext "Server=ServerName;Database=DatabaseName;User ID=YourID;Password=YourPassword;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/DL -Context AppDBContext -Force
<br>
Step 4: Enjoy!
