using System;

namespace ServiceComp.Company.Exceptions
{
    public class NotFoundException: Exception
    {
        public NotFoundException(string message): base(message)
        {
        }
    }

    public class EntityNotFoundException : NotFoundException
    {
        public EntityNotFoundException(string entity) : base($"{entity} not found.")
        {
        }
    }
}