using System.ComponentModel.DataAnnotations;

namespace Classes.Models {
   public class AppUsers {

      [Key] // PK
      public int Id { get; set; }

      public string Name { get; set; }

      public DateOnly BirthDate { get; set; }

   }
}
