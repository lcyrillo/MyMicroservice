
using AutoFixture;

namespace MyMicroservice.Data;

public static class Seeder
{
    public static void Seed(this MicroDbContext microDbContext)
    {
        if (!microDbContext.Persons.Any())
        {
            Fixture fixture = new Fixture();
            fixture.Customize<Person>(person => person.Without(p => p.Id));

            List<Person> persons = fixture.CreateMany<Person>(100).ToList();
            microDbContext.AddRange(persons);
            microDbContext.SaveChanges();
        }
    }
}