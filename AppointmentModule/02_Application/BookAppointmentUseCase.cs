using AppointmentConfirmationModule;


namespace AppointmentModule
{
    public class BookAppointmentUseCase
    {
        private readonly AppointmentRepository _repository;
        private readonly SlotRepository _slotRepository;

        public BookAppointmentUseCase(AppointmentRepository repository)
        {
            _repository = repository;
            _slotRepository = new SlotRepository();
        }

        public void BookAppointment(Appointment appointment)
        {
            _repository.Add(appointment);
            Slot _slot = _slotRepository.FindById(x => x.Id == appointment.SlotId);
            _slotRepository.ReserveSlot(_slot);
            AppConfirmation.SendConfirmation(appointment);
        }


    }

}
