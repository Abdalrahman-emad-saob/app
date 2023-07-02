using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
  public class AppUser
    {
        [Key] // cam be omitted cause the name Id is the convention but if you want to call it another name then use this annotation
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}