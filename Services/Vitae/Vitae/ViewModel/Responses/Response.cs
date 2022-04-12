using Vitae.Models;

namespace Vitae.ViewModel.Responses
{
    public class Response<T> 
    {
        public T Data { get; set; }
        public string Error { get; set; }
    }
}
