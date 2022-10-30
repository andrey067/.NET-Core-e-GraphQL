using src.BusinessRules.Request;
using src.BusinessRules.Responses;

namespace src.BusinessRules.Handlers
{
    public interface IUpsertTaskHandler
    {
        UpsertTaskResponse Execute(UpersetTaskRequest request); 
    }
}
