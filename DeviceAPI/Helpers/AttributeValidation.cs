using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace DeviceAPI.Helpers
{
    public static class AttributeValidation
    {
        public class DatetimeIsoString : ValidationAttribute
        {
            public DatetimeIsoString()
            {
                ErrorMessage = "Specified ISO 8601 UTC DateTime String value is invalid.";
            }

            public override bool IsValid(object? stringValue)
            {
                bool valid = false;

                if (stringValue != null)
                {
                    try
                    {
                        string isoString = (string)stringValue;
                        if (string.IsNullOrEmpty(isoString) || !DateTime.TryParse(isoString, provider: null, DateTimeStyles.RoundtripKind, out DateTime time) || time.Kind != DateTimeKind.Utc)
                        {
                            ErrorMessage = "Specified time must be ISO 8601 UTC in string format, such as: \"2008-11-01T19:35:00.0000000Z\".";
                        }
                        else if (time > DateTime.UtcNow)
                        {
                            ErrorMessage = "Specified time cannot be later than current UTC DateTime.";
                        }
                        else
                        {
                            valid = true;
                        }
                    }
                    catch (Exception)
                    {
                        valid = false;
                    }
                }

                return valid;
            }
        }
    }
}
