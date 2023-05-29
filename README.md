# Gareeva_kpo_idz4
Этот репозиторий содержит код для микросервиса обработки заказов, который предоставляет API для создания и обработки заказов в ресторане.  
Микросервис основан на архитектуре RESTful API и предлагает следующий набор функций:
# Микросервис авторизации пользователей
### Регистрация нового пользователя
 • Реализована конечная точка RESTful API Registration.cs для регистрации нового пользователя.
 • Пользователь может зарегистрироваться, предоставив имя пользователя, адрес электронной почты, пароль и роль.
 • Данные пользователя проходят проверку на корректность (проверяется наличие символа "@" в адресе электронной почты).
 • Возвращаются соответствующие коды состояния HTTP и ответные сообщения для успешных и неудачных попыток регистрации.
### Вход пользователя в систему (авторизация)
 • Реализована конечная точка RESTful API Authorization.cs для входа зарегистрированного пользователя в систему.
 • Пользователь предоставляет сервису электронную почту и пароль для входа.
 • Управление сессией пользователя осуществляется с использованием JWT (токена) для поддержания статуса аутентификации. 
 • Возвращаются соответствующие коды состояния HTTP и ответные сообщения для успешных и неудачных попыток входа в систему.
 • Предоставляются сообщения об ошибках в случае неудачных попыток входа с предоставлением некорректных данных.
### Предоставление информации о пользователе
 • Реализована конечная точка RESTful API UserController.cs для выдачи информации о пользователе по токену и его доступах к системе.
 • Возвращаются соответствующие коды состояния HTTP.  
 
# Микросервис обработки заказов
### Создание заказов
 • Реализована конечная точка RESTful API OrderController.cs, позволяющая пользователям создавать новые заказы.
 • Каждый заказ включает идентификатор пользователя, идентификатор блюда, специальные запросы и статус заказа.
 • Предусмотрена проверка корректности предоставленных данных.
 • Возвращаются соответствующие коды состояния HTTP и ответные сообщения для успешных и неудачных попыток создания заказа.
### Обработка заказов
 • Реализован внутренний обработчик заказов IOrderProcessor.cs, который извлекает из таблицы "dish" заказы в статусе "в ожидании", с некоторой задержкой обрабатывает заказ и меняет его статус на "выполнен".
Предоставление информации о заказе
 • Реализована конечная точка RESTful API OrderController.cs, которая возвращает информацию о заказе и его статусе по идентификатору.
 • Возвращаются соответствующие коды состояния HTTP.
### Управление блюдами
 • Реализована логика управления блюдами, позволяющая отслеживать наличие блюд в ресторане.
 • Реализовано RESTful API DishController.cs для CRUD операций с таблицей "dish".
 • Доступ к управлению блюдами имеют только пользователи с ролью менеджера.
 • Каждое блюдо имеет количество штук в наличии (0 означает, что блюдо недоступно для заказа).
 • Возвращаются соответствующие коды состояния HTTP.
### Предоставление меню
 • Реализована конечная точка RESTful API Menu.cs, которая возвращает информацию о блюдах в виде меню с учетом доступности.
 • Возвращаются соответствующие коды состояния HTTP.  
 
# Архитектура системы
Микросервис обработки заказов разработан с использованием следующих технологий и компонентов:
 • Язык программирования: C#
 • Фреймворк: ASP.NET Core
 • База данных: PostgreSQL 
 • Аутентификация и авторизация: JWT (JSON Web Tokens)
 • Взаимодействие с другими микросервисами: HTTP RESTful API
Микросервис разделен на следующие компоненты:
 • Контроллеры: обрабатывают входящие HTTP-запросы и возвращают соответствующие ответы.
 • Сервисы: содержат бизнес-логику и осуществляют взаимодействие с базой данных и другими микросервисами.
 • Модели данных: определяют структуру и связи данных в системе.  
 
### В соответствии с требованиями было выполнено:
1. Корректная реализация сервиса авторизации пользователей:
    1.1. Регистрация пользователя
    1.2. Вход пользователя в систему
    1.3. Выдача информации о пользователе  
2. Корректная реализация сервиса обработки заказов
    2.1. Управление заказами
    2.2. Управление блюдами
    2.3. Предоставление информации о меню  
3. Реализация коллекции Swagger, которая должна демонстрирует функциональность реализованных микросервисов, охватывая все API.

### Изменения, которые были внесены по необходимости:
Jwt token по условию должен был хранится в 255 символах, я поменяла на 500 символов, так как в него не помещалась необходимая информация.   
В токене должны были храниться роли, так как при управлять блюдами мог только пользователь с ролью «менеджер», а размер в 255 символов был слишком мал для этого.
