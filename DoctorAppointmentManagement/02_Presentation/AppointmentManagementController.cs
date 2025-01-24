using System.Web.Http;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System;
using static Entities.Enums;
using DoctorAppointmentManagement;

namespace AppointmentManagement
{
    public class AppointmentManagementController : ApiController
    {

        private readonly AppointmentService _service;

        public AppointmentManagementController(AppointmentService service)
        {
            _service = service;
        }


  

        [Route("GetAllDoctorAppointments")]
        [HttpGet]
        public IHttpActionResult GetAllDoctorAppointments(Guid id)
        {

            List<Appointment> _appointments = _service.FindAll().ToList() ;
            return Ok(_appointments);
        }

        [Route("ManageAppointments")]
        [HttpPost]
        public IHttpActionResult ManageAppointments(Guid id ,  AppointmentStatusEnum appointmentStatusEnum )
        {

           _service.ManageAppointments(id , appointmentStatusEnum) ;
            return Ok();
        }


    }
}
