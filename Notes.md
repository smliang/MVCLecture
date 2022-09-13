# MVC Notes

## Adding Database

- create class in `Data` folder
- add attributes
- generate a MVC controller with CRUD 
  - `add > new Scaffolded item > MVC controller with Entity`
- spin up
- `add-migration` NameOfMigration
- `update-database` to update the DB
- see DB in DB Explorer
- link two classes in 1-inf relationship: put class reference inside other reference definition
- in ApplicationContext, need to add new DBs with `public DbSet<WebApplication3.Data.Grade>? Grade {get; set;}`

```
install-package : Failed to download package 'Microsoft.CodeAnalysis.Features.4.0.0' from 
'https://api.nuget.org/v3-flatcontainer/microsoft.codeanalysis.features/4.0.0/microsoft.codeanalysis.features.4.0.0.nupkg'.
The HTTP request to 'GET https://api.nuget.org/v3-flatcontainer/microsoft.codeanalysis.features/4.0.0/microsoft.codeanalysis.features.4.0.0.nupkg' has timed out 
after 100000ms.
At line:1 char:1
+ install-package Microsoft.VisualStudio.Web.CodeGeneration
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : NotSpecified: (:) [Install-Package], Exception
    + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackageCommand
 
install-package : Failed to download package 'NuGet.Configuration.6.2.1' from 
'https://api.nuget.org/v3-flatcontainer/nuget.configuration/6.2.1/nuget.configuration.6.2.1.nupkg'.
The HTTP request to 'GET https://api.nuget.org/v3-flatcontainer/nuget.configuration/6.2.1/nuget.configuration.6.2.1.nupkg' has timed out after 100000ms.
At line:1 char:1
+ install-package Microsoft.VisualStudio.Web.CodeGeneration
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : NotSpecified: (:) [Install-Package], Exception
    + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackageCommand
 
install-package : Failed to download package 'Newtonsoft.Json.13.0.1' from 
'https://api.nuget.org/v3-flatcontainer/newtonsoft.json/13.0.1/newtonsoft.json.13.0.1.nupkg'.
The HTTP request to 'GET https://api.nuget.org/v3-flatcontainer/newtonsoft.json/13.0.1/newtonsoft.json.13.0.1.nupkg' has timed out after 100000ms.
At line:1 char:1
+ install-package Microsoft.VisualStudio.Web.CodeGeneration
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : NotSpecified: (:) [Install-Package], Exception
    + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackageCommand
 
install-package : Failed to download package 'Microsoft.CodeAnalysis.CSharp.4.0.0' from 
'https://api.nuget.org/v3-flatcontainer/microsoft.codeanalysis.csharp/4.0.0/microsoft.codeanalysis.csharp.4.0.0.nupkg'.
Cannot access a disposed object.
Object name: 'SslStream'.
At line:1 char:1
+ install-package Microsoft.VisualStudio.Web.CodeGeneration
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : NotSpecified: (:) [Install-Package], Exception
    + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackageCommand
 
install-package : Package restore failed. Rolling back package changes for 'MVCLecture'.
At line:1 char:1
+ install-package Microsoft.VisualStudio.Web.CodeGeneration
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : NotSpecified: (:) [Install-Package], Exception
    + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackageCommand
 
Time Elapsed: 00:13:38.1846420

```