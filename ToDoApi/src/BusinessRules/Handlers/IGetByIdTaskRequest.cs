using ToDoApi.BusinessRules.Request;
using ToDoApi.BusinessRules.Responses;

namespace ToDoApi.BusinessRules.Handlers
{
    public interface IGetByIdTaskHandler
    {
        TaskResponse Execute(GetByIdTaskRequest request);
    }
}
