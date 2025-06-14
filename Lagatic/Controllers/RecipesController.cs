using Lagatic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lagatic.Controllers
{ 
 
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {
        private static readonly List<Recipe> Recipes = new()
        {
           new Recipe
{
    Id = 1,
    Title = "Chicken Teriyaki",
    ImageUrl = "https://www.onceuponachef.com/images/2024/01/chicken-teriyaki.jpg",
    Steps = new List<string>
    {
        "Mix soy sauce, mirin, sake, and sugar to make teriyaki sauce.",
        "Pan-fry chicken until golden brown.",
        "Add sauce and simmer until thick and glossy.",
        "Serve with steamed rice and vegetables."
    }
},
new Recipe
{
    Id = 2,
    Title = "Tonkotsu Ramen",
    ImageUrl = "https://www.craftycookbook.com/wp-content/uploads/2023/04/tonkotsu.jpg",
    Steps = new List<string>
    {
        "Boil pork bones for several hours to create broth.",
        "Prepare ramen noodles separately.",
        "Add chashu pork, boiled egg, and toppings.",
        "Pour hot broth over noodles and serve."
    }
},
new Recipe
{
    Id = 3,
    Title = "Sushi Rolls (Maki)",
    ImageUrl = "https://cdn.media.amplience.net/i/japancentre/guide-page-sushi-79-maki-sushi/Maki-sushi-rolls?$poi$&w=700&h=410&sm=c&fmt=auto",
    Steps = new List<string>
    {
        "Lay nori on bamboo mat and spread sushi rice.",
        "Add fillings like fish, cucumber, or avocado.",
        "Roll tightly and slice into pieces.",
        "Serve with soy sauce and wasabi."
    }
},
new Recipe
{
    Id = 4,
    Title = "Tempura",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2e/Tempura_01.jpg/1200px-Tempura_01.jpg",
    Steps = new List<string>
    {
        "Mix tempura batter with cold water.",
        "Dip shrimp and vegetables into batter.",
        "Deep fry until golden and crispy.",
        "Serve with tempura dipping sauce."
    }
},
new Recipe
{
    Id = 5,
    Title = "Okonomiyaki",
    ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/30/2022/01/Okonomiyaki-pg13-363c802-03b59be.jpg?resize=768,713",
    Steps = new List<string>
    {
        "Mix shredded cabbage, flour, egg, and toppings.",
        "Pour batter on a hot griddle and cook both sides.",
        "Top with okonomiyaki sauce, mayo, bonito flakes.",
        "Serve hot from the pan."
    }
},
new Recipe
{
    Id = 6,
    Title = "Katsu Curry",
    ImageUrl = "https://japan.recipetineats.com/wp-content/uploads/2021/12/Katsu_Curry_7011bsq-500x500.jpg",
    Steps = new List<string>
    {
        "Coat pork cutlet in flour, egg, and breadcrumbs.",
        "Fry until golden and slice.",
        "Cook Japanese curry with potatoes and carrots.",
        "Serve cutlet over rice with curry sauce."
    }
},
new Recipe
{
    Id = 7,
    Title = "Gyudon",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/Gyuu-don_001.jpg/960px-Gyuu-don_001.jpg",
    Steps = new List<string>
    {
        "Slice beef thinly and cook with onions.",
        "Add dashi, soy sauce, mirin, and sugar.",
        "Simmer until beef is tender.",
        "Serve over hot rice with pickled ginger."
    }
},
new Recipe
{
    Id = 8,
    Title = "Miso Soup",
    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7KCdXRzaKj6N4g0hxVzkVgeIH0nTc9XvABw&s",
    Steps = new List<string>
    {
        "Boil dashi broth and add tofu and wakame.",
        "Dissolve miso paste into the broth.",
        "Garnish with green onions.",
        "Serve warm as a side dish."
    }
},
new Recipe
{
    Id = 9,
    Title = "Tamagoyaki",
    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQo-QSRnXloyJvV5FIRHV6G5aP_G2GUqOeVlA&s",
    Steps = new List<string>
    {
        "Mix eggs with mirin, sugar, and soy sauce.",
        "Pour thin layers into a rectangular pan.",
        "Roll each layer as it cooks.",
        "Slice and serve with rice or in bento."
    }
},
new Recipe
{
    Id = 10,
    Title = "Onigiri",
    ImageUrl = "https://int.japanesetaste.com/cdn/shop/articles/how-to-make-onigiri-at-home-5-filling-ideas-japanese-taste.webp?v=1737982111&width=5760",
    Steps = new List<string>
    {
        "Shape cooked rice into triangles or balls.",
        "Add filling like umeboshi, tuna, or salmon.",
        "Wrap with a strip of nori.",
        "Serve as a snack or light meal."
    }
},
new Recipe
{
    Id = 11,
    Title = "Yakisoba",
    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYh5TzZWX9u5YF_w3gTguzVjBXEX_whW0Tzg&s",
    Steps = new List<string>
    {
        "Sauté sliced pork and vegetables.",
        "Add yakisoba noodles and sauce.",
        "Stir-fry until well mixed and heated.",
        "Garnish with pickled ginger and aonori."
    }
},
new Recipe
{
    Id = 12,
    Title = "Gyoza",
    ImageUrl = "https://assets.epicurious.com/photos/628ba0d3fa016bab2139efa2/1:1/w_4546,h_4546,c_limit/Gyoza_RECIPE_051922_34332.jpg",
    Steps = new List<string>
    {
        "Mix ground pork, cabbage, and seasonings.",
        "Fill dumpling wrappers and seal edges.",
        "Pan-fry until bottom is crispy, then steam.",
        "Serve with dipping sauce."
    }
},
new Recipe
{
    Id = 13,
    Title = "Shabu-Shabu",
    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTy8iRmnadbXlU_xMyUpPey4acSdxP1dEZGrQ&s",
    Steps = new List<string>
    {
        "Boil dashi in a pot.",
        "Dip thinly sliced meat and vegetables briefly.",
        "Cook to desired doneness.",
        "Dip in sauces and enjoy."
    }
},
new Recipe
{
    Id = 14,
    Title = "Takoyaki",
    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1FEhKxdiyCrnGZlVDVd3lZZDyfNAUYjSKig&s",
    Steps = new List<string>
    {
        "Pour batter into takoyaki pan.",
        "Add diced octopus, green onions, and tempura bits.",
        "Turn until balls are round and golden.",
        "Serve with sauce, mayo, and bonito flakes."
    }
},
new Recipe
{
    Id = 15,
    Title = "Oyakodon",
    ImageUrl = "https://takestwoeggs.com/wp-content/uploads/2023/12/Oyakodon-Japanese-Chicken-and-Egg-Rice-Bowl-takestwoeggs-1-500x375.jpg",
    Steps = new List<string>
    {
        "Cook chicken and onions in soy-mirin sauce.",
        "Pour beaten eggs and cover until soft set.",
        "Serve over a bowl of steamed rice.",
        "Top with green onions."
    }
},
new Recipe
{
    Id = 16,
    Title = "Matcha Mochi",
    ImageUrl = "https://zhangcatherine.com/wp-content/uploads/2023/04/12001200-1.jpg",
    Steps = new List<string>
    {
        "Mix glutinous rice flour, sugar, and matcha.",
        "Steam or microwave until sticky.",
        "Dust with cornstarch and shape into balls.",
        "Serve as a dessert."
    }
}

        };

        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> GetRecipes()
        {
            return Ok(Recipes);
        }
    }
}