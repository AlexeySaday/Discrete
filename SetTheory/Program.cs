using SetTheory;
using SetTheory.Conditions;

var db = new DB();
var parents = db.GetParents();
var wives = db.GetWives();

var motherChecker = new RoyalDynastyMotherChecker(
    new ParentsWifeCondition(), new WomanAndParentCondition()
);

var mothersCount = 0;
foreach (var name in db.GetAllNames()) 
    if (motherChecker.AnyMother(name, parents, wives)) 
        mothersCount++;  

Console.WriteLine("Mothers count in db is {Count}", mothersCount);