using Capstone_BE.Business.Interface;
using Capstone_BE.Business.Model;
using AutoMapper;

namespace Capstone_BE.Business.Service
{
    public class ExampleService : IExampleService
    {
        private readonly IMapper _mapper;

        public ExampleService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ResultModel> ExampleFunction()
        {
            var result = new ResultModel();
            try
            {
                // Code in here!
            }
            catch (Exception e)
            {
                result.IsSuccess = false;
                result.Code = 400;
                result.ResponseFailed = e.InnerException != null ? e.InnerException.Message + "\n" + e.StackTrace : e.Message + "\n" + e.StackTrace;
            }
            return result;
        }
    }
}
