### Основные ссылки:
* [**Tableware.bak**](https://github.com/sha-255/Tableware/blob/main/Tableware.bak) - бэкап базы данных SQL.
* [**Tableware01**](https://github.com/sha-255/Tableware/tree/main/Tableware01) - файл проекта.
* [**DataBase.cs**](https://github.com/sha-255/Tableware/blob/main/Tableware01/DataBase.cs) - соединение с базой данных.
* [**Tableware01.Tests**](https://github.com/sha-255/Tableware/tree/main/Tableware01.Tests) - Unit тесты.
* [**DataBaseTest.cs**](https://github.com/sha-255/Tableware/blob/main/Tableware01.Tests/DataBaseTest.cs) - Unit тесты сласса соединения с базой данных.
* [**DataBase.cs**](https://github.com/sha-255/Tableware/blob/main/Tableware01/DataBase.cs) - соединение с БД.
каталог с бд указывается на [10](https://github.com/sha-255/Tableware/blob/b4c2758906e975cc6e183e7ae03430cd830ed1d3/Tableware01/DataBase.cs#L10) строке
```c#
    private static SqlConnection connection = new SqlConnection(
        @"Data Source=DESKTOP-DU3CPSG\Q;Initial Catalog=Tableware;Integrated Security=True");
```
___
# Tableware
Простой пример возможной реализации десктопного приложения, выполняющего базовые действия с базой данных.
## Начало работы
1. Сохранить файл проекта на локальном компьютере.
2. Запустить в исполняемой среде [Visual Studio](https://visualstudio.microsoft.com).
### Необходимые условия
* [Microsoft Visual Studio Comunity 2019](https://visualstudio.microsoft.com) или старше.
* Персональный компьютер.
```
Запуск возможен с девяти часов вечера до семнадцати часов до полудня в полное затмение и 4 фазу луны.
```
### Установка
1. Нажимаем Viev Code -> Dowindolad Zip.
```
Пример из жизни: 
    Заходят в бар все программисты под Windiws Form и WPF.
    А бармен говорит: -Опять никого.
```
2. Скачиваем
```
Да уж, анекдот конечно смешной, жаль только, что я не понял.
```
3. И вот у нас и крутой проект с говнокодом.
## Авторы
* **sha-255** - *Initial work* - [sha-255](https://github.com/sha-255)

See also the list of [contributors](https://github.com/sha-255/Tableware/contributors) who participated in this project.
