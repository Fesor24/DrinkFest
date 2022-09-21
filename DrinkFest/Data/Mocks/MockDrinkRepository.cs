using DrinkFest.Models;
using DrinkFest.Data.Interface;

namespace DrinkFest.Data.Mocks
{
    public class MockDrinkRepository : IDrinkRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Drinks> Drinks
        {
            get
            {
                return new List<Drinks>
                {
                    new Drinks
                    {
                        Name = "Beer",
                        Price = 9.90M,
                        ShortDescription = "The most widely consumed alcohol",
                        LongDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; It is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grais-most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings auch as herbs or fruit may occasionally be included. The fermentation process caused a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://unsplash.com/photos/sUhMjrynw5k",
                        InStock = true,
                        isPreferredDrink = true,
                        ImageThumbnailUrl = "https://images.unsplash.com/photo-1621428674699-90ec7bae03c9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8YmVlcnxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60"

                    },

                    new Drinks
                    {
                        Name = "Rum & Coke",
                        Price = 5.90M,
                        ShortDescription = "Cocktail made of cola, lime and rum",
                        LongDescription = " This is a highball cocktail consisting of cola, rum, and in many recipes lime juice on ice. Traditionally, the cola ingredient is Coca-Cola ('Coke') and the alcohol is a light rum such as Bacardi; however, the drink may be made with various types of rums and cola brands, and lime juice may or may not be included.The cocktail originated in the early 20th century in Cuba, after the country won independence in the Spanish–American War. It subsequently became popular across Cuba, the United States, and other countries. Its simple recipe and inexpensive, ubiquitous ingredients have made it one of the world's most-popular alcoholic drinks. Drink critics often consider the drink mediocre, but it has been noted for its historical significance.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://unsplash.com/photos/nWCmjC7dmdo",
                        InStock = true,
                        isPreferredDrink = false,
                        ImageThumbnailUrl = "https://images.unsplash.com/photo-1614313511387-1436a4480ebb?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cnVtfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60"
                    },
                    new Drinks
                    {
                        Name = "Tequila",
                        Price = 13.35M,
                        ShortDescription = "Beverage made from the blue agave plant.",
                        LongDescription = "This is a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila 65 km (40 mi) northwest of Guadalajara, and in the Jaliscan Highlands (Los Altos de Jalisco) of the central western Mexican state of Jalisco.The red volcanic soils in the region of Tequila are well suited for growing the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave grows differently depending on the region.Blue agaves grown in the highlands Los Altos region are larger and sweeter in aroma and taste.Agaves harvested in the valley region have a more herbaceous fragrance and flavor.[2] Due to its historical and cultural importance, the region near Tequila was declared a UNESCO World Heritage Site in 2006, the Agave Landscape and Ancient Industrial Facilities of Tequila.Mexican laws state that tequila can only be produced in the state of Jalisco and limited municipalities in the states of Guanajuato, Michoacán, Nayarit, and Tamaulipas.[3] Tequila is recognized as a Mexican designation of origin product in more than 40 countries.[4] It was protected through NAFTA in Canada and the United States until July 2020,[5] through bilateral agreements with individual countries such as Japan and Israel,[5] and has been a protected designation of origin product in the European Union since 1997.[5]Aside from its geographical distinction, tequila is differentiated from mezcal in that it is made only from blue agave and the beverages are prepared in different ways.[6] Tequila is commonly served neat in Mexico and as a shot with salt and lime around the world.Tequila must have between 35 and 55 percent alcohol content (70 and 110 U.S.proof).[7]",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://unsplash.com/photos/rnqkBYVpKCI",
                        InStock = true,
                        isPreferredDrink = false,
                        ImageThumbnailUrl = "https://images.unsplash.com/photo-1662488025059-7f144bcbd2a9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8dGVxdWlsYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60"
                    },
                    new Drinks
                    {
                        Name = "Juice",
                        Price = 10.35M,
                        ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                        LongDescription = "Juice is a drink made from the extraction or pressing of the natural liquid contained in fruit and vegetables. It can also refer to liquids that are flavored with concentrate or other biological food sources, such as meat or seafood, such as clam juice. Juice is commonly consumed as a beverage or used as an ingredient or flavoring in foods or other beverages, as for smoothies. Juice emerged as a popular beverage choice after the development of pasteurization methods enabled its preservation without using fermentation (which is used in wine production).[1] The largest fruit juice consumers are New Zealand (nearly a cup, or 8 ounces, each day) and Colombia (more than three quarters of a cup each day). Fruit juice consumption on average increases with country income level.[2]",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://unsplash.com/photos/3hosp69ovU8",
                        InStock = true,
                        isPreferredDrink = false,
                        ImageThumbnailUrl = "https://images.unsplash.com/photo-1570863942420-2b78230e45ee?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8anVpY2V8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60"
                    }
                };
            }

        }
            //set => throw new NotImplementedException(); }
        public IEnumerable<Drinks> PreferredDrinks { get => throw new NotImplementedException();/* set => throw new NotImplementedException();*/ }

        public Drinks GetDrinkById(int drinkId)
        {
            throw new NotImplementedException();
        }
    }
}
