# Shops
Challenge project for Code Exitos

To run the project:

-Download it and make sure nugget dependencies compile.  
-Make sure starting project is set to Shops.App.  
-If you have a special route for your SQLDatabase you can change the DBContext in the appsettings.json in Shops.App project.  
-Attached a backup for a SQL test database (ChallengeDB) with data in the solution folder.  
-To restore the DB simply open SQL Server Management Studio (install it if you dont have it yet) and select "restore database" on your SQL instance and attach the ChallengeDB.bak file provided here.  
-Now Simply run the project and it should run just fine.  



************************************************************************************
                                    PROJECT TREE
************************************************************************************

```bash
+---Shops
+---Shops.App
|   |   appsettings.Development.json
|   |   appsettings.json
|   |   Program.cs
|   |   Startup.cs
|   |   
|   +---Controllers
|   |       EmployeeController.cs
|   |       HomeController.cs
|   |       
|   +---Models
|   |       ErrorViewModel.cs
|   |                    
|   +---Properties
|   |       launchSettings.json
|   |       
|   +---Views
|   |   |   _ViewImports.cshtml
|   |   |   _ViewStart.cshtml
|   |   |   
|   |   +---Employee
|   |   |       Create.cshtml
|   |   |       Index.cshtml
|   |   |       
|   |   +---Home
|   |   |       Index.cshtml
|   |   |       Privacy.cshtml
|   |   |       
|   |   \---Shared
|   |           Error.cshtml
|   |           _Layout.cshtml
|   |           _ValidationScriptsPartial.cshtml
|   |           
|   \---wwwroot
|       |   favicon.ico
|       |   
|       +---css
|       |       site.css
|       |       
|       +---js
|       |       site.js
|       |       
|       \---lib
|           +---bootstrap
|           |   |   LICENSE
|           |   |   
|           |   \---dist
|           |       +---css
|           |       |       bootstrap-grid.css
|           |       |       bootstrap-grid.css.map
|           |       |       bootstrap-grid.min.css
|           |       |       bootstrap-grid.min.css.map
|           |       |       bootstrap-reboot.css
|           |       |       bootstrap-reboot.css.map
|           |       |       bootstrap-reboot.min.css
|           |       |       bootstrap-reboot.min.css.map
|           |       |       bootstrap.css
|           |       |       bootstrap.css.map
|           |       |       bootstrap.min.css
|           |       |       bootstrap.min.css.map
|           |       |       
|           |       \---js
|           |               bootstrap.bundle.js
|           |               bootstrap.bundle.js.map
|           |               bootstrap.bundle.min.js
|           |               bootstrap.bundle.min.js.map
|           |               bootstrap.js
|           |               bootstrap.js.map
|           |               bootstrap.min.js
|           |               bootstrap.min.js.map
|           |               
|           +---jquery
|           |   |   LICENSE.txt
|           |   |   
|           |   \---dist
|           |           jquery.js
|           |           jquery.min.js
|           |           jquery.min.map
|           |           
|           +---jquery-validation
|           |   |   LICENSE.md
|           |   |   
|           |   \---dist
|           |           additional-methods.js
|           |           additional-methods.min.js
|           |           jquery.validate.js
|           |           jquery.validate.min.js
|           |           
|           \---jquery-validation-unobtrusive
|                   jquery.validate.unobtrusive.js
|                   jquery.validate.unobtrusive.min.js
|                   LICENSE.txt
|                   
+---Shops.BLL     
|   +---DTO
|   |       EmployeeDTO.cs
|   |       EmployeeShopDTO.cs
|   |       EmployeeTypeDTO.cs
|   |       ShopDTO.cs
|   |       
|   +---MapperService
|   |       AutoMapperService.cs
|   |       IAutoMapperService.cs
|   |       MapperProfile.cs
|   |       ObjectMapper.cs
|   |             
|   +---Services
|           BaseService.cs
|           EmployeeService.cs
|           EmployeeShopService.cs
|           EmployeeTypeService.cs
|           IBaseService.cs
|           IEmployeeService.cs
|           IEmployeeShopService.cs
|           IEmployeeTypeService.cs
|           IShopService.cs
|           ShopService.cs
|           
+---Shops.Data.EF                  
    +---DAL
    |       BaseRepository.cs
    |       EmployeeRepository.cs
    |       EmployeeShopRepository.cs
    |       EmployeeTypeRepository.cs
    |       IBaseRepository.cs
    |       IEmployeeRepository.cs
    |       IEmployeeShopRepository.cs
    |       IEmployeeTypeRepository.cs
    |       IShopRepository.cs
    |       ShopRepository.cs
    |       
    +---Data
    |       ChallengeDBContext.cs
    |       
    +---Model
    |       Employee.cs
    |       EmployeeShop.cs
    |       EmployeeType.cs
    |       Shop.cs
    |           
\                   
```
