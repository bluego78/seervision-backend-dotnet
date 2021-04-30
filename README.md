### This a NON WORKING server

This code it's just an example to show you the structure of the API REST Service in .NET Core.

### How does it works

The flow is: 

 - the controller gets the request from the http.
 - the controller uses the methos exposed by the todoService by the todoService Interface by a dependency injection.
 - the service do the call to the database using maybe entity framework
 - the controller returns the json response


### What will you find

- Controllers/TodoListController.cs (handles the call from http and returns the json response)
- Services/TodoService.cs (do the job ad returns the response object)
- Interfaces/ITodoService.cs (to inject the TodoService.cs methids into the TodoListController.cs)
- Models/Todo.cs (structure of the Todo Object / table on the DB)
- Models/TodoContext.cs (the context that entity framework uses to access the DB)
