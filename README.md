# Project Overview
Public API that allows user to anonymously post how much they paid for their car.
The idea is to build up an accurate database of used car prices so that anyone looking to buy a car can look up past
listings by country, city , dealership, car make and model - this will enable them to see how much the car was origionally
listed for and how much it sold for and generally put the consumer in a better bargaining position

This is non commercial - is mainly for academic purposes although feel free to contribute / suggest improvements.


## Installation Instructions.

Clone the git repository the URL is https://github.com/Ted95153420/CarWebApp.git

Once cloned, set startup.cs as the startup item (right click -> Set as startup Item)

![Set as Startup](/ReadMeMedia/README_SetAsStartUp.JPG "Set as startup")

Next right click the Solution and click 'Manage Nuget Packages for solution'

![Manage Nuget Packages for solution](/ReadMeMedia/ManageNugetPackages.jpg "Manage Nuget Packages")

Now check your Installed Nuget packages as shown in the screenshot below. 
At the time of writing (30th August 2024) the packages installed were <br/>
AutoMapper v13.0.1 <br/>
Microsoft.EntityFrameworkCore.Design v8.0.8 <br/>  
Microsoft.EntityFrameworkCore.SQLServer v8.0.8 <br/>
Microsoft.EntityFrameworkCore.Tools v8.0.8 <br/>

Make sure the packages you have installed are at least at the versions stated above.

commands I have run in the past - 

docker stack deploy -c docker-compose.yml carwebapp
docker push grimsbydocks/custom-sqlserver:latest
docker build -t grimsbydocks/custom-sqlserver:latest -f Dockerfile.sqlserver .
 docker build -t grimsbydocks/custom-sqlserver:v1 .

![Installed Nuget Packages](/ReadMeMedia/InstalledPackages.JPG "Installed Packages")

Now check that you have .NET SDK 8.0.1 (or above) installed. Open a command prompt and run the command <br/>
dotnet sdk check <br/>
as you can see, I have .NET SDK 8.0.1 installed.
![dot NET SDK version installed](/ReadMeMedia/sdkVersion.jpg "Sdk Version")

Now you need a database to connect to. Open the package manager console in Visual Studio. Try Tools -> Nuget PackageManager -> Package Manager Console.
now type the command 'Update-Database'. This SHOULD create you a new car database based on the latest Entity Framework Migration I created. There is NO NEED
TO RUN THE Add-Migration COMMAND SHOWN IN THE SCREENSHOT BELOW, just run Update-Database

![Update database](/ReadMeMedia/UpdateDatabase.JPG "Update database")

That will have created pre-seeded VehicleIntelDb for you. one way of checking this would be to open an instance of SQL Management Studio,
Use for the server name use '(localdb)\MSSQLLocalDb' for Authentication use 'Window authentication' (behind the scenes the connection string uses
Integrated Security =True) After you click connect you should see the VehicleIntelDb. The following tables will be pre populated with
Data : City, Country, Dealer, VehicleMakes and VehicleModels

![Vehicle Intelligence Database](/ReadMeMedia/VehicleIntelDb.jpg "Vehicle Intel database")



## Useage.

As of September 2024, this has not been published yet, but can be run locally.







