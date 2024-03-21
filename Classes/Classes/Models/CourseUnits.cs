using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Models {
   public class CourseUnits {
      // we are going to use Entity Framework
      // https://learn.microsoft.com/en-us/ef/


      public CourseUnits() {
         ListOfProfessors = new HashSet<Professors>();
         ListOfEnrollments = new HashSet<Enrollments>();
      }

      [Key] // PK
      public int Id { get; set; }

      public string Name { get; set; }

      public int CurricularYear { get; set; }

      public int Semester { get; set; }

      /* **************************************
       * Defining Relationships between CourseUnits
       * ************************************** */


      // define the N-1 relationship

      // the annotation [ForeignKey] links the attributes
      // CourseFK and Course
      [ForeignKey(nameof(Course))]
      public int CourseFK { get; set; }  // FK to a Course table
      public Courses Course { get; set; }  // FK to a Course element


      // define the N-M relationship
      public ICollection<Professors> ListOfProfessors { get; set; }

        public ICollection<Enrollments> ListOfEnrollments { get; set; }
    }
}
