using System.ComponentModel.DataAnnotations;

namespace SampleAPI.Model
{
    public  class Cities
    {
        [Key]
        public int CityId { get; set; }
        public string? CityName { get; set; }
        public int? EmployeeId { get; set; }
        public string? EmployeeName { get; set; } = string.Empty;

    }
}
