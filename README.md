# CRM_Blazor

# CRM - система для компании-грузоперевозчика

Целью данной работы является разработка системы для автоматизации стратегий автоматизации взаимодействия с заказчиками для повышения уровня продаж, оптимизации маркетинга и улучшения обслуживания клиентов путём сохранения информации о клиентах и истории взаимоотношений с ними, установления и улучшения бизнес-процессов и последующего анализа результатов.

[Полный текст технического задания](https://docs.google.com/document/d/11Ww-Y7HftGWpbmltUG04NhCKCJpe_OKtoM-xGl08amg/edit?usp=sharing) 

Технологии использованные в проекте:
 - Blazor WASM
 - SQLite
 - Blazor Server
 
 ## Структура репозитория

```Client``` - Директория, где находится клиентская часть приложения, тут содержатся страницы(Pages), общие компоненты(Shared), такие как меню и сайдбар(NavMenu), css стили(App.css), общие настройки клиентской части(Crm_WASM.Server.csproj), ViewModels, с помощью которых обеспечивается обращение к серверной части через HTTP(ViewModels).

```Server``` - Директория, где находится серверная часть приложения, тут содержится база данных(DB), контроллеры(Controllers), в которых создаются HTTP-запросы, для получения данных из базы данных, модели для подключения к базе данных (Models), подключение библиотек(Crm_WASM.Server.csproj).

```Shared``` - Содержит общие классы Order и Customer, для того чтобы использовать их одновременно и в клиентской, и в серверной части приложения.

Для того, чтобы запустить приложение локально, необходимо, чтобы был установлен .NET SDK 3 версии и выше, .NET Core 3 и выше версии. Также, необходимо прописать в файле ```appsettings.json``` абсолютный путь до базы данных, содержащейся в папке ```DB``` - ```Crm_WASM.db```.
Далее необходимо перейти в командную строку и перейти в ней в папку ```Server```, где необходимо прописать команду ```dotnet run```, после чего приложение запустится локально по адресу https://localhost:58688, данное значение можно изменить в настройках приложения.

В приложении реализована авторизация, вход и выход из аккаунта, отображение и изменение профиля пользователя, вывод списка клиентов, вывод списка заказов, вывод списка заказов для авторизовавшегося пользователя, вывод заказов выбранного из списка клиентов пользователя, страница конкретного заказа, ограничение интерфейса для неавторизовавшегося пользователя.


