using MyEntities;

namespace DataAccess;

public class PetDataAccessObject
{
    public List<Pet> GetAllPets()
    {
        return new List<Pet>()
        {
            new Pet()
            {
                MyProperty = "hey"
            }
        };
    }
}