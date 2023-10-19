string name = "Ewa";
string sex = "women";

var age = 29;


if (sex == "women" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33 && sex == "women")
{
    Console.WriteLine(name + ",lat " + age);
}
else if (sex == "men" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

else
{
    Console.WriteLine("brak danych");
}