using JBL.Monitoreo.Controllers.Contracts;
using JBL.Monitoreo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JBL.Monitoreo.Controllers
{
    [Route("api/monitoreo")]
    [ApiController]
    public class MonitoreoController : ControllerBase
    {
        [HttpPost]
        [Route("device")]
        public IActionResult SaveDevice(
            [FromServices] DataContext data,
            [FromBody] DeviceDto dto
            )
        {
            var entity = data.Devices.Where(x => x.Name == dto.Name).OrderBy(x=>x.Id).FirstOrDefault();
            if (entity == null)
            {
                entity = new Data.Entities.Devices();
            }

            entity.Name = dto.Name;
            entity.Alias = dto.Alias;
            entity.Community = dto.Community;
            entity.Deleted = false;
            entity.Disabled = false;

            data.Devices.Update(entity);
            data.SaveChanges();

            return Ok("OK");
        }
    }
}

