# Animal Shelter API

#### _An API has been created for use by an Animal Shelter. The API can be called upon to store, create, and delete information about animals at the shelter. The API comes in two versions. Version 1 is the legacy version while Version 2 can handle CRUD as well as queryable GET functionality._

<br>

## Authored by:
#### Remy Flores
<hr >

## Table of Contents
1. [Technologies Used](#technologies-used)
2. [Setup Instructions](#installation-and-setup)
3. [API Documentation](#api-documentation)
4. [Known Bugs](#known-bugs)
5. [License Information](#license)

<hr >

## Technologies Used

- C#
- .NET
- Git
- Markdown
- MySQL
- Identity
- Swagger
- Postman
- VS Code
- Paging
- Version

<hr >

## Installation And Setup

### Installation Steps
1. _To begin, the user must install a compatible version of .NET 6. An acceptable version can be found_ [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
2. _Follow the prompts throught the installation of the program. Using default settings as they originally appear in the setup._
3. _In the terminal_ (ex: Git Bash) _install dotnet-script by runing the following command_
```
$ dotnet tool install -g dotnet-script
```
4. _Configure your local environment to use this. Details for which can be found_ [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script).
5. _Then, install MySQL. Follow further detailed instructions on accomplishing that_ [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).
6. _Install Postman by downloading in the link_ [download and install Postman](https://www.postman.com/downloads/).

### Repository Setup
1. Clone this repository.
2. Open your shell (e.g. Terminal or GitBash) and navigate to this project's production directory called "API".
3. Within the API/AnimalShelterApi folder, create a file titled appsettings.json
4. In the appsettings.json file, paste the following code:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=[uid];pwd=[pwd];"
  }
}
```
5. _Replace_ [uid] _and_ [pwd] _with your created SQL username and password respectively_ _(_including the braces_)._

### Create a local schema
1. _With appsettings.json set up, in your terminal navigate to the root directory of your project._
2. _Type_ ```ef database update```
3. _This will create a schema on your machine with the seed data inserted for you_

### Execute the Program
1. _Open the terminal and navigate to the production directory titled_ "API/AnimalShelterApi"
2. _Run_ `dotnet run` _in the command line to run the program._

### Access the API
1. _You may use whatever API viewer you prefer. The API is set up to work in Swagger. Please refer to the_ [documentation](#api-documentation) _for further instructions._
2. _or Use Postman to call on to url like,_
```
https://localhost:1992/api/v2/Animals
```
<hr >

## API Documentation
_Explore the API endpoints in Postman or a browser._

### Using Swagger Documentation
* _After entering `dotnet run` in the 'AnimalShelterApi' you will then open your web browser_
* _Type this_ 'https://localhost:1992/swagger/index.html' _in the browser or_ 'http://localhost:2000/swagger/index.html'

### Note on Versioning
* _There are two different version of this API_
* _If you are using swagger you can click on the top right rectangle that has a 'v1' to switch between the two versions_
* _If you are using Postman you will need to specify which version you are using in the URL_
* _Here are two examples 'https://localhost:1992/api/v1/Animals' and 'https://localhost:1992/api/v2/Animals'_

### Note on Pagination
* _Version 2 is the ONLY version that utilizes pagination_
* _By default it will show you 5 results per page_
* _You can navigate to page two by modifying the page number in the URL_
* _Here's an example 'https://localhost:1992/api/v2/Animals?pageNumber=1&pageSize=5'_
* Please note that there are only two pages. Would recommend using the URL given previously
* _To see the default enter the URL like this 'https://localhost:1992/api/v2/Animals'_

### Endpoints
_These are base URL's:
Base URL:_ `https://localhost:2000` _or_ `https://localhost:1992`

### HTTP Request Structure
_Here I will show you how to utilize GET for all animals, POST, GET for a specific animal, PUT, and DELETE_
* _A good GET request you should receive a status code of "200 ok" that let's you know the request was a success. When you send a POST request you will receive a "201" code to indicate a successful request. When you send a PUT and DELETE request you will receive a "204" code letting you know it worked._
* _Also anything with a 400 or 404 indicates that the request was bad; double-check that the request was written properly._

This is the http request structure.

```
GET /api/{version}/{component}
POST /api/{version}/{component}
GET /api/{version}/{component}/{id}
PUT /api/{version}/{component}/{id}
DELETE /api/{version}/{component}/{id}
```

#### Example Query
```
https://localhost:1992/api/v2/Animals
```
#### Sample JSON Response
```
{
  "animalId": 1,
  "name": "remy",
  "description": "monster",
  "type": "human",
  "date": "2023-02-20T22:34:43.594"
}
```

## Known Bugs
_I was having an issue with my api giving out the information I first placed. After updated the program.cs and allowing CORS to work, it began  to work okayish.._

_if the issue appears contact me at_:
<br> 
## <remyfranciscoflores@gmail.com>

<hr >

## License

See license [here](./LICENSE.txt)
