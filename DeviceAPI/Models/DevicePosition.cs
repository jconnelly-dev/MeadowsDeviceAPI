using System.Drawing;

namespace DeviceAPI.Models
{
    public class DevicePosition
    {
        #region Members.
        public int DeviceId { get; set; }
        public Point Point { get; set; }
        public DateTime GpsDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        #endregion

        #region Contructors.
        public DevicePosition() 
        {
            DeviceId = default;
            Point = new Point();
            GpsDate = default;
            ReceiveDate = default;
        }

        public DevicePosition(int deviceId, Point point, DateTime gpsDate, DateTime recvDate)
        {
            DeviceId = deviceId;
            Point = point;
            GpsDate = gpsDate;
            ReceiveDate = recvDate;
        }
        #endregion
    }
}
