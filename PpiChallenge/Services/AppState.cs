using Models;

namespace PpiChallenge.Services
{
    public class AppState
    {
        public IEnumerable<CandidateModel> Candidates { get; set; } = new List<CandidateModel>();
        public AppState()
        {
            Candidates = new List<CandidateModel>(){
                new (){Id = 1, FirstName = "Cristiano", LastName= "Ronaldo", EmailAdress= "cr7@outlook.com", PhoneNumber= "1111122222", ZipCode = "Zip test1"},
                new (){Id = 2, FirstName = "Lionel", LastName= "Messi", EmailAdress= "messi@outlook.com",    PhoneNumber= "3333344444", ZipCode = "Zip test2"},
                new (){Id = 3, FirstName = "Zinedine", LastName= "Zidane", EmailAdress= "zidane@outlook.com",PhoneNumber= "5555566666", ZipCode = "Zip test3"},
                new (){Id = 4, FirstName = "Luis", LastName= "Figo", EmailAdress= "figo@outlook.com",        PhoneNumber= "7777788888", ZipCode = "Zip test4"},
                new (){Id = 5, FirstName = "David", LastName= "Bechham", EmailAdress= "bechham@outlook.com", PhoneNumber= "9999911111", ZipCode = "Zip test5"},
                new (){Id = 6, FirstName = "Andres", LastName= "Iniesta", EmailAdress= "iniesta@outlook.com",PhoneNumber= "2222233333", ZipCode = "Zip test6"},
            }.ToList();


        }


    }
}

