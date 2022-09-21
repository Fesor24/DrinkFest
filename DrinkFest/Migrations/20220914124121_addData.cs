using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrinkFest.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Drinks",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,4)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 50, "Alcoholic", "All alcoholic drinks" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 51, "Non-alcoholic", "All non-alcoholic drinks" });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "DrinkId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription", "isPreferredDrink" },
                values: new object[,]
                {
                    { 10, 50, "https://images.unsplash.com/photo-1596115246571-598a16e725ad?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTh8fGJlZXJ8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1621428674699-90ec7bae03c9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8YmVlcnxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", true, "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.", "Beer", 7.95m, "The most widely consumed alcohol", true },
                    { 11, 50, "https://images.unsplash.com/photo-1639834482101-5f332c3b701f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fHJ1bSUyMGFuZCUyMGNva2V8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1514218953589-2d7d37efd2dc?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cnVtJTIwYW5kJTIwY29rZXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", true, "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.", "Rum & Coke", 12.95m, "Cocktail made of cola, lime and rum.", false },
                    { 12, 50, "https://images.unsplash.com/photo-1612906515356-7792f4ee2cb4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8dGVxdWlsYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1662488025059-7f144bcbd2a9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8dGVxdWlsYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", true, "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.", "Tequila ", 12.95m, "Beverage made from the blue agave plant.", false },
                    { 13, 50, "https://images.unsplash.com/photo-1584193674275-5277f8ff83c9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8d2luZXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1569919659476-f0852f6834b7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTV8fHdpbmV8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", true, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Wine ", 9.75m, "A very elegant alcoholic drink", false },
                    { 14, 50, "https://images.unsplash.com/photo-1603833971780-1a096342a9dd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8bWFyZ2FyaXRhfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1631503190221-0f6a15367926?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NXx8bWFyZ2FyaXRhfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60", true, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Margarita", 17.95m, "A cocktail with sec, tequila and lime", false },
                    { 15, 50, "https://images.unsplash.com/photo-1638990742994-c96e4f7617fe?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fHdoaXNrZXl8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1526383103106-edad26ae7572?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8d2hpc2tleXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", false, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Whiskey with Ice", 7.95m, "The best way to taste whiskey", false },
                    { 16, 50, "https://images.unsplash.com/photo-1638957773782-f9614ba79d81?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fGFsY29ob2x8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1638957773782-f9614ba79d81?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fGFsY29ob2x8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", false, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Jägermeister", 10.25m, "A German digestif made with 56 herbs", false },
                    { 17, 50, "https://images.unsplash.com/photo-1525373612132-b3e820b87cea?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Y2hhbXBhZ25lfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1590590570140-53c8efaf9d54?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8Y2hhbXBhZ25lfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60", false, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Champagne", 15.95m, "That is how sparkling wine can be called", false },
                    { 18, 50, "https://images.unsplash.com/photo-1613590759244-177bdd273ab0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cGluYSUyMGNvbGFkYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1613590759244-177bdd273ab0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cGluYSUyMGNvbGFkYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", false, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Piña colada ", 5.95m, "A sweet cocktail made with rum.", false },
                    { 19, 50, "https://images.unsplash.com/photo-1639328238537-d370d62cb60c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjZ8fGFsY29ob2x8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1639328238537-d370d62cb60c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjZ8fGFsY29ob2x8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", false, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "White Russian", 15.95m, "A cocktail made with vodka ", false },
                    { 20, 50, "https://images.unsplash.com/photo-1632789395770-20e6f63be806?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8aWNlZCUyMHRlYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1632789395770-20e6f63be806?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8aWNlZCUyMHRlYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", false, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Long Island Iced Tea", 20.50m, "Aa mixed drink made with tequila.", false },
                    { 21, 50, "https://images.unsplash.com/photo-1644902617099-1ee60442ff09?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8dm9ka2F8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1644902617099-1ee60442ff09?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8dm9ka2F8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", false, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Vodka", 8.50m, "A distilled beverage with water and ethanol.", false },
                    { 22, 50, "https://images.unsplash.com/photo-1661200808125-da519f663ede?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8Z2lufGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1661200808125-da519f663ede?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8Z2lufGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60", false, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Gin and tonic", 10.30m, "Made with gin and tonic water poured over ice.", false },
                    { 23, 50, "https://images.unsplash.com/photo-1598373187432-c1ff06874ce8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjB8fGNvc21vcG9saXRhbiUyMGNvY2t0YWlsfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1598373187432-c1ff06874ce8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjB8fGNvc21vcG9saXRhbiUyMGNvY2t0YWlsfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60", false, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Cosmopolitan", 5.95m, "Made with vodka, triple sec, cranberry juice.", false },
                    { 24, 51, "https://images.unsplash.com/photo-1502302800694-ff6ec595e6e3?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fHRlYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1502302800694-ff6ec595e6e3?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fHRlYXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", true, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Tea ", 14.95m, "Made by leaves of the tea plant in hot water.", true },
                    { 25, 51, "https://images.unsplash.com/photo-1516888892881-aad840c56db2?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8d2F0ZXJ8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1516888892881-aad840c56db2?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8d2F0ZXJ8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", true, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Water ", 5.20m, " It makes up more than half of your body weight ", false },
                    { 26, 51, "https://images.unsplash.com/photo-1535403318185-d612e6b1dc3c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fGNvZmZlZXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1535403318185-d612e6b1dc3c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fGNvZmZlZXxlbnwwfDJ8MHx8&auto=format&fit=crop&w=500&q=60", true, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Coffee ", 7.55m, " A beverage prepared from coffee beans", true },
                    { 27, 51, "https://images.unsplash.com/photo-1627828094935-5a73a17affd0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8YmV2ZXJhZ2V8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1627828094935-5a73a17affd0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OHx8YmV2ZXJhZ2V8ZW58MHwyfDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60", true, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Kvass", 8.95m, "A very refreshing Russian beverage", false },
                    { 28, 51, "https://images.unsplash.com/photo-1604404894204-03fc8bf2c028?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fGp1aWNlfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1604404894204-03fc8bf2c028?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fGp1aWNlfGVufDB8MnwwfHw%3D&auto=format&fit=crop&w=500&q=60", true, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Juice ", 12.50m, "Naturally contained in fruit or vegetable tissue.", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "DrinkId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 51);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Drinks",
                type: "decimal(4,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
