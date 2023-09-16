using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusRouteManagementSystem.Model
{
    public class Response <T> where T :class
    {
        public Response()
        {

        }
        public Response(string message, bool isSuccess)
        {
            isSuccess = isSuccess;
            Data = null;
            TotalCount = 0;
            Message = message;


        }
        public Response(T data, bool isSuccess =true, string? message = null, int? totalCount =0) 
        {
            isSuccess = isSuccess;
            Data = data;
            TotalCount = 0;
            Message = message;

        }
        public bool IsSuccess { get; set; } = false;
        public string? Message { get; set; } = null;
        public  T?  Data { get; set; } = null;
        public int? TotalCount { get; set; } = 0;
    }
}
