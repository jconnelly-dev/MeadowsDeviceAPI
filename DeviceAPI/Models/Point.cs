namespace DeviceAPI.Models
{
    public class Point
    {
        #region Members.
        public double Lat { get; set; }
        public double Lng { get; set; }
        public double Zed { get; set; }
        #endregion

        #region Contructors.
        public Point()
        {
            Lat = default; 
            Lng = default; 
            Zed = default;
        }

        public Point(double lat, double lng, double zed)
        {
            Lat = lat;
            Lng = lng;
            Zed = zed;
        }
        #endregion
    }
}
