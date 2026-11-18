# Практическая работа №1. MVC

Каталог производственных участков и оборудования на ASP.NET Core MVC и SQLite. Есть просмотр, поиск участков, фильтр оборудования по участку, добавление, изменение и удаление. Формы проверяются на сервере. База и примеры данных создаются автоматически.

Нужен .NET 10 SDK.

```powershell
dotnet restore
dotnet run --project ProductCatalogApp --launch-profile http
```

Приложение: http://localhost:5034.
