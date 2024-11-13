using System.ComponentModel.DataAnnotations;

namespace ITOS_LEARN.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "กรุณากรอกชื่อ")]
        [MaxLength(30, ErrorMessage = "ความยาวของชื่อต้องไม่เกิน 30 ตัวอักษร")]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "กรุณากรอกนามสกุล")]
        [MaxLength(30, ErrorMessage = "ความยาวของนามสกุลต้องไม่เกิน 30 ตัวอักษร")]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "กรุณากรอกวันเกิด")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "กรุณากรอกอีเมล")]
        [EmailAddress(ErrorMessage = "อีเมลไม่ถูกต้อง")]
        [MaxLength(70, ErrorMessage = "ความยาวของอีเมลต้องไม่เกิน 70 ตัวอักษร")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "กรุณากรอกเบอร์โทรศัพท์")]
        [MaxLength(15, ErrorMessage = "ความยาวของเบอร์โทรศัพท์ต้องไม่เกิน 15 ตัวอักษร")]
        public required string PhoneNumber { get; set; }

        [Required(ErrorMessage = "กรุณากรอกตำแหน่งงาน")]
        [MaxLength(30, ErrorMessage = "ความยาวของตำแหน่งงานต้องไม่เกิน 30 ตัวอักษร")]
        public required string JobPosition { get; set; }
    }
}
