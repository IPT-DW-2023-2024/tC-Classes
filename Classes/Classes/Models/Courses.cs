using System.ComponentModel.DataAnnotations;

namespace Classes.Models {
   public class Courses {

      public Courses() {
         ListOfClasses = new HashSet<Classes>();
         ListOfStudents=new HashSet<Students>();
      }

      [Key] // PK
      public int Id { get; set; }

      public string Name { get; set; }

      public string Logotype { get; set; }


      /* **************************************
       * Defining Relationships between Classes
       * ************************************** */

      // define the 1-N relationship
      public ICollection<Classes> ListOfClasses { get; set; }

      public ICollection<Students> ListOfStudents { get; set; }

   }
}
