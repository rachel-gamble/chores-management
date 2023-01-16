namespace choresmanagement.Repositories;

public class ChoresRepository
{

    private List<Chore> choreDb;

    // NOTE only written this way today for fake database
    // NOTE this whole repo will look different for today
    public ChoresRepository()
    {
        this.choreDb = new List<Chore>()
      {
        new Chore(1, "Clean the Kitchen", 45, 5, false ),
        new Chore(2, "Take out the Trash", 5, 7, false),
        new Chore(3, "Walk the Dog", 30, 7, true),
        new Chore(4, "Vacuum", 45, 1, true),
        new Chore(5, "Sweep and Mop", 60, 1, false)
        // new Chore(6, ""),

  };
    }

    internal Chore Create(Chore choreData)
    {
        choreData.Id = choreDb[choreDb.Count - 1].Id + 1;
        choreDb.Add(choreData);
        return choreData;
    }
    internal List<Chore> Get()
    {
        return choreDb;
    }

    internal string Remove(int id)
    {
        Chore choreToRemove = choreDb.Find(c => c.Id == id);
        bool result = choreDb.Remove(choreToRemove);
        if (result)
        {
            return $"{choreToRemove.Name} was removed from db";
        }
        return "no chore to delete.";
    }
}