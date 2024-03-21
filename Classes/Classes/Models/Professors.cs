namespace Classes.Models {

   public class Professors : AppUsers {
      // relationship of type Class-SubClasse

      public Professors() {
         ListOfClasses = new HashSet<Classes>();
      }

      public ICollection<Classes> ListOfClasses { get; set; }

   }
}
