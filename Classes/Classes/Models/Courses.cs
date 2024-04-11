using System.ComponentModel.DataAnnotations;

namespace Classes.Models {
   public class Courses {

      public Courses() {
         ListOfClasses = new HashSet<CourseUnits>();
         ListOfStudents=new HashSet<Students>();
      }

      [Key] // PK
      public int Id { get; set; }

      [StringLength(100)]
      [Required(ErrorMessage ="The {0} must be written")]
      [Display(Name ="Name")]
      public string Name { get; set; }

      [StringLength(50)]
      public string? Logotype { get; set; } 
      // the ? mark means that Logotype can has NULL values


      /* **************************************
       * Defining Relationships between CourseUnits
       * ************************************** */

      // define the 1-N relationship
      public ICollection<CourseUnits> ListOfClasses { get; set; }

      public ICollection<Students> ListOfStudents { get; set; }

   }
}
