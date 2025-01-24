using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAvailabilityModule
{
    public class DoctorBusiness 
    { 
        public List<Slot> GetAllSlotsByDoctorId(Guid doctorId)
        {
            SlotsRepository slotsRepository = new SlotsRepository();
            return  slotsRepository.FindAll( d=>d.Id == doctorId).ToList();
        } 
        
        public void  AddSlot(Slot slot )
        {
            SlotsRepository slotsRepository = new SlotsRepository();
             slotsRepository.Add(slot);
        } 
    }
}
