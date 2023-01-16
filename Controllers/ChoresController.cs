namespace choresmanagement.Controllers;

[ApiController]
[Route("api/chores")]

public class ChoresController : ControllerBase
{
        private readonly ChoresService _choresService;
        public ChoresController(ChoresService choresService)
        {
            this._choresService = choresService;
        }

        [HttpGet]
        public ActionResult<List<Chore>> Get()
        {
            try 
            {
            List<Chore> chores = _choresService.Get();
            return Ok(chores);
            }
            catch (Exception e)
            {
            return BadRequest(e.Message);
            }
        }
        
}
