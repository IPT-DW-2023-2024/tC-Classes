using Microsoft.EntityFrameworkCore.ChangeTracking;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Models {

   public class Students : AppUsers {

      public Students() {
         ListOfEnrollments = new HashSet<Enrollments>();
      }


      public int StudentNumber { get; set; }

      /// <summary>
      /// auxiliary attribute to help us to write Fee values
      /// </summary>
      [NotMapped] // the EF do not add this attribute to database
      [Display(Name ="Fee")]
      [StringLength(9)]
      [RegularExpression("[0-9]{1,6}([,.][0-9]{1,2})?", 
         ErrorMessage ="Write a number. You can use until 2 decimal digits.")]
      public string FeeAux { get; set; }

      /// <summary>
      /// Fee to be paid by Student at enrollment
      /// </summary>
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
