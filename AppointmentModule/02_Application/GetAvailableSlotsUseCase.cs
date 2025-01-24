using System;
using System.Collections.Generic;
using System.Linq;

namespace AppointmentModule
{
    public class GetAvailableSlotsUseCase
    {
        private readonly SlotRepository _slotRepository;

        public GetAvailableSlotsUseCase(SlotRepository slotRepository)
        {
            _slotRepository = slotRepository;
        }

        public List<Slot> GetAvailableSlots()
        {
            return _slotRepository.GetAllSlotsAvailable().ToList();

        }
    }


}
