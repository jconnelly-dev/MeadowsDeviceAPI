using DeviceAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace DeviceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly ILogger<DeviceController> _logger;

        public DeviceController(ILogger<DeviceController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPosition")]
        public DevicePosition GetDevicePosition()
        {
            return new DeviceAPI.Models.DevicePosition
            {
                DeviceId = 123,
                Point = new DeviceAPI.Models.Point
                {
                    Lat = 34.134408310433905,
                    Lng = -116.12022840232942,
                    Zed = 0
                },
                GpsDate = new DateTime(2022, 1, 8, 20, 48, 0, DateTimeKind.Utc),
                ReceiveDate = new DateTime(2022, 1, 8, 20, 48, 6, DateTimeKind.Utc)
            };
        }

        [HttpPost(Name = "AddPosition")]
        public bool AddDevicePosition()
        {
            bool success = false;

            // TODO... jconnelly...

            return success;
        }
    }
}