using ToDoApi.BusinessRules.Handlers;
using ToDoApi.BusinessRules.Request;
using ToDoApi.BusinessRules.Responses;

namespace src.Api
{
    public class Query
    {
        public TasksResponse GetTasks([Service] IGetAllTaskHandler handler)
        {
            return handler.Execute();
        }

        public TaskResponse GetTask([Service] IGetByIdTaskHandler handler, GetByIdTaskRequest request)
        {
            return handler.Execute(request);
        }
    }
}
