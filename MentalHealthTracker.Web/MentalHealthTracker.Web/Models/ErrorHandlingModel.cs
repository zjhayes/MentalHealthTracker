using System;

namespace MentalHealthTracker.Web.Models
{
    public class ErrorHandlingModel
    {
        public Guid LoggingId { get; set; }
        public DateTime ErrorDateTime { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
    }
}