namespace PschoolFrontend.Pages.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public int? ParentCoupleId { get; set; }
        public ParentCouple ParentCouple { get; set; }
    }
}
