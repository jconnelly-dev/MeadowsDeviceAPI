using DeviceAPI.Helpers;
using System.ComponentModel.DataAnnotations;

namespace DeviceAPI.Models
{
    /// <summary>
    /// GPS location data
    /// </summary>
    public class GpsPoint
    {
        #region Members.
        /// <summary>
        /// North/south location coordinate
        /// </summary>
        [Required(ErrorMessage = "Lat is required")]
        [Range(-90, 90)]
        public double Lat { get; set; }

        /// <summary>
        /// East/west location coordinate
        /// </summary>
        [Required(ErrorMessage = "Lng is required")]
        [Range(-180, 180)]
        public double Lng { get; set; }

        /// <summary>
        /// Navigational direction (angle in degrees)
        /// </summary>
        [Required(ErrorMessage = "HeadingDegrees is required")]
        [Range(0, 360)]
        public double HeadingDegrees { get; set; }

        /// <summary>
        /// Speed when the point was created (meters per second)
        /// </summary>
        [Required(ErrorMessage = "SpeedMps is required")]
        [Range(0, 12)]
        public double SpeedMps { get; set; }

        /// <summary>
        /// Date/time when the point was created (utc timezone)
        /// </summary>
        [Required(ErrorMessage = "GpsDateUtc is required")]
        [AttributeValidation.DatetimeIsoString]
        public DateTime GpsDateUtc { get; set; }
        #endregion

        #region Contructors.
        public GpsPoint()
        {
            Lat = default; 
            Lng = default;
            HeadingDegrees = default;
            SpeedMps = default;
            GpsDateUtc = default;
        }

        public GpsPoint(double lat, double lng, double headingDegrees, double speedMps, DateTime gpsDateUtc)
        {
            Lat = lat;
            Lng = lng;
            HeadingDegrees = headingDegrees;
            SpeedMps = speedMps;
            GpsDateUtc = gpsDateUtc;
        }
        #endregion
    }
}
