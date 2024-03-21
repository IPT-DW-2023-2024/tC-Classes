using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Models {
   public class Students {

      public int StudentNumber { get; set; }

      public decimal Fee { get; set; }

      public DateTime EnrollmentDate { get; set; }

      /* **************************************
      * Defining Relationships between Classes
      * ************************************** */

      [ForeignKey(nameof(Course))]
      public int CourseFK { get; set; }

      public Courses Course { get; set; }

   }
}
