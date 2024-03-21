namespace Classes.Models {
   public class Professors {

      public Professors() {
         ListOfClasses = new HashSet<Classes>();
      }

      public ICollection<Classes> ListOfClasses { get; set; }

   }
}
