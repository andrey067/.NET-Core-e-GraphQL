using src.BusinessRules.Request;
using src.BusinessRules.Responses;
using src.BusinessRules.Validators;
using src.Database.Domain;
using src.Database.Repositories;

namespace src.BusinessRules.Handlers
{
    public class UpsertTaskHandler : IUpsertTaskHandler
    {
        private readonly ITaskRepository _repository;
        private readonly ITaskValidator _validator;
        public UpsertTaskHandler(ITaskRepository repository, ITaskValidator validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public UpsertTaskResponse Execute(UpersetTaskRequest request)
        {
            var validatorResult = _validator.Validate(request);

            if (!validatorResult.IsValid)
            {
                return new UpsertTaskResponse
                {
                    Erros = validatorResult.Errors
                };
            }

            Todo entity;
            if (request.Id.HasValue)
            {
                entity = _repository.GetById(request.Id.Value);
                if (entity == null)
                    throw new Exception("Tarefa não encontrada");
            }
            else
            {
                entity = new Todo();
            }

            entity.Title = request.Title;
            entity.Description = request.Description;
            entity.Done = request.Done;
            if (request.Done)
                entity.DtDone = DateTime.Now;
            else
                entity.DtDone = null;

            entity = _repository.Save(entity);

            return new UpsertTaskResponse
            {
                Payload = new UpsertTaskResponsePayload
                {
                    Id = entity.Id.Value,
                    Title = entity.Title,
                    Description = entity.Description,
                    Done = entity.Done,
                    DtDone = entity.DtDone,
                }
            };
        }
    }
}
