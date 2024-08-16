    namespace PschoolFrontend.Pages.Entities
{
    public class ParentCouple
    {
        public int Id { get; set; }
        public string FamilyName { get; set; }

        public int? Parent1Id { get; set; }

        public int? Parent2Id { get; set; }
    }
}
