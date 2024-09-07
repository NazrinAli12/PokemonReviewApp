using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }
        public void SeedDataContext()
        {
            if (!_context.PokemonOwners.Any())
            {
                var pokemonOwners = new List<PokemonOwner>()
                {
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Pikachu",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories  = new List<PokemonCategory>()
                            {
                                new PokemonCategory {Category = new Category() { Name = "Electric"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review {Title = "Pikachu", Text="Pikachu is the best pokemon, because it is electric." , Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Nazrin", LastName = "Aliyeva" } },

                                new Review {Title = "Pikachu", Text="Pikachu is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName="Sefa", LastName="Mikayilova" }},

                                new Review {Title = "Pikachu", Text = "Pikachu, pikachu, pikachu", Rating = 1,
                                Reviewer = new Reviewer(){FirstName = "Sabir", LastName = "Guliyev" } }
                            }

                        },
                        Owner = new Owner()
                        {
                            FirstName = "Jack",
                            LastName = "London",
                            Gym = "Brocks Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Squirtle",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category{Name = "Water"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review{Title = "Squirtle", Text = "Squirtle is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Swift"}},

                                new Review{Title = "Squirtle", Text = "Squirtle is the best a killing rocks",Rating = 5,
                                Reviewer = new Reviewer(){FirstName="Mendes", LastName="Mendes"}},

                                new Review{Title= "Squirtle", Text = "squirtle,squirtle,squirtle,squirtle", Rating=5,
                                Reviewer = new Reviewer(){FirstName="Camila", LastName="Cabello"}}
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Jennifer",
                            LastName = "Lopez",
                            Gym = "Mistys Gym",
                            Country = new Country()
                            {
                                Name = "Saffron City"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Venasuar",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory{Category = new Category{Name = "Leaf"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review{Title = "Veasaur", Text = "Veasaur is the best pokemon, because it is electric.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName="Charlie", LastName="Puth"}},

                                new Review{Title = "Veasaur", Text= "Veasauris the best a killing rocks", Rating=5,
                                Reviewer = new Reviewer(){ FirstName="Dua", LastName="Lipa" }},

                                new Review{Title = "Veasaur", Text="veasaur, veasaur, veasaur", Rating=1,
                                Reviewer=new Reviewer(){FirstName="Katy", LastName="Perry" }}
                                
                            }

                        },
                        Owner = new Owner()
                        {
                            FirstName="Ash",
                            LastName="Ketchum",
                            Gym="Ashs Gym",
                            Country = new Country()
                            {
                                Name="Millet Town"
                            }
                        }
                    }
                };
                _context.PokemonOwners.AddRange(pokemonOwners);
                _context.SaveChanges();
            }
        }
    }
}
