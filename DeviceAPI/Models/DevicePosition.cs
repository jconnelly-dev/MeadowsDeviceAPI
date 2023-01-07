using DeviceAPI.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace DeviceAPI.Models
{
    /// <summary>
    /// Device position data
    /// </summary>
    public class DevicePosition
    {
        #region Members.
        /// <summary>
        /// Unique identifier for the device
        /// </summary>
        /// <example>123</example>
        [Required(ErrorMessage = "DeviceId is required")]
        [Range(1, int.MaxValue)]
        public int DeviceId { get; set; }

        /// <summary>
        /// GPS location data of the device
        /// </summary>
        [Required(ErrorMessage = "Point is required")]
        public GpsPoint Point { get; set; }

        /// <summary>
        /// Date/time on the server when position was received (utc timezone)
        /// </summary>
        [Required(ErrorMessage = "ReceiveDateUtc is required")]
        [AttributeValidation.DatetimeIsoString]
        public DateTime ReceiveDateUtc { get; set; }
        #endregion

        #region Contructors.
        public DevicePosition() 
        {
            DeviceId = default;
            Point = new GpsPoint();
            ReceiveDateUtc = default;
        }

        public DevicePosition(int deviceId, GpsPoint point, DateTime recvDateUtc)
        {
            DeviceId = deviceId;
            Point = point;
            ReceiveDateUtc = recvDateUtc;
        }
        #endregion
    }
}
