using Microsoft.EntityFrameworkCore;
using DrinkFest.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DrinkFest.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category { CategoryId = 50,CategoryName = "Alcoholic", Description = "All alcoholic drinks" },
                    new Category { CategoryId = 51, CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks" }

                );

            modelBuilder.Entity<Drinks>()
                .HasData(
                    new Drinks
                    {
                        DrinkId = 10,
                        Name = "Beer",
                        Price = 7.95M,
                        ShortDescription = "The third most popular drink overall after water and tea",
                        LongDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                        //Category = Categoriess["Alcoholic"],
                        CategoryId = 50,
                        ImageUrl = "https://images.unsplash.com/photo-1621428674699-90ec7bae03c9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8YmVlcnxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60",
                        InStock = true,
                        isPreferredDrink = true,
                        ImageThumbnailUrl = "https://images.unsplash.com/photo-1596115246571-598a16e725ad?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTh8fGJlZXJ8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60"
                    },
                        new Drinks
                        {
                            DrinkId = 11,
                            Name = "Rum & Coke",
                            Price = 12.95M,
                            ShortDescription = "Cocktail made of cola, lime and rum.",
                            LongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                            //Category = Categoriess["Alcoholic"],
                            CategoryId = 50,
                            ImageUrl = "https://images.unsplash.com/photo-1514218953589-2d7d37efd2dc?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cnVtJTIwYW5kJTIwY29rZXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60",
                            InStock = true,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1614313511387-1436a4480ebb?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cnVtfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 12,
                            Name = "Tequila ",
                            Price = 12.95M,
                            ShortDescription = "Beverage made from the blue agave plant.",
                            LongDescription = "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                            //Category = Categoriess["Alcoholic"],
                            CategoryId = 50,
                            ImageUrl = "https://images.unsplash.com/photo-1662488025059-7f144bcbd2a9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8dGVxdWlsYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60",
                            InStock = true,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1612906515356-7792f4ee2cb4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8dGVxdWlsYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 13,
                            Name = "Wine ",
                            Price = 9.75M,
                            ShortDescription = "A very elegant alcoholic drink",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            //Category = Categoriess["Alcoholic"],
                            CategoryId = 50,
                            ImageUrl = "https://images.unsplash.com/photo-1569919659476-f0852f6834b7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTV8fHdpbmV8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            InStock = true,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1584193674275-5277f8ff83c9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8d2luZXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 14,
                            Name = "Margarita",
                            Price = 17.95M,
                            ShortDescription = "A cocktail with sec, tequila and lime",
                            //Category = Categoriess["Alcoholic"],
                            CategoryId = 50,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            ImageUrl = "https://images.unsplash.com/photo-1631503190221-0f6a15367926?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NXx8bWFyZ2FyaXRhfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            InStock = true,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1603833971780-1a096342a9dd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8bWFyZ2FyaXRhfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 15,
                            Name = "Whiskey with Ice",
                            Price = 7.95M,
                            ShortDescription = "The best way to taste whiskey",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            //Category = Categoriess["Alcoholic"],
                            CategoryId = 50,
                            ImageUrl = "https://images.unsplash.com/photo-1526383103106-edad26ae7572?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8d2hpc2tleXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60",
                            InStock = false,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1638990742994-c96e4f7617fe?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fHdoaXNrZXl8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 16,
                            Name = "Jägermeister",
                            Price = 10.25M,
                            ShortDescription = "A German digestif made with 56 herbs",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            //Category = Categoriess["Alcoholic"],
                            CategoryId = 50,
                            ImageUrl = "https://images.unsplash.com/photo-1638957773782-f9614ba79d81?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fGFsY29ob2x8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            InStock = false,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1638957773782-f9614ba79d81?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fGFsY29ob2x8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 17,
                            Name = "Champagne",
                            Price = 15.95M,
                            ShortDescription = "That is how sparkling wine can be called",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            //Category = Categoriess["Alcoholic"],
                            CategoryId = 50,
                            ImageUrl = "https://images.unsplash.com/photo-1590590570140-53c8efaf9d54?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8Y2hhbXBhZ25lfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            InStock = false,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1525373612132-b3e820b87cea?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Y2hhbXBhZ25lfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 18,
                            Name = "Piña colada ",
                            Price = 5.95M,
                            ShortDescription = "A sweet cocktail made with rum.",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            //Category = Categoriess["Alcoholic"],
                            CategoryId = 50,
                            ImageUrl = "https://images.unsplash.com/photo-1613590759244-177bdd273ab0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cGluYSUyMGNvbGFkYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60",
                            InStock = false,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1613590759244-177bdd273ab0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cGluYSUyMGNvbGFkYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 19,
                            Name = "White Russian",
                            Price = 15.95M,
                            ShortDescription = "A cocktail made with vodka ",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            //Category = Categoriess["Alcoholic"],
                            CategoryId = 50,
                            ImageUrl = "https://images.unsplash.com/photo-1639328238537-d370d62cb60c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjZ8fGFsY29ob2x8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            InStock = false,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1639328238537-d370d62cb60c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjZ8fGFsY29ob2x8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 20,
                            Name = "Long Island Iced Tea",
                            Price = 20.50M,
                            ShortDescription = "Aa mixed drink made with tequila.",
                            LongDescription = "Iced tea (or ice tea[1]) is a form of cold tea. Though it is usually served in a glass with ice, it can refer to any tea that has been chilled or cooled. It may be sweetened with sugar or syrup. Iced tea is also a popular packaged drink which can be mixed with flavored syrup such as lemon, raspberry, lime, passion fruit, peach, orange, strawberry, and cherry",
                            //Category = Categoriess["Alcoholic"],
                            CategoryId = 50,
                            ImageUrl = "https://images.unsplash.com/photo-1632789395770-20e6f63be806?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8aWNlZCUyMHRlYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60",
                            InStock = false,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1632789395770-20e6f63be806?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8aWNlZCUyMHRlYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 21,
                            Name = "Vodka",
                            Price = 8.50M,
                            ShortDescription = "A distilled beverage with water and ethanol.",
                            LongDescription = "Vodka (Polish: wódka [ˈvutka], Russian: водка [ˈvotkə], Swedish: vodka [vɔdkɑː]) is a clear distilled alcoholic beverage. Different varieties originated in Poland, Russia, and Sweden.[1][2] Vodka is composed mainly of water and ethanol but sometimes with traces of impurities and flavourings.[3] Traditionally, it is made by distilling liquid from fermented cereal grains, and potatoes since introduced in Europe in the 1700's. Some modern brands use fruits, honey, or maple sap as the base",
                            //Category = Categoriess["Alcoholic"],
                            CategoryId = 50,
                            ImageUrl = "https://images.unsplash.com/photo-1644902617099-1ee60442ff09?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8dm9ka2F8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            InStock = false,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1644902617099-1ee60442ff09?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8dm9ka2F8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 22,
                            Name = "Gin and tonic",
                            Price = 10.30M,
                            ShortDescription = "Made with gin and tonic water poured over ice.",
                            LongDescription = "A gin and tonic is a highball cocktail made with gin and tonic water poured over a large amount of ice.[1] The ratio of gin to tonic varies according to taste, strength of the gin, other drink mixers being added, etc., with most recipes calling for a ratio between 1:1 and 1:3. It is usually garnished with a slice or wedge of lime. To preserve effervescence, the tonic can be poured down a bar spoon.[2] The ice cools the gin, dulling the effect of the alcohol in the mouth and making the drink more pleasant and refreshing to taste",
                         
                            CategoryId = 50,
                            ImageUrl = "https://images.unsplash.com/photo-1661200808125-da519f663ede?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8Z2lufGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            InStock = false,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1661200808125-da519f663ede?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8Z2lufGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 23,
                            Name = "Cosmopolitan",
                            Price = 5.95M,
                            ShortDescription = "Made with vodka, triple sec, cranberry juice.",
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            
                            CategoryId = 50,
                            ImageUrl = "https://images.unsplash.com/photo-1598373187432-c1ff06874ce8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjB8fGNvc21vcG9saXRhbiUyMGNvY2t0YWlsfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            InStock = false,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1598373187432-c1ff06874ce8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjB8fGNvc21vcG9saXRhbiUyMGNvY2t0YWlsfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 24,
                            Name = "Tea ",
                            Price = 14.95M,
                            ShortDescription = "Made by leaves of the tea plant in hot water.",
                            LongDescription = "Tea is an aromatic beverage prepared by pouring hot or boiling water over cured or fresh leaves of Camellia sinensis, an evergreen shrub native to East Asia which probably originated in the borderlands of southwestern China and northern Burma.[3][4][5] Tea is also rarely made from the leaves of Camellia taliensis.[6][7][8] After plain water, it is the most widely consumed drink in the world.[9] There are many different types of tea; some have a cooling, slightly bitter, and astringent flavour,[10] while others have vastly different profiles that include sweet, nutty, floral, or grassy notes. Tea has a stimulating effect in humans primarily due to its caffeine content",


                            CategoryId = 51,
                            ImageUrl = "https://images.unsplash.com/photo-1502302800694-ff6ec595e6e3?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fHRlYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60",
                            InStock = true,
                            isPreferredDrink = true,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1502302800694-ff6ec595e6e3?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fHRlYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 25,
                            Name = "Water ",
                            Price = 5.20M,
                            ShortDescription = " It makes up more than half of your body weight ",
                            LongDescription = "Water (chemical formula H2O) is an inorganic, transparent, tasteless, odorless, and nearly colorless chemical substance, which is the main constituent of Earth's hydrosphere and the fluids of all known living organisms (in which it acts as a solvent[1]). It is vital for all known forms of life, despite providing neither food, energy, nor organic micronutrients. Its chemical formula, H2O, indicates that each of its molecules contains one oxygen and two hydrogen atoms, connected by covalent bonds. The hydrogen atoms are attached to the oxygen atom at an angle of 104.45°.[2] Water is also the name of the liquid state of H2O at standard temperature and pressure.",
                            
                            CategoryId = 51,
                            ImageUrl = "https://images.unsplash.com/photo-1516888892881-aad840c56db2?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8d2F0ZXJ8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            InStock = true,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1516888892881-aad840c56db2?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8d2F0ZXJ8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 26,
                            Name = "Coffee ",
                            Price = 7.55M,
                            ShortDescription = " A beverage prepared from coffee beans",
                            LongDescription = "Coffee is a drink prepared from roasted coffee beans, seeds of the Coffea plant species. Darkly colored, bitter, and slightly acidic, coffee has a stimulating effect on humans, primarily due to its caffeine content, and is one of the most popular drinks in the world.From the coffee fruit,the seeds are separated to produce unroasted green coffee beans.The beans are roasted and then ground into fine particles that are typically steeped in hot water before being filtered out,producing a cup of coffee.It is usually served hot, although chilled or iced coffee is common.Coffee can be prepared and presented in a variety of ways(e.g., espresso, French press, caffè latte, or already - brewed canned coffee).Sugar,sugar substitutes,milk,and cream are often used to lessen the bitter taste or enhance the flavor. Though coffee is now a global commodity, it has a long history tied closely to food traditions around the Red Sea.The earliest credible evidence of coffee drinking in the form of the modern beverage appears in modern - day Yemen from the mid-15th century in Sufi shrines, where coffee seeds were first roasted and brewed in a manner similar to current methods.The Yemenis procured the coffee beans from the Ethiopian Highlands via coastal Somali intermediaries and began cultivation.By the 16th century,the drink had reached the rest of the Middle East and North Africa, later spreading to Europe.In the 20th century, coffee became a global commodity, creating different coffee cultures around the world.",
                            
                            CategoryId = 51,
                            ImageUrl = "https://images.unsplash.com/photo-1535403318185-d612e6b1dc3c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fGNvZmZlZXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60",
                            InStock = true,
                            isPreferredDrink = true,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1535403318185-d612e6b1dc3c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fGNvZmZlZXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 27,
                            Name = "Kvass",
                            Price = 8.95M,
                            ShortDescription = "Kvass is a fermented cereal-based low alcoholic beverage.",
                            LongDescription = "Kvass is a fermented cereal-based low alcoholic beverage with a slightly cloudy appearance, light-brown colour and sweet-sour taste. It may be flavoured with berries, fruits, herbs or honey.Kvass stems from the northeastern part of Europe,where the grain production is thought to have been insufficient for beer to become a daily drink.The first written mention of kvass is found in the Primary Chronicle, describing the celebration of Vladimir the Great's baptism in 996. In the traditional method, kvass is made from a mash obtained from rye bread or rye flour and malt soaked in hot water, fermented for about 12 hours with the help of sugar and bread yeast or baker's yeast at a room temperature.In industrial methods, kvass is produced from wort concentrate combined with various grain mixtures.It is a popular drink in Russia, Ukraine, Poland, Baltic countries, Finland and some parts of China.",
                            
                            CategoryId = 51,
                            ImageUrl = "https://images.unsplash.com/photo-1627828094935-5a73a17affd0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8YmV2ZXJhZ2V8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
                            InStock = true,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1627828094935-5a73a17affd0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8YmV2ZXJhZ2V8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new Drinks
                        {
                            DrinkId = 28,
                            Name = "Juice ",
                            Price = 12.50M,
                            ShortDescription = "Naturally contained or present in fruit or vegetable tissue.",
                            LongDescription = "Juice is a drink made from the extraction or pressing of the natural liquid contained in fruit and vegetables. It can also refer to liquids that are flavored with concentrate or other biological food sources, such as meat or seafood, such as clam juice. Juice is commonly consumed as a beverage or used as an ingredient or flavoring in foods or other beverages, as for smoothies. Juice emerged as a popular beverage choice after the development of pasteurization methods enabled its preservation without using fermentation (which is used in wine production).[1] The largest fruit juice consumers are New Zealand (nearly a cup, or 8 ounces, each day) and Colombia (more than three quarters of a cup each day). Fruit juice consumption on average increases with country income level",
                            
                            CategoryId = 51,
                            ImageUrl = "https://images.unsplash.com/photo-1604404894204-03fc8bf2c028?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fGp1aWNlfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60",
                            InStock = true,
                            isPreferredDrink = false,
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1604404894204-03fc8bf2c028?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fGp1aWNlfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60"
                        }


                );


        }


        public DbSet<Drinks> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


    }
}
