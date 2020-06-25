using System.Reflection.Metadata.Ecma335;

namespace mbtest.Models {
  public class MinModel {
        public string Navn { get; set; }
        public int? Id { get; set; }
    }

    public class Person {
        public string Brugernavn { get; set; }
        public string Gruppe { get; set; }
        public bool IsAdmin { get; set; }

    }
}