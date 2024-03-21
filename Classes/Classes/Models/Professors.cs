namespace Classes.Models {

   public class Professors : AppUsers {
      // relationship of type Class-SubClasse

      public Professors() {
         ListOfClasses = new HashSet<CourseUnits>();
      }

      public ICollection<CourseUnits> ListOfClasses { get; set; }

   }
}
