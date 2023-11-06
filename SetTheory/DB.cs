namespace SetTheory;

public class DB
{
    private readonly FeatureVector[] _parents = 
    {
        new ("Георг 1", new[] { "Георг 2" }),
        new ("Георг 3", new[] { "Георг 4", "Вильгельм 4", "Эдвард" }),
        new ("Эдвард", new[] { "Виктория" }),
        new ("Виктория", new[] { "Эдвард 7" }),
        new ("Эдвард 7", new[] { "Георг 5" }),
        new ("Георг 5", new[] { "Эдвард 8", "Георг 6" }),
        new ("Георг 6", new[] { "Елизавета 2" }),
        new ("Виктория", new[] { "Элис" }),
        new ("Элис", new[] { "Виктория Альберта" }),
        new ("Виктория Альберта", new[] { "Элис-Моунтбаттен" }),
        new FeatureVector("Элис-Моунтбаттен", new[] { "Филипи" })
    };

    private readonly FeatureVector[] _wives = 
    {
        new FeatureVector("София", new [] { "Георг 1" }),
        new FeatureVector("Вильгельмина", new [] { "Георг 2" }),
        new FeatureVector("Шарлотта", new [] { "Георг 3" }),
        new FeatureVector("Каролина", new [] { "Георг 4" }),
        new FeatureVector("Аделаида", new [] { "Вильгельм 4" }),
        new FeatureVector("Виктория", new [] { "Альберт" }),
        new FeatureVector("Александра", new [] { "Эдвард 7" }),
        new FeatureVector("Виктория Мари", new [] { "Георг 5" }),
        new FeatureVector("Елизавета", new [] { "Георг 6" }),
        new FeatureVector("Елизавета П", new [] { "Филлип" })
    };

    public FeatureVector[] GetParents() => _parents;

    public FeatureVector[] GetWives() => _wives;

    public IReadOnlyCollection<string> GetAllNames()
    {
        var names = new List<string>();
        foreach (var parent in _parents)
        {
            names.Add(parent.Label);
            names.AddRange(parent.Values);
        } 
        foreach (var wife in _wives)
        {
            names.Add(wife.Label);
            names.AddRange(wife.Values);
        }

        return names;
    }
}