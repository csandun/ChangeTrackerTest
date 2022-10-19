using ChangeTrackerTest;

var oldList = new List<int?> { 3, 4, 5 };
var newList = new List<int?> { 1, 2, 3, 5, 6, 7 };

var changes = new ChangesTracker<int?, int?>
    (oldList, newList, (oldItem, newItem) => oldItem.Equals(newItem) );

var newItems = changes.AddedItems.ToList(); // 1,2,6,7
var removedItems = changes.RemovedItems.ToList(); // 4
var updatedItems = changes.UpdatedItems.ToList(); // 3,5

Console.WriteLine("Newly added - " + String.Join(",", newItems));
Console.WriteLine("Removed - " +String.Join(",", removedItems));
Console.WriteLine("Updated or Unchanged - " + String.Join(",", updatedItems));


var dbOldPersonList = Seeder.OldPersonList.ToList();
var generatedNewPersonList = Seeder.NewPersonList.ToList();


var changesOfPerson = new ChangesTracker<Person, Person>
    (dbOldPersonList, generatedNewPersonList, (oldItem, newItem) => 
        oldItem.Email.Equals(newItem.Email) 
        );

var newPersonItems = changesOfPerson.AddedItems.ToList(); // Saman@gmail.com
var removedPersonItems = changesOfPerson.RemovedItems.ToList(); // Chathuranga@gmail.com, Ann@gmail.com, David@gmail.com
var updatedPersonItems = changesOfPerson.UpdatedItems.ToList(); // sandun@gmail.com, sandun@gmail.com, Nimal@gmail.com

Console.ReadKey();