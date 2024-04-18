using System.ComponentModel.DataAnnotations;

namespace Classes.Models {
   public class Courses {

      public Courses() {
         ListOfClasses = new HashSet<CourseUnits>();
         ListOfStudents=new HashSet<Students>();
      }

      [Key] // PK
      public int Id { get; set; }

      /// <summary>
      /// defines the name of course
      /// </summary>
      [StringLength(100)]
      [Required(ErrorMessage ="The {0} must be written")]
      [Display(Name ="Name")]
      public string Name { get; set; }

      /// <summary>
      /// name of course logotype file 
      /// </summary>
      [StringLength(50)]
      public string? Logotype { get; set; } 
      // the ? mark means that Logotype can has NULL values


      /* **************************************
       * Defining Relationships between CourseUnits
       * ************************************** */

      // define the 1-N relationship

      /// <summary>
      /// List of classes the the course has
      /// </summary>
      public ICollection<CourseUnits> ListOfClasses { get; set; }

      /// <summary>
      /// List of students enrolled on course
      /// </summary>
      public ICollection<Students> ListOfStudents { get; set; }

   }
}
