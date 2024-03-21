using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Models {
   public class Classes {
      // we are going to use Entity Framework
      // https://learn.microsoft.com/en-us/ef/




      public int Id { get; set; }

      public string Name { get; set; }

      public int CurricularYear { get; set; }

      public int Semester { get; set; }

      /* **************************************
       * Defining Relationships between Classes
       * ************************************** */


      // define the N-1 relationship

      // the annotation [ForeignKey] links the attributes
      // CourseFK and Course
      [ForeignKey(nameof(Course))]
      public int CourseFK { get; set; }  // FK to a Course table
      public Courses Course { get; set; }  // FK to a Course element
   }
}
