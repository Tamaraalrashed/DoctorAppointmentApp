using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace DoctorAvailabilityModule
{
    public class DoctorController : ApiController
    {
        private DoctorBusiness mgr;

        public DoctorController()
        {
            mgr = new DoctorBusiness();
        }


        [Route("GetAllSlotsByDoctorId")]
        [HttpGet]
        public IHttpActionResult GetAllSlotsByDoctorId([FromUri] Guid doctorId)
        {
            List<Slot> Slots = mgr.GetAllSlotsByDoctorId(doctorId);

            return Ok(Slots);

        }

        [Route("AddSlot")]
        [HttpGet]
        public IHttpActionResult AddSlot([FromBody] Slot Slot)
        {
           mgr.AddSlot(Slot);
            return Ok();
        }


    }
}
