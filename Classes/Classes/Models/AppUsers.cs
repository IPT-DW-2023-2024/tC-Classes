using System.ComponentModel.DataAnnotations;

namespace Classes.Models {
   /// <summary>
   /// attributs for all users
   /// </summary>
   public class AppUsers {

      [Key] // PK
      public int Id { get; set; }

      /// <summary>
      /// user's name
      /// </summary>
      public string Name { get; set; }

      /// <summary>
      /// user's birth date
      /// </summary>
      public DateOnly BirthDate { get; set; }

      /// <summary>
      /// user's cell phone
      /// </summary>
      [StringLength(17)]
      [RegularExpression("(+|00)?[0-9]{7,15}",
                         ErrorMessage = "Please, write a valid cell phone number")]
      public string CellPhone { get; set; }

   }
}
