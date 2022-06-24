# FormCustom
To run project, you need to complete the following steps:/n
Step 1: Restore FormCustomDB
Step 2: Access Tools --> NuGet Package Manager --> Package Manager Console
Step 3: Paste this to console:
      Scaffold-DbContext "Server=ServerName;Database=DatabaseName;User ID=YourID;Password=YourPassword;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/DL -Context AppDBContext -Force
Step 4: Enjoy!
