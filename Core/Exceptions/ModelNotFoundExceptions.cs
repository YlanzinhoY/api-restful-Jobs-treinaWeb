namespace TWJobs.Core.Exceptions
{
    public class ModelNotFoundExceptions : Exception
    {
        public ModelNotFoundExceptions(string message = "Model not found") : base(message) {}
    }
}
