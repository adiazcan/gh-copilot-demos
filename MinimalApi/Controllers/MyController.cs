using Microsoft.AspNetCore.Mvc;

namespace MinimalApi.Controllers
{
    public class MyController : ControllerBase
    {
        public IMyService myService;

        public MyController() : base()
        {
               
        }

        public MyController(IMyService myService) : this()
        {
            this.myService = myService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await this.myService.Get();
            return Ok(result);
        }   
    }
}
