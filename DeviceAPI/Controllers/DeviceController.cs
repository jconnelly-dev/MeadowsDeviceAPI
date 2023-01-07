using DeviceAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace DeviceAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{apiVersion}/[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly int _trackingId;
        private readonly ILogger<DeviceController> _logger;

        public DeviceController(ILogger<DeviceController> logger)
        {
            Random rand = new Random();
            _trackingId = rand.Next(0, int.MaxValue);
            _logger = logger;
        }

        /// <summary>
        /// Retrieve device position data
        /// </summary>
        /// <returns>DevicePosition</returns>
        /// <param name="deviceId">The unique identifier for the device</param>
        /// <example>GET: /api/1.0/device/123</example>
        /// <response code="200">Success</response>
        /// <response code="400">Request validation error</response>
        /// <response code="500">Internal processing error</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DevicePosition))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet(Name = "GetPosition")]
        public IActionResult GetDevicePosition([Required(ErrorMessage = "deviceId is required"), Range(1, int.MaxValue)] int deviceId)
        {
            _logger.Log(LogLevel.Information, "GetDevicePosition()", _trackingId);

            if (!ModelState.IsValid)
            {
                _logger.Log(LogLevel.Warning, "GetDevicePosition()", _trackingId, "Status 400 Bad Request: Invalid Request");
                return Problem(statusCode: StatusCodes.Status400BadRequest, detail: "Invalid Request");
            }

            try
            {
                // TODO... jconnelly...

                DevicePosition result = new DevicePosition
                {
                    DeviceId = deviceId,
                    Point = new GpsPoint
                    {
                        Lat = 34.134408310433905,
                        Lng = -116.12022840232942,
                        HeadingDegrees = 315.75,
                        SpeedMps = 3.14,
                        GpsDateUtc = new DateTime(2022, 1, 8, 20, 48, 0, DateTimeKind.Utc)
                    },
                    ReceiveDateUtc = new DateTime(2022, 1, 8, 20, 48, 6, DateTimeKind.Utc)
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, "GetDevicePosition()", _trackingId, ex.Message);
                return Problem(statusCode: StatusCodes.Status500InternalServerError, detail: "Status 500 Internal Server Error.");
            }
        }

        /// <summary>
        /// Store device position data
        /// </summary>
        /// <returns>bool</returns>
        /// <example>POST: /api/1.0/device</example>
        /// <response code="200">Success</response>
        /// <response code="400">Request validation error</response>
        /// <response code="500">Internal processing error</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost(Name = "AddPosition")]
        public IActionResult AddDevicePosition()
        {
            _logger.Log(LogLevel.Information, "AddDevicePosition()", _trackingId);

            if (!ModelState.IsValid)
            {
                _logger.Log(LogLevel.Warning, "AddDevicePosition()", _trackingId, "Status 400 Bad Request: Invalid Request");
                return Problem(statusCode: StatusCodes.Status400BadRequest, detail: "Invalid Request");
            }

            try
            {
                bool result = true;

                // TODO... jconnelly...

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, "AddDevicePosition()", _trackingId, ex.Message);
                return Problem(statusCode: StatusCodes.Status500InternalServerError, detail: "Status 500 Internal Server Error.");
            }
        }
    }
}