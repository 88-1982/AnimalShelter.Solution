# DeAunte's Animal Shelter API
## Description 
This application simulates an animal shelter database API. You can use enpoints to call animals where you can query over species to find either a cat or a dog. An example:

GET /api/Animals/?species=dog

This project also utilizes full swagger documentation which you can see at the below.

## Setup/Installation Requirements
1. Clone repository
2. From the project directory folder 'AnimalShelter' use command 'dotnet restore' in your terminal to load boilerplate
3. Next, create an appsettings.json file and copy in this code: { "Logging": { "LogLevel": { "Default": "Warning", "System": "Information", "Microsoft": "Information" } }, "AllowedHosts": "*", "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=animalshelter;uid=root;pwd=epicodus;" } }
4. Then, run the command 'dotnet ef database update' to run the migration. If everything works, you should be able to see the animalshelter schema in your MySql workbench.
5. Next, use command 'dotnet run' in your terminal to run server
6. Copy the local host 5000 server link into Postman or perferred web browser to see seeded example data
## Technologies Used
C#
MySql
API
Entity Framework
.NET
MVC
CSS/HTML
Identity
## License

Copyright (c) 2021 DeAunte Hall
## Contact Information
MIT
http://www.88-1982@github.com
godsofolympus88@gmail.com	


