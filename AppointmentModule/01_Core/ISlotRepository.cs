using System;
using System.Collections.Generic;

namespace AppointmentModule
{
    public interface ISlotRepository
    {
        IEnumerable<Slot> GetAllSlotsAvailable();
        void ReserveSlot(Slot slot);
    }
}
