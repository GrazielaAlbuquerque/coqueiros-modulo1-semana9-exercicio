using Microsoft.AspNetCore.Mvc;
using Semana09.Model;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SemanaController : ControllerBase
{
        private readonly SemanaContext semanaContext;

        public SemanaController(SemanaContext semanaContext)
        {
            this.semanaContext = semanaContext;
        }
        [HttpGet]
            public ActionResult Get()
            {
                return Ok();
            }

        [HttpGet("{id}")]
            public ActionResult Get([FromRoute] int id)
            {
                return Ok();
            }
        [HttpPost("Post")]
        public ActionResult Post([FromBody] SemanaModel semanaModel)
            {
             if (semanaModel.Id > 0)
                {
                    return Ok(true);
                }
                {
                    return BadRequest("ID necessita ser maior que 0");
                }
            }
        [HttpPut("Put")]
        public ActionResult Put([FromBody] SemanaModel semanaModel)
        {
           if (semanaModel.Id != 0)
                {
                    return Ok(true);
                }
                {
                    return BadRequest("ID necessita ser maior que 0");
                }
        }
        [HttpDelete("Delete")]
        public ActionResult Delete(int id)
        {
            var Id = semanaContext.Semana.Find(id);

            if (Id == null)
            {
                return NotFound();
            }
            semanaContext.Semana.Remove(Id);
            semanaContext.SaveChanges();
            return NoContent();
        }
    }
}