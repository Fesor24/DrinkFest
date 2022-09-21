using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinkFest.Migrations
{
    public partial class _editDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 10,
                column: "ShortDescription",
                value: "The most widely consumed alcohol and the third most popular drink overall after water and tea");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 20,
                column: "LongDescription",
                value: "Iced tea (or ice tea[1]) is a form of cold tea. Though it is usually served in a glass with ice, it can refer to any tea that has been chilled or cooled. It may be sweetened with sugar or syrup. Iced tea is also a popular packaged drink which can be mixed with flavored syrup such as lemon, raspberry, lime, passion fruit, peach, orange, strawberry, and cherry");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 21,
                column: "LongDescription",
                value: "Vodka (Polish: wódka [ˈvutka], Russian: водка [ˈvotkə], Swedish: vodka [vɔdkɑː]) is a clear distilled alcoholic beverage. Different varieties originated in Poland, Russia, and Sweden.[1][2] Vodka is composed mainly of water and ethanol but sometimes with traces of impurities and flavourings.[3] Traditionally, it is made by distilling liquid from fermented cereal grains, and potatoes since introduced in Europe in the 1700's. Some modern brands use fruits, honey, or maple sap as the base");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 22,
                column: "LongDescription",
                value: "A gin and tonic is a highball cocktail made with gin and tonic water poured over a large amount of ice.[1] The ratio of gin to tonic varies according to taste, strength of the gin, other drink mixers being added, etc., with most recipes calling for a ratio between 1:1 and 1:3. It is usually garnished with a slice or wedge of lime. To preserve effervescence, the tonic can be poured down a bar spoon.[2] The ice cools the gin, dulling the effect of the alcohol in the mouth and making the drink more pleasant and refreshing to taste");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 24,
                column: "LongDescription",
                value: "Tea is an aromatic beverage prepared by pouring hot or boiling water over cured or fresh leaves of Camellia sinensis, an evergreen shrub native to East Asia which probably originated in the borderlands of southwestern China and northern Burma.[3][4][5] Tea is also rarely made from the leaves of Camellia taliensis.[6][7][8] After plain water, it is the most widely consumed drink in the world.[9] There are many different types of tea; some have a cooling, slightly bitter, and astringent flavour,[10] while others have vastly different profiles that include sweet, nutty, floral, or grassy notes. Tea has a stimulating effect in humans primarily due to its caffeine content");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 25,
                column: "LongDescription",
                value: "Water (chemical formula H2O) is an inorganic, transparent, tasteless, odorless, and nearly colorless chemical substance, which is the main constituent of Earth's hydrosphere and the fluids of all known living organisms (in which it acts as a solvent[1]). It is vital for all known forms of life, despite providing neither food, energy, nor organic micronutrients. Its chemical formula, H2O, indicates that each of its molecules contains one oxygen and two hydrogen atoms, connected by covalent bonds. The hydrogen atoms are attached to the oxygen atom at an angle of 104.45°.[2] Water is also the name of the liquid state of H2O at standard temperature and pressure.");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 26,
                column: "LongDescription",
                value: "Coffee is a drink prepared from roasted coffee beans, seeds of the Coffea plant species. Darkly colored, bitter, and slightly acidic, coffee has a stimulating effect on humans, primarily due to its caffeine content, and is one of the most popular drinks in the world.From the coffee fruit,the seeds are separated to produce unroasted green coffee beans.The beans are roasted and then ground into fine particles that are typically steeped in hot water before being filtered out,producing a cup of coffee.It is usually served hot, although chilled or iced coffee is common.Coffee can be prepared and presented in a variety of ways(e.g., espresso, French press, caffè latte, or already - brewed canned coffee).Sugar,sugar substitutes,milk,and cream are often used to lessen the bitter taste or enhance the flavor. Though coffee is now a global commodity, it has a long history tied closely to food traditions around the Red Sea.The earliest credible evidence of coffee drinking in the form of the modern beverage appears in modern - day Yemen from the mid-15th century in Sufi shrines, where coffee seeds were first roasted and brewed in a manner similar to current methods.The Yemenis procured the coffee beans from the Ethiopian Highlands via coastal Somali intermediaries and began cultivation.By the 16th century,the drink had reached the rest of the Middle East and North Africa, later spreading to Europe.In the 20th century, coffee became a global commodity, creating different coffee cultures around the world.");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 27,
                columns: new[] { "LongDescription", "ShortDescription" },
                values: new object[] { "Kvass is a fermented cereal-based low alcoholic beverage with a slightly cloudy appearance, light-brown colour and sweet-sour taste. It may be flavoured with berries, fruits, herbs or honey.Kvass stems from the northeastern part of Europe,where the grain production is thought to have been insufficient for beer to become a daily drink.The first written mention of kvass is found in the Primary Chronicle, describing the celebration of Vladimir the Great's baptism in 996. In the traditional method, kvass is made from a mash obtained from rye bread or rye flour and malt soaked in hot water, fermented for about 12 hours with the help of sugar and bread yeast or baker's yeast at a room temperature.In industrial methods, kvass is produced from wort concentrate combined with various grain mixtures.It is a popular drink in Russia, Ukraine, Poland, Baltic countries, Finland and some parts of China.", "Kvass is a fermented cereal-based low alcoholic beverage with a slightly cloudy appearance, light-brown colour and sweet-sour taste" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 28,
                columns: new[] { "LongDescription", "ShortDescription" },
                values: new object[] { "Juice is a drink made from the extraction or pressing of the natural liquid contained in fruit and vegetables. It can also refer to liquids that are flavored with concentrate or other biological food sources, such as meat or seafood, such as clam juice. Juice is commonly consumed as a beverage or used as an ingredient or flavoring in foods or other beverages, as for smoothies. Juice emerged as a popular beverage choice after the development of pasteurization methods enabled its preservation without using fermentation (which is used in wine production).[1] The largest fruit juice consumers are New Zealand (nearly a cup, or 8 ounces, each day) and Colombia (more than three quarters of a cup each day). Fruit juice consumption on average increases with country income level", "Naturally contained in fruit or vegetable tissue. The liquid obtained from fruit or vegetables." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 10,
                column: "ShortDescription",
                value: "The most widely consumed alcohol");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 20,
                column: "LongDescription",
                value: "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 21,
                column: "LongDescription",
                value: "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 22,
                column: "LongDescription",
                value: "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 24,
                column: "LongDescription",
                value: "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 25,
                column: "LongDescription",
                value: "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 26,
                column: "LongDescription",
                value: "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 27,
                columns: new[] { "LongDescription", "ShortDescription" },
                values: new object[] { "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "A very refreshing Russian beverage" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 28,
                columns: new[] { "LongDescription", "ShortDescription" },
                values: new object[] { "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Naturally contained in fruit or vegetable tissue." });
        }
    }
}
