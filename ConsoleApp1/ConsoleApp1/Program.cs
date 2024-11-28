internal class Program
{
    private static void Main(string[] args)
    {
        var people = new List<person>();
        var saba = new person();
        saba.Id = 123;
        saba.Name = "Saba";
        var mariami = new person();
        mariami.Id = 321;
        mariami.Name = "Mariami";
        people.Add(saba);
        people.Add(mariami);

        bool anyPeople = people.Any();
        bool anySaba = people.Any(p => p.Id == saba.Id && p.Name == saba.Name);
        bool anyMariami = people.Any(p => p.Id == mariami.Id && p.Name == mariami.Name);

        bool allSaba = people.All(p => p.Id == saba.Id && p.Name == saba.Name);
        bool allMariami = people.All(p => p.Id == mariami.Id && p.Name == mariami.Name);

        var groupedPeople = people.GroupBy(p => p.Name);
    }
}

public class person
{
    public int Id { get; set; }
    public string Name { get; set; }

}