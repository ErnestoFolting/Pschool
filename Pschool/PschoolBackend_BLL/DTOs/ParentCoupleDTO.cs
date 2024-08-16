using PschoolBackend_DAL.Entities;

namespace PschoolBackend_BLL.DTOs
{
    public class ParentCoupleDTO
    {
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public int? Parent1Id { get; set; } //FK

        public int? Parent2Id { get; set; } //FK
    }
}
