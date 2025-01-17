public static class Seeder
{
    public static List<Doctor> GetDoctorAvailabilities()
    {
        return new List<Doctor>
        {
            new Doctor { Id = 1, DoctorName = "Dr. Smith", AvailableDate = DateTime.Now.AddDays(1) },
            new DoctorAvailability { Id = 2, DoctorName = "Dr. Johnson", AvailableDate = DateTime.Now.AddDays(2) },
            new DoctorAvailability { Id = 3, DoctorName = "Dr. Brown", AvailableDate = DateTime.Now.AddDays(3) }
        };
    }
}
