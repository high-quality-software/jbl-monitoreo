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
            [FromBody] DeviceContract dto
            )
        {
            var entity = data.Devices.Where(x => x.Name == dto.name).OrderBy(x => x.Id).FirstOrDefault();
            if (entity == null)
            {
                entity = new Data.Entities.Devices();
            }

            entity.Name = dto.name;
            entity.Alias = dto.alias;
            entity.Community = dto.community;
            entity.Deleted = false;
            entity.Disabled = false;

            data.Devices.Update(entity);
            data.SaveChanges();

            return Ok("OK");
        }

        [HttpPost]
        [Route("sample")]
        public IActionResult SaveSample(
            [FromServices] DataContext data,
            [FromBody] SampleContact dto
            )
        {
            var entity = data.Devices
                .Where(x => x.Name == dto.device_name)
                .OrderBy(x => x.Id)
                .FirstOrDefault();

            if (entity == null)
            {
                return BadRequest($"No existe un dispositivo con nombre {dto.device_name}");
            }

            var sample = new Data.Entities.Samples();
            sample.DeviceID = entity.Id;
            sample.Oid = dto.object_id;
            sample.OName = dto.object_name;
            sample.Timestamp = dto.timestamp;
            sample.Unit = dto.unit;
            sample.Value = dto.value;

            data.Samples.Add(sample);
            data.SaveChanges();

            return Ok("OK");
        }

    }
}

