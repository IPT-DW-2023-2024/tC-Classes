using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Models {
   public class Enrollments {

      public DateTime RegistrationDate { get; set; }


      /* **************************************
    * Defining Relationships between Classes
    * ************************************** */

      // M-N
      [ForeignKey(nameof(Class))]
      public int ClassFK { get; set; }
      public Classes Class { get; set; }

      [ForeignKey(nameof(Student))]
      public int StudentFK { get; set; }
      public Students Student { get; set; }
   }
}
