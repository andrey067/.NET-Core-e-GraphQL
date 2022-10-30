using ToDoApi.BusinessRules.Responses;

namespace ToDoApi.BusinessRules.Handlers
{
    public interface IGetAllTaskHandler
    {
        TasksResponse Execute();
    }
}
