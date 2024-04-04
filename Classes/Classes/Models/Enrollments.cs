using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Models {

   // M-N primary key
   [PrimaryKey(nameof(StudentFK),nameof(ClassFK))]   // EF >= 7.0
   public class Enrollments {

      public DateTime RegistrationDate { get; set; }


      /* **************************************
    * Defining Relationships between CourseUnits
    * ************************************** */

      // M-N
      [ForeignKey(nameof(Class))]
      //  [Key, Column(Order = 1)]  // EF <= 6.0
      public int ClassFK { get; set; }
      public CourseUnits Class { get; set; }

      [ForeignKey(nameof(Student))]
      //  [Key, Column(Order = 2)]  // EF <= 6.0
      public int StudentFK { get; set; }
      public Students Student { get; set; }
   }
}
