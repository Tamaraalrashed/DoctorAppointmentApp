using System.Web.Http;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System;
using static Entities.Enums;

namespace AppointmentManagementController
{
    public class AppointmentManagementController : ApiController
    {

        public AppointmentManagementController()
        {

        }


        //[Route("BookAppointment")]
        //[HttpPost]
        //public HttpResponseMessage BookAppointment([FromBody] Guid doctorId, [FromBody] AppointmentStatusEnum appointmentStatus)
        //{
        //    _useCase.BookAppointment(appointment);
        //    if (appointment.Status == Appointment.AppointmentStatusEnum.Completed)

        //        return new HttpResponseMessage(HttpStatusCode.OK)
        //        {
        //            Content = new StringContent("Appointment booked successfully.")
        //        };
        //    else
        //        return new HttpResponseMessage(HttpStatusCode.BadRequest)
        //        {
        //            Content = new StringContent("Invalid appointment data.")
        //        };
        //}


        [Route("GetAllDoctorAppointments")]
        [HttpGet]
        public IHttpActionResult GetAllDoctorAppointments(Guid id)
        {
            AppointmentRepository _appointmentRepository = new AppointmentRepository();

            List<Appointment> _appointments = _appointmentRepository.FindAll(x => x.Slot.DoctorId == id).ToList();
            return Ok(_appointments);
        }


    }
}
