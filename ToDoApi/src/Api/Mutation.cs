using src.BusinessRules.Handlers;
using src.BusinessRules.Request;
using src.BusinessRules.Responses;

namespace src.Api
{
    public class Mutation
    {
        public UpsertTaskResponse UpsertTask(
                                [Service] IUpsertTaskHandler handler,
                                UpersetTaskRequest request)
        {

            return handler.Execute(request);
        }
    }
}
