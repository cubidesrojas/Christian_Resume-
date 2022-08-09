using Microsoft.AspNetCore.Mvc;
using Christian_Resume_Web_API.models;
using Microsoft.EntityFrameworkCore;
using Christian_Resume_Web_API.models;
namespace Christian_Resume_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class notes : ControllerBase
    {

        private readonly ILogger<notes> _logger;
        private readonly Data_Context dbcontext;

        public notes(Data_Context dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        [HttpPost("message")]
        public async Task<StatusCodeResult> Post([FromQuery] Client_Info message)
        {

            try
            {


                var client_message = dbcontext.Client_Messages.AddAsync(message);
                await dbcontext.SaveChangesAsync();
                return StatusCode(200);


            }
            catch (Exception e)
            {

                _logger.LogError(e, "you didn't things right!!!");
                return StatusCode(500);
            }


        }

        [HttpDelete("message")]
        public async Task<ActionResult<IQueryable<Client_Info>>> Delete_message(string name)
        {

            dbcontext.Client_Messages.RemoveRange(dbcontext.Client_Messages.Where(x => x.CLient_Name.ToLower() == name.ToLower()));

            await dbcontext.SaveChangesAsync();
            return Ok("it was good !!!!!!!!!");
        }



    }
}