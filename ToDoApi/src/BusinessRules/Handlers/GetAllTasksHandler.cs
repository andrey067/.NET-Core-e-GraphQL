using src.Database.Repositories;
using ToDoApi.BusinessRules.Responses;

namespace ToDoApi.BusinessRules.Handlers
{
    public class GetAllTasksHandler : IGetAllTaskHandler
    {
        private readonly ITaskRepository _repository;

        public GetAllTasksHandler(ITaskRepository repository)
        {
            _repository = repository;
        }

        public TasksResponse Execute()
        {
            var result = _repository.GetAll()
                .Select(q => new TaskReponseItem
                {
                    Id = q.Id.Value,
                    Title = q.Title,
                    Description = q.Description,
                    Done = q.Done,
                    DtDone = q.DtDone
                })
                .ToList();

            return new TasksResponse
            {
                Payload = result
            };
        }
    }
}
