using DotNetExercise3;

try
{
    Person person = new Person()
    {
        Age = 12,
        FName = "Sune",
        LName = "Snutt",
        Height = 179,
        Weight = 84,
    };

}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}