# LIBRARY TRACKER

#### By Keisha Hepners, Skylan Lew, Tim Empey

#### Epicodus 3 day project, SQL and MVC

## Technologies Used

- C#/.NET
- CSS
- Javascript
- mySQL
- Entity
- Identity

## Description

This program allows users to track books for a library. Currently there is only one type of user, who can login and add books to check out.
The books to check out are located on Books/Index view. Here there are buttons to click next to each book to check them out. When they are check out, they are added to the user's check out books list, and removed from the public list.
The program tracks checked out books individually per user.

## Setup/Installation Requirements

### Requires

- [.NET 5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0) - <https://dotnet.microsoft.com/en-us/download/dotnet/5.0>
- MySQL - Recommend [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)

### Download/Run
- Clone: `$git clone https://github.com/TimEmpey/Libray.git`
- Create a file named `appsettings.json` in the project folder `/Library/`
- Put the following code inside `appsettings.json`, making sure to set your uid and pwd:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=library;uid=YOURUSERNAME;pwd=YOURPASSWORD;"
  }
}
```
- Apply migrations: `$dotnet ef database update` 
- Run: `$dotnet ef run`

## Known Bugs

- None

## License

[MIT](https://choosealicense.com/licenses/mit/) `[MIT](https://choosealicense.com/licenses/mit/)`

[GNU GPL3.0](https://choosealicense.com/licenses/gpl-3.0/)
`[GNU GPL3.0](https://choosealicense.com/licenses/gpl-3.0/)`

Copyright (c) 2022 Keisha Hepner, Skylan Lew, Tim Empey

