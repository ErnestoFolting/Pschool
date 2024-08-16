namespace PschoolBackend_DAL.Entities
{
    public class ParentCouple
    {
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public ICollection<Student>? Children { get; set; } = new List<Student>();
        public int? Parent1Id { get; set; } //FK
        public Parent? Parent1 { get; set; }

        public int? Parent2Id { get; set; } //FK
        public Parent? Parent2 { get; set; }
    }
}
