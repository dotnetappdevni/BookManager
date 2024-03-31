
[![BookManagerAPI](https://github.com/dotnetappdevni/BookManager/actions/workflows/dotnet.yaml/badge.svg)](https://github.com/dotnetappdevni/BookManager/actions/workflows/dotnet.yaml)

<h2>EDT Book Manager API</h2>

The Book Manager API facilitates the adding of books/customers and the check-out and check-in process of books.

You will have to remove the Data Migrations from the BookManager.DAL solution if you want to use EF migrations to seed the database.

To be able to create the migration, ensure you are in the root directory of the project.

************************************************************************
<h2> DB Server Setup Instructions</h2>

Download and install SQL Server 2019 Developer Edition or Express.

I am using version 2019 of SQL Server, Version 15.0.2104.1.

Microsoft Download Link for SQL Server 2019: Please virus-scan the download at your own risk.

    https://go.microsoft.com/fwlink/?linkid=866662
***********************************************************************
In Solution Explorer, navigate to the BookManager.API project and locate the appsettings files in the root of the project.

<h2>appsettings.Development.json Configuration Setup</h2>
If you are building a release, obviously ensure that the connection settings match those
of your development JSON, including email settings.
Find the database connection string, which I use for SQL Server.

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

<H2>
You need to replace sql5053.site4now.net with your server instance name.
Keep the catalog the same with Initial Catalog and create a login in SQL Management Studio for the </H2>

<h2>username:edt</h2>
<h2>password:edt12345</h2>

<h2>Note: It's important to ensure that the login above is mapped to the database name.</h2>
<h1>Database Name: You can change this to anything you want.</h1>

And give the EDT user DBOwner permissions.

Migrations and Database Scaffolding Instructions:
You can apply the migration from the PackageManager Console. 
Ensure that the API Project is set as the startup project and is showing in the dropdown.

For completeness, I have created an offline backup of the database. 
It's in the folder named DBScripts in the outer folder.

```
dotnet ef migrations add FirstMigration --context
ApplicationDBContext --output-dir Data\Migrations 
-p BookManager.DAL -s BookManager.API 
```

For example,
your directory should look like this 
if you use the 'pwd' command in the package manager console.

![image](https://github.com/dotnetappdevni/BookManager/assets/5619229/62beead7-d57c-427b-9d37-e58811073fad)

**Please ensure that the API project is selected as the default project, as indicated by the second arrow, and make sure that it is set as the **

** startup project **
eg

![image](https://github.com/dotnetappdevni/BookManager/assets/5619229/c46ad2f3-d73b-4a2d-85f9-5b985572b655)


Once you have created the Logins above and executed the migration,
please ensure that you are in the directory as shown 
in the image above before applying the migration again.
 
 ```
  dotnet ef database update --context ApplicationDBContext
  -p BookManager.DAL -s BookManager.API
 ```
eg

![image](https://github.com/dotnetappdevni/BookManager/assets/5619229/5696705a-7482-49e9-92c9-fe95bc2c3eaf)
Once the migration is complete, you can log in to SQL Server using the details created above.

<h2>Features of API</h2>
* .NET 8
* New .NET 8 API endpoints allowing login and JWT token generation

<h2>API Endpoints</h2>
<h2>Books Endpoints</h2>

 <h2> Books End Points</h2>
 
    * Muliple end points for adding , removing, updating  and deleting books.
      Check in and Check Out end points for the loaning and returning of a book.
   
   <h2> Customer End Points</h2>
   
   * Customer End points for <br>
   adding , <br>
   removing,<br>
   updating 
   <br>deletion of customers.
   
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
 Once you have logged into Swagger, it will produce a JWT bearer token.

Once you have obtained the token, click the "Authorize" button on the 

main Swagger screen to allow you to enter the token.

It's very important that when you do, you read the instructions in the popup.

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

 This is my own mail server on my own .net hosting, 
 so it should work unless you need your security team to allow it.

The hosting company is called smarterasp.net.

This will send an activation link email to your email.
If your company firewall is strong, please make amendments accordingly.

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

Use the endpoint /login. It will allow you to login to 
the API once you have completed the migration steps above.

<h1>Registration of a new user</h1>
You can add a new user at the registration section endpoint `/register`.

Password requirements are: 1 uppercase letter and 1 special character.```


**please ensure its a live email address as the code 
uses this to send activation link to you.**

```
{
  "email": "example@example.com",
  "password": "Test12345!@"
}
```
Note: Do NOT forget that if you do register a new user,
you need to configure an SMTP server via app settings or use my live one.

While not part of the assignment, I hosted it online here on my own hosting.

<h2>Demo Live URL</h2>
Just to prove I am capable of deploying to a server environment.

[https://api-edt.dotnetappdevni.com/swagger/index.html](https://api-edt.dotnetappdevni.com/swagger/index.html)

<h2>Automated Builds</h2>

If you look at github actions tab you will the last build if you 
click on that it will take you to runs status page.

On left hand side you can see two build steps
If you click on nunit jobs you can see a nice brake down of tests.

https://github.com/dotnetappdevni/BookManager/actions/runs/8499936802/job/23281270260

![workflowsunitests](https://github.com/dotnetappdevni/BookManager/assets/5619229/7ceeb2f9-e468-4021-a656-eca8ac139a7e)



 ![workflowunitests2](https://github.com/dotnetappdevni/BookManager/assets/5619229/ae7edc29-cd5b-4961-89ed-972ba95ea762)


