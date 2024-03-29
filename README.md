

[![.NET](https://github.com/dotnetappdevni/BookManager/actions/workflows/dotnet.yml/badge.svg)](https://github.com/dotnetappdevni/BookManager/actions/workflows/dotnet.yml)

<h2>EDT Book Manager API</h2>

The Book manager api facliates the adding of books / customers and the 
check out and check in process of books.

You will have to remove the Data Migrations from the 
BookManager.DAL Solution if you are wanting to use ef migrations 
to seed the database

To be able to create the migration ensure you are in the 
root of the directory.

************************************************************************
<h2> DB Server Setup Instructions</h2>

Download and Instal SQL Server 2019 Developer edition or express.

 I am using version 2019 of sql server Version 15.0.2104.1

 Microsoft Donwload Link 2019 Server please virus scan download at own risk.

    https://go.microsoft.com/fwlink/?linkid=866662
***********************************************************************
In Solution Explorer Navigate to BookManager.API Project and find the 
appsettings files in the root of the project.

<h2>appsettings.Development.json configuration setup</h2>

 Find the database connection string which I use SQL Server

 NB You can also replace the one in appsettings.json 

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=DAVIDLEGION\\SQLDEVELOPER2019;
    Initial Catalog=edtbookmanager;User ID=edt;Password=edt12345;
    TrustServerCertificate=True"
 },

```

You Need to replace DAVIDLEGION\\SQLDEVELOPER2019db with your server instance name.
Keep the catalog the same edtbookmanager and create a login in sql managment studio
for the 

<h2>username:edt
password:edt12345</h2>

Important make sure to map the login abovve to the

<h1>**Database name : edtbookmanager**</h1>

And give edt user dbowner permissions.

**Migrations and Database scaffolding insrtuctions**
You can apply the migration from the PackageManager Console
Ensure that the Api Project is set as startup project and 
showing in the dropdown.

```
dotnet ef migrations add FirstMigration --context
ApplicationDBContext --output-dir Data\Migrations 
-p BookManager.DAL -s BookManager.API 
```

For Example :
 Your directory should look like this if you do the pwd command 
 in the package manager console.

 
 Put Image Here

 Once you have create the Logins above and created the migration
 you can apply the migration again please ensure you are in the directory
 as above image.
 
 ```
  dotnet ef database update --context ApplicationDBContext
  -p BookManager.DAL -s BookManager.API
 ```

 One the migration is complete you can log in to sql server using the details 
 created above.

 <h2>Features of Api<h2>

 * Dotnet 8 
 * New dotnet 8 API End Points allows login and jwt token generation

 <h2>Api End Points</h2>

 <h2> Books End Points</h2>
 
    * Muliple end points for adding , removing, updating  and deleting books.
      Check in and Check Out end points for the loaning and returning of a book.
   
   <h2> Customer End Points</h2>
   
   * Customer End points for adding , removing,updating and deletion of customers.
   
   <h2>Authenication End Points</h2>
   *Login end point for generation of jwt token I created an user for the 
   Login for you

   If you remove the json generated and replace with this it will allow you to 
   login in and get a jwt token.

{
  "email": "edt@dotnetappdevni.com",
  "password": "Test12345!@",
  "twoFactorCode": "string",
  "twoFactorRecoveryCode": "string"
}
   One You have logged in the swagger will produce a jwt berrer token.

   Once you have got the token click the authorise  button on the main swagger screen
   to allow you to enter the token

   its very important that when you do you read the instructions in the popup.

   **IE THIS TEXT**

    JWT Authorization header using the Bearer scheme.

    Enter 'Bearer' [space] and then your token in the text input below.

    Example: "Bearer 12345abcdef"

 Upload Image of popup and button here.
   
 Api Documenation is discoverable here

  https://localhost:7066/swagger/index.html

  I setup a tempory inbox for you on my hosting

  web mail is 
  https://mail5018.site4now.net
  username : edt@dotnetappdevni.com
  password : Test12345!@


  This is for the password resets and what not form the identity api.

  You can also setup a local smpt dev instance by using the following

  dotnet tool install -g Rnwood.Smtp4dev

  you can run the tool by runing command in the package manager console

  smtp4dev 