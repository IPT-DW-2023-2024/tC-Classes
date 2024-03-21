using Microsoft.EntityFrameworkCore.ChangeTracking;

using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Models {

   public class Students : AppUsers {

      public Students() {
         ListOfEnrollments = new HashSet<Enrollments>();
      }


      public int StudentNumber { get; set; }

      public decimal Fee { get; set; }

      public DateTime EnrollmentDate { get; set; }

      /* **************************************
      * Defining Relationships between CourseUnits
      * ************************************** */


      // 1-N
      [ForeignKey(nameof(Course))]
      public int CourseFK { get; set; }

      public Courses Course { get; set; }


      // M-N
      public ICollection<Enrollments> ListOfEnrollments { get; set; }

   }
}
