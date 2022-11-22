
namespace Capstone_BE.Business.Model
{
    public class ResultModel
    {
        public bool IsSuccess { get; set; }
        public int Code { get; set; }
        public object? ResponseSuccess { get; set; }
        public object? ResponseFailed { get; set; }
    }
}
