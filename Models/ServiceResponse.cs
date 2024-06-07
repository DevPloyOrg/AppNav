namespace DevPloyClasses.Models
{
    /// <summary>
    /// Generic Class For API response
    /// </summary>
    /// <typeparam name="T">generic data type transfered</typeparam>
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Succes { get; set; }
        public string Message { get; set; }

        public ServiceResponse()
        {
            Succes = true;
            Message = string.Empty;
        }
    }
}
