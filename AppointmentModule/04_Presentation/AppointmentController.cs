using AppointmentModule;
using System.Web.Http;
using System.Collections.Generic;

namespace AppointmentController
{
    public class AppointmentController : ApiController
    {
        private readonly BookAppointmentUseCase _useCase;

        public AppointmentController()
        {
            var repository = new AppointmentModule.AppointmentRepository();
            _useCase = new BookAppointmentUseCase(repository);
        }



        [Route("BookAppointment")]
        [HttpPost]
        public IHttpActionResult BookAppointment([FromBody] Appointment appointment)
        {
            _useCase.BookAppointment(appointment);
            return Ok();
        }



        [Route("GetAllSlotsAvailable ")]
        [HttpGet]
        public IHttpActionResult GetAllSlotsAvailable()
        {
            var _slotRepository = new SlotRepository();

            GetAvailableSlotsUseCase _getAvailableUseCase = new GetAvailableSlotsUseCase(_slotRepository);
            List<Slot> _slots = _getAvailableUseCase.GetAvailableSlots();
            return Ok(_slots);
        }


    }
}
