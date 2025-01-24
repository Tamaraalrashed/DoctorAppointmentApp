using AppointmentModule;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web;

namespace AppointmentController
{
    public class AppointmentController : ApiController
    {
        private readonly AppointmentService _service;

        public AppointmentController()
        {
            var repository = new AppointmentRepository();
            _service = new AppointmentService(repository);
        }



        [Route("BookAppointment")]
        [HttpPost]
        public HttpResponseMessage BookAppointment([FromBody] Appointment appointment)
        {
            _service.BookAppointment(appointment);
            if (appointment.Status == Appointment.AppointmentStatusEnum.Completed)

                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("Appointment booked successfully.")
                };
            else
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Invalid appointment data.")
                };
        }

    

    [Route("GetAllSlotsAvailable ")]
    [HttpGet]
    public IHttpActionResult GetAllSlotsAvailable()
    {
        return Ok();
    }


}
}
