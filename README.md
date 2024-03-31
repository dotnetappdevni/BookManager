

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
If you are building release obviouslly make sure the connection settings match that of your development jason 
including email settings.
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

![connecctionstrings](https://github.com/dotnetappdevni/BookManager/assets/5619229/f06a54cd-6f9b-44aa-9fbb-991148b32f53)


You Need to replace sql5053.site4now.net with your server instance name.
Keep the catalog the same with Initial Catalog and create a login in sql managment studio
for the 

<h2>username:edt</h2>
<h2>password:edt12345</h2>

Important make sure to map the login above to the database name 

<h1>Database name : You can change this to anything you want</h1>

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

![image](https://github.com/dotnetappdevni/BookManager/assets/5619229/62beead7-d57c-427b-9d37-e58811073fad)

**Please ensure that the api project is selected as the default project as shown by the second arrow and make sure that it is set as the **

** startup project **
eg

![image](https://github.com/dotnetappdevni/BookManager/assets/5619229/c46ad2f3-d73b-4a2d-85f9-5b985572b655)


 Once you have create the Logins above and created the migration
 you can apply the migration again please ensure you are in the directory
 as above image.
 
 ```
  dotnet ef database update --context ApplicationDBContext
  -p BookManager.DAL -s BookManager.API
 ```
eg

![image](https://github.com/dotnetappdevni/BookManager/assets/5619229/5696705a-7482-49e9-92c9-fe95bc2c3eaf)

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
```
{
  "email": "admin@edt.com",
  "password": "Test12345!@",
  "twoFactorCode": "string",
  "twoFactorRecoveryCode": "string"
}
```
   One You have logged in the swagger will produce a jwt berrer token.

   Once you have got the token click the authorise  button on the main swagger screen
   to allow you to enter the token

   its very important that when you do you read the instructions in the popup.

   **IE THIS TEXT**

    JWT Authorization header using the Bearer scheme.

    Enter 'Bearer' [space] and then your token in the text input below.

    Example: "Bearer 12345abcdef"

 Upload Image of popup and button here.
   
 Api Documentation is discoverable here

  https://localhost:7066/swagger/index.html

 <h2>Email Config</h2>

 I have setup an email box on my own domain for the smtp relay 

 ```
   "EmailSettings": {
    "DefaultFromEmail": "info@dotnetappdevni.com",
    "Host": "mail5018.site4now.net",
    "Port": "25",
    "Username": "edt@dotnetappdevni.com",
    "Password": "Test12345!@"
  },
  ```
  This will send a activation link email to your email.
  If your company firewall is strong please amend these

  **In appsettings.Development or appsettings.json if deploying
  to server.**

  Screen shot of welcome email.

 If you use the following json payload in the body
 ```
 {
  "email": "admin@edt.com",
  "password": "Test12345!@",
  "twoFactorCode": "string",
  "twoFactorRecoveryCode": "string"
 }
```

Use the end point /login
It will allow u to login to the api once u done the migration
steps above


<h1>Registration of new user</h1>
You can add a new user at the registration section
end point /regiser

Password requirements are 1 upper
1 special character.

**please ensure its a live email address as the code 
uses this to send activation link to you.**

```
{
  "email": "example@example.com",
  "password": "Test12345!@"
}
```

Note: Do NOT forget that if you do register a new user u need to 
configure a smtp server via app settings or use 
paper cut as recommended above as you need to verify the 
activation link.

While not part of the assignment I hosted it online here on 
my own hosting.

Just to prove am capable of deploying to a server enviorment.

[https://api-edt.dotnetappdevni.com/swagger/index.html](https://api-edt.dotnetappdevni.com/swagger/index.html)
