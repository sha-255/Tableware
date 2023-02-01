# Tableware
* [**Tableware.bak**](docs/blob/main/Tableware.bak) - бэкап бд SQL.
* [**Tableware01**](docs/tree/main/Tableware01) - файл проекта.
* [**DataBase.cs**](docs/blob/main/Tableware01/DataBase.cs) - соединение с БД.
каталог с бд указывается на 10 строке
```c#
    private static SqlConnection connection = new SqlConnection(
        @"Data Source=DESKTOP-DU3CPSG\Q;Initial Catalog=Tableware;Integrated Security=True");
```
