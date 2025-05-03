namespace DataModels.Users
{
    public class User_log
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int LogType { get; set; }
        public DateTime LogTime { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Sex { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
