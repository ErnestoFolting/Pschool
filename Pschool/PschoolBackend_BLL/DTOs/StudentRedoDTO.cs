namespace PschoolBackend_BLL.DTOs
{
    public class StudentRedoDTO : StudentDTO
    {
        public int Id { get; set; }
        public ParentCoupleDTO ParentCouple { get; set; }
    }
}
