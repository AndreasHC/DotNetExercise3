// Svar på fråga 3.3.13: Ett attribut som alla fåglar behöver förläggs lämpligen till "Bird".
// Svar på fråga 3.3.14: Ett attribut som alla djur behöver förläggs lämpligen till "Animal".
using DotNetExercise3;

try
{
    //Person person = new Person()
    //{
    //    Age = 12,
    //    FName = "Sune",
    //    LName = "Snutt",
    //    Height = 179,
    //    Weight = 84,
    //};

    PersonHandler personHandler = new PersonHandler();
    Person sune = personHandler.CreatePerson(12, "Sune", "Snutt", 179, 84);
    Person pelle = personHandler.CreatePerson(14, "Pelle", "Plutt", 142, 65);
    Console.WriteLine(personHandler.GetAge(pelle) == 14);
    Console.WriteLine(personHandler.GetFName(sune) == "Sune");
    Console.WriteLine(personHandler.GetLName(pelle) == "Plutt");
    Console.WriteLine(personHandler.GetHeight(sune) == 179);
    Console.WriteLine(personHandler.GetWeight(pelle) == 65);
    personHandler.SetAge(sune, 13);
    Console.WriteLine(personHandler.GetAge(sune) == 13);
    personHandler.SetFName(pelle, "Peter");
    Console.WriteLine(personHandler.GetFName(pelle) == "Peter");
    personHandler.SetLName(sune, "Skrutt");
    Console.WriteLine(personHandler.GetLName(sune) == "Skrutt");
    personHandler.SetHeight(pelle, 145);
    Console.WriteLine(personHandler.GetHeight(pelle) == 145);
    personHandler.SetWeight(sune, 79);
    Console.WriteLine(personHandler.GetWeight(sune) == 79);

    List<UserError> errors = new List<UserError>() 
    {
        new TextInputError(),
        new TextInputError(),
        new MouseInputError(),
        new NumericInputError(),
        new TextInputError(),
        new NumericInputError(),
        new EmptyFieldError(),
        new CheckboxInputError(),
        new TextInputError(),
        new NumericInputError(),
        new NumericInputError()
        };
    foreach (UserError error in errors)
        Console.WriteLine(error.UEMessage());

    List<Animal> animals = new List<Animal>();
    animals.Add(new Horse("Stewball", 300, 11, 165));
    animals.Add(new Swan("Odette", 12, 19, 200, SwanSongPattern.OnlyAtDeath));
    animals.Add(new Dog("Gaspode the wonder dog", 10, 8, "Terrier-like mongrel"));
    animals.Add(new Wolfman("Scott Howard", 70, 17, "Light Blue"));

    foreach (Animal animal in animals)
    {
        Console.WriteLine(animal.Name);
        animal.DoSound();
        if(animal is IPerson)
            ((IPerson)animal).Talk();
    }


}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}