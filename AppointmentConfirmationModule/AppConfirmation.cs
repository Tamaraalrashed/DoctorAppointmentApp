using System;

namespace AppointmentConfirmationModule
{
    public class AppConfirmation
    {

        public static void SendConfirmation(Appointment appointment)
        {
            // Log notification for the patient
            LogMessage($"Notification to Patient: Hello {appointment.Patient.Name}, your appointment is confirmed for {appointment.ReservedAt:MMMM dd, yyyy HH:mm} with Dr. {appointment.Slot.Doctor.Name}.");

            // Log notification for the doctor
            LogMessage($"Notification to Doctor: Hello Dr. {appointment.Slot.Doctor.Name}, you have a new appointment scheduled with {appointment.Patient.Name} on {appointment.ReservedAt:MMMM dd, yyyy HH:mm}.");
        }

        private static void LogMessage(string message)
        {
            // Simulating log message
            Console.WriteLine(message);
        }
    }
}
