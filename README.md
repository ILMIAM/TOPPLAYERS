# TOPPLAYERS

 
TopPlayer is a .net Core Web API application, main features of this apps

  - Create an endpoint returning all the players 
  - Create an endpoint to return a single player matching id <id>.
  - Add a DELETE to enable deletion of a player

# New Features!

Adding a script to generate the API documentation :
The integration of Swagger with its application consists of the installation of the NuGet Swashbuckle.AspNetCore package. This package adds three components to your application:
> Swashbuckle.AspNetCore.Swagger
> Swashbuckle.AspNetCore.SwaggerUI
> Swashbuckle.AspNetCore

you must use the Visual Studio Code integrated terminal or the command prompt (in the folder containing the .csproj file) and run the following command:
> dotnet add package Swashbuckle.AspNetCore


If you run your application, and enter the link http: // myapplication / swagger / in your browser, you will get the API documentation

#  Run and test
To run this application, execute TopPlayers Solution. the default path is Get/Players, you can navigate to other features please refer to the API documentation for more informations about paths.

To test features:

> Using TestUnitPlayersProject

> Using Tthe swagger (API documentation)

> Postman


