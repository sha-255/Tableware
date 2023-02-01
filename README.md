# Tableware
* [**Tableware.bak**](https://github.com/sha-255/Tableware/blob/main/Tableware.bak) - бэкап бд SQL.
* [**Tableware01**](https://github.com/sha-255/Tableware/tree/main/Tableware01) - файл проекта.
* [**DataBase.cs**](https://github.com/sha-255/Tableware/blob/main/Tableware01/DataBase.cs) - соединение с БД.
каталог с бд указывается на [10](https://github.com/sha-255/Tableware/blob/b4c2758906e975cc6e183e7ae03430cd830ed1d3/Tableware01/DataBase.cs#L10) строке
```c#
    private static SqlConnection connection = new SqlConnection(
        @"Data Source=DESKTOP-DU3CPSG\Q;Initial Catalog=Tableware;Integrated Security=True");
```
