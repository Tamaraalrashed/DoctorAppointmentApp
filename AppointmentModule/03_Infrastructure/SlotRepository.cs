using System;
using System.Collections.Generic;
using System.Linq;

namespace AppointmentModule
{
    public class SlotRepository : SlotsRepository, ISlotRepository
    {
        public IEnumerable<Slot> GetAllSlotsAvailable()
        {
            return FindAll(x => x.IsReserved == false);
        }
        public void ReserveSlot(Slot slot)
        {
            slot.IsReserved = true;
            Update(slot, x => x.Id == slot.Id);
        }

    }

}
