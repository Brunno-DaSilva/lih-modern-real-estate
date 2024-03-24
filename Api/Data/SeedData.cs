using Microsoft.EntityFrameworkCore;

public static class SeedData
{
    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<HouseEntity>().HasData(new List<HouseEntity> {
            new HouseEntity {
                Id = 1,
                Address = "1212 Valley of Kings Drive",
                City = "Dallas", 
                ZipCode = "75055",
                Country = "United States",
                Description = "A superb detached Victorian property on one of the town's finest roads, within easy reach of Barnes Village. The property has in excess of 6000 sq/ft of accommodation, a driveway and landscaped garden.",
                Price = 900000
            },
            new HouseEntity
            {
                Id = 2,
                Address = "7855 Forks Road",
                City = "Frisco", 
                ZipCode = "75052",
                Country = "United States",
                Description = "This impressive family home, which dates back to approximately 1840, offers original period features throughout and is set back from the road with off street parking for up to six cars and an original Coach House, which has been incorporated into the main house to provide further accommodation. ",
                Price = 500000
            },
            new HouseEntity
            {
                Id = 3,
                Address = "568 Grote Hof Street",
                City = "Plano", 
                ZipCode = "75002",
                Country = "United States",
                Description = "This house has been designed and built to an impeccable standard offering luxurious and elegant living. The accommodation is arranged over four floors comprising a large entrance hall, living room with tall sash windows, dining room, study and WC on the ground floor.",
                Price = 200500
            },
            new HouseEntity
            {
                Id = 4,
                Address = "321 Meel Kade Road",
                City = "McKinney", 
                ZipCode = "75075",
                Country = "United States",
                Description = "Discreetly situated a unique two storey period home enviably located on the corner of Krom Road and Recht Road offering seclusion and privacy. The house features a magnificent double height reception room with doors leading directly out onto a charming courtyard garden.",
                Price = 259500
            },
            new HouseEntity
            {
                Id = 5,
                Address = "123 Main Street",
                City = "Frisco", 
                ZipCode = "75052",
                Country = "United States",
                Description = "This luxurious three bedroom flat is contemporary in style and benefits from the use of a gymnasium and a reserved underground parking space.",
                Price = 400500
            },
            new HouseEntity
            {
                Id= 6,
                Address= "1234 Main Street",
                City= "McKinney",
                ZipCode= "75070",
                Country= "United States",
                Description= "This stunning two-story home features modern amenities and a spacious backyard perfect for entertaining guests.",
                Price= 420000
            },
            new HouseEntity
            {
                Id= 7,
                Address= "5678 Elm Avenue",
                City= "Dallas",
                ZipCode= "75201",
                Country= "United States",
                Description= "A charming bungalow with a cozy fireplace and newly renovated kitchen, located in the heart of Dallas.",
                Price= 375000
            },
             new HouseEntity
             {
                Id= 8,
                Address= "9101 Maple Lane",
                City= "Frisco",
                ZipCode= "75034",
                Country= "United States",
                Description= "Experience luxury living in this spacious condominium with breathtaking views of the city skyline.",
                Price= 550000
            },
              new HouseEntity
             {
                Id= 9,
                Address= "2468 Oak Street",
                City= "McKinney",
                ZipCode= "75071",
                Country= "United States",
                Description= "A cozy cottage nestled in a quiet neighborhood, featuring a beautiful garden and outdoor patio.",
                Price= 320000
            },
               new HouseEntity
            {
                Id= 10,
                Address= "13579 Cedar Road",
                City= "Dallas",
                ZipCode= "75202",
                Country= "United States",
                Description= "This modern loft-style apartment boasts high ceilings, large windows, and easy access to downtown attractions.",
                Price= 480000
            }
        });
    }
}