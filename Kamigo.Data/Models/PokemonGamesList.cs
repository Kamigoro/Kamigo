using Kamigo.Data.Enums;

namespace Kamigo.Data.Models
{
    public static class PokemonGamesList
    {
        public static List<PokemonGame> Games { get; } = new List<PokemonGame>
        {
            new PokemonGame
            {
                Id = 1,
                Name = "Rouge",
                Generation = 1,
                Region = PokemonRegions.Kanto,
                Description = "Les premiers jeux de la série, où les joueurs explorent la région de Kanto pour devenir le meilleur dresseur de Pokémon et vaincre la Ligue Pokémon.",
                ReleaseDate = new DateTime(1996, 2, 27),
                ImageUrl = "https://www.pokepedia.fr/images/8/8b/Pok%C3%A9mon_Rouge_Recto.png"
            },
            new PokemonGame
            {
                Id = 2,
                Name = "Bleu",
                Generation = 1,
                Region = PokemonRegions.Kanto,
                Description = "Les premiers jeux de la série, où les joueurs explorent la région de Kanto pour devenir le meilleur dresseur de Pokémon et vaincre la Ligue Pokémon.",
                ReleaseDate = new DateTime(1996, 10, 15),
                ImageUrl = "https://www.pokepedia.fr/images/thumb/0/05/Pok%C3%A9mon_Bleu_Recto.png/604px-Pok%C3%A9mon_Bleu_Recto.png?20180629112656"
            },
            new PokemonGame
            {
                Id = 3,
                Name = "Jaune",
                Generation = 1,
                Region = PokemonRegions.Kanto,
                Description = "Une version spéciale basée sur la série animée, dans laquelle les joueurs commencent avec Pikachu comme Pokémon de départ et suivent de près les aventures de Sacha.",
                ReleaseDate = new DateTime(1998, 9, 12),
                ImageUrl = "https://www.pokepedia.fr/images/b/b6/Pok%C3%A9mon_Jaune_Recto.png"
            },
            new PokemonGame
            {
                Id = 4,
                Name = "Or",
                Generation = 2,
                Region = PokemonRegions.Johto,
                Description = "Les jeux introduisent la région de Johto, de nouveaux Pokémon, des fonctionnalités jour/nuit et permettent aux joueurs de retourner à Kanto après avoir vaincu la Ligue Pokémon.",
                ReleaseDate = new DateTime(1999, 11, 21),
                ImageUrl = "https://www.pokepedia.fr/images/7/72/Jaquette_Pok%C3%A9mon_Or.png"
            },
            new PokemonGame
            {
                Id = 5,
                Name = "Argent",
                Generation = 2,
                Region = PokemonRegions.Johto,
                Description = "Les jeux introduisent la région de Johto, de nouveaux Pokémon, des fonctionnalités jour/nuit et permettent aux joueurs de retourner à Kanto après avoir vaincu la Ligue Pokémon.",
                ReleaseDate = new DateTime(1999, 11, 21),
                ImageUrl = "https://www.pokepedia.fr/images/8/80/Jaquette_Pok%C3%A9mon_Argent.png"
            },
            new PokemonGame
            {
                Id = 6,
                Name = "Cristal",
                Generation = 2,
                Region = PokemonRegions.Johto,
                Description = "Une version améliorée d'Or/Argent avec des graphismes et des fonctionnalités supplémentaires.",
                ReleaseDate = new DateTime(2000, 12, 14),
                ImageUrl = "https://www.pokepedia.fr/images/1/13/Pok%C3%A9mon_Cristal_Recto.png"
            },
            new PokemonGame
            {
                Id = 7,
                Name = "Rubis",
                Generation = 3,
                Region = PokemonRegions.Hoenn,
                Description = "Les joueurs explorent la région de Hoenn, affrontent deux organisations maléfiques et découvrent de nouveaux Pokémon, ainsi que le concept de concours de Pokémon.",
                ReleaseDate = new DateTime(2002, 11, 21),
                ImageUrl = "https://www.pokepedia.fr/images/c/c3/Pok%C3%A9mon_Rubis_Recto.png"
            },
            new PokemonGame
            {
                Id = 8,
                Name = "Saphir",
                Generation = 3,
                Region = PokemonRegions.Hoenn,
                Description = "Les joueurs explorent la région de Hoenn, affrontent deux organisations maléfiques et découvrent de nouveaux Pokémon, ainsi que le concept de concours de Pokémon.",
                ReleaseDate = new DateTime(2002, 11, 21),
                ImageUrl = "https://www.pokepedia.fr/images/3/3f/Pok%C3%A9mon_Saphir_Recto.png"
            },
            new PokemonGame
            {
                Id = 9,
                Name = "Emeraude",
                Generation = 3,
                Region = PokemonRegions.Hoenn,
                Description = "Les joueurs explorent la région de Hoenn, affrontent deux organisations maléfiques et découvrent de nouveaux Pokémon, ainsi que le concept de concours de Pokémon.",
                ReleaseDate = new DateTime(2004, 9, 16),
                ImageUrl = "https://www.pokepedia.fr/images/2/24/Pok%C3%A9mon_%C3%89meraude_Recto.png"
            },
            new PokemonGame
            {
                Id = 10,
                Name = "Rouge Feu",
                Generation = 3,
                Region = PokemonRegions.Kanto,
                Description = "Un remake des jeux originaux Rouge/Vert avec des graphismes améliorés et des fonctionnalités modernisées, permettant aux joueurs de revivre l'aventure classique de Kanto et de capturer les 151 Pokémon originaux.",
                ReleaseDate = new DateTime(2004, 1, 29),
                ImageUrl = "https://www.pokepedia.fr/images/f/f0/Pok%C3%A9mon_Rouge_Feu_Recto.png"
            },
            new PokemonGame
            {
                Id = 11,
                Name = "Vert Feuille",
                Generation = 3,
                Region = PokemonRegions.Kanto,
                Description = "Un remake des jeux originaux Rouge/Vert avec des graphismes améliorés et des fonctionnalités modernisées, permettant aux joueurs de revivre l'aventure classique de Kanto et de capturer les 151 Pokémon originaux.",
                ReleaseDate = new DateTime(2004, 1, 29),
                ImageUrl = "https://www.pokepedia.fr/images/2/2c/Pok%C3%A9mon_Vert_Feuille_Recto.png"
            },
            new PokemonGame
            {
                Id = 12,
                Name = "Diamant",
                Generation = 4,
                Region = PokemonRegions.Sinnoh,
                Description = "Les jeux se déroulent dans la région de Sinnoh et introduisent de nouveaux Pokémon, des mécaniques de jeu telles que les concours de Super Concours et le souterrain, ainsi que le système de connectivité en ligne.",
                ReleaseDate = new DateTime(2006, 9, 28),
                ImageUrl = "https://www.pokepedia.fr/images/b/b0/Pok%C3%A9mon_Diamant_Recto.png"
            },
            new PokemonGame
            {
                Id = 13,
                Name = "Perle",
                Generation = 4,
                Region = PokemonRegions.Sinnoh,
                Description = "Les jeux se déroulent dans la région de Sinnoh et introduisent de nouveaux Pokémon, des mécaniques de jeu telles que les concours de Super Concours et le souterrain, ainsi que le système de connectivité en ligne.",
                ReleaseDate = new DateTime(2006, 9, 28),
                ImageUrl = "https://www.pokepedia.fr/images/3/3b/Pok%C3%A9mon_Perle_Recto.png"
            },
            new PokemonGame
            {
                Id = 14,
                Name = "Platine",
                Generation = 4,
                Region = PokemonRegions.Sinnoh,
                Description = "Une version améliorée de Diamant/Perle avec une histoire étendue, de nouvelles fonctionnalités et des ajouts de gameplay tels que la Zone de Combat.",
                ReleaseDate = new DateTime(2008, 9, 13),
                ImageUrl = "https://www.pokepedia.fr/images/f/f8/Pok%C3%A9mon_Platine_Recto.png"
            },
            new PokemonGame
            {
                Id = 15,
                Name = "Or HeartGold",
                Generation = 4,
                Region = PokemonRegions.Johto,
                Description = "Des remakes de Or/Argent pour la Nintendo DS, avec des graphismes améliorés, des fonctionnalités modernes et la possibilité pour le Pokémon de tête de vous suivre.",
                ReleaseDate = new DateTime(2009, 9, 12),
                ImageUrl = "https://www.pokepedia.fr/images/a/a8/Pok%C3%A9mon_Or_HeartGold_Recto.png"
            },
            new PokemonGame
            {
                Id = 16,
                Name = "Argent SoulSilver",
                Generation = 4,
                Region = PokemonRegions.Johto,
                Description = "Des remakes de Or/Argent pour la Nintendo DS, avec des graphismes améliorés, des fonctionnalités modernes et la possibilité pour le Pokémon de tête de vous suivre.",
                ReleaseDate = new DateTime(2009, 9, 12),
                ImageUrl = "https://www.pokepedia.fr/images/8/82/Pok%C3%A9mon_Argent_SoulSilver_Recto.png"
            },
            new PokemonGame
            {
                Id = 17,
                Name = "Noir",
                Generation = 5,
                Region = PokemonRegions.Unys,
                Description = "Les jeux se déroulent dans la région d'Unys et présentent de nouveaux Pokémon, une histoire plus complexe, des combats améliorés et la séparation des Pokémon existants des Pokémon de la région jusqu'à la fin du jeu.",
                ReleaseDate = new DateTime(2010, 9, 18),
                ImageUrl = "https://www.pokepedia.fr/images/c/c8/Pok%C3%A9mon_Noir_Recto.png"
            },
            new PokemonGame
            {
                Id = 18,
                Name = "Blanc",
                Generation = 5,
                Region = PokemonRegions.Unys,
                Description = "Les jeux se déroulent dans la région d'Unys et présentent de nouveaux Pokémon, une histoire plus complexe, des combats améliorés et la séparation des Pokémon existants des Pokémon de la région jusqu'à la fin du jeu.",
                ReleaseDate = new DateTime(2010, 9, 18),
                ImageUrl = "https://www.pokepedia.fr/images/c/c0/Pok%C3%A9mon_Blanc_Recto.png"
            },
            new PokemonGame
            {
                Id = 19,
                Name = "Noir 2",
                Generation = 5,
                Region = PokemonRegions.Unys,
                Description = "Les jeux se déroulent deux ans après Noir/Blanc et offrent une nouvelle histoire, de nouveaux lieux et permettent aux joueurs de revisiter Unys.",
                ReleaseDate = new DateTime(2012, 6, 23),
                ImageUrl = "https://www.pokepedia.fr/images/8/82/Jaquette_de_Pok%C3%A9mon_version_Noire_2.jpeg"
            },
            new PokemonGame
            {
                Id = 20,
                Name = "Blanc 2",
                Generation = 5,
                Region = PokemonRegions.Unys,
                Description = "Les jeux se déroulent deux ans après Noir/Blanc et offrent une nouvelle histoire, de nouveaux lieux et permettent aux joueurs de revisiter Unys.",
                ReleaseDate = new DateTime(2012, 6, 23),
                ImageUrl = "https://www.pokepedia.fr/images/b/b7/Jaquette_de_Pok%C3%A9mon_version_Blanche_2.jpeg"
            },
            new PokemonGame
            {
                Id = 21,
                Name = "X",
                Generation = 6,
                Region = PokemonRegions.Kalos,
                Description = "Les premiers jeux de la série principale en 3D complète, se déroulant dans la région de Kalos, introduisant de nouvelles mécaniques de jeu telles que la Méga-Évolution et le mode de personnalisation du personnage.",
                ReleaseDate = new DateTime(2013, 10, 12),
                ImageUrl = "https://www.pokepedia.fr/images/e/e5/Pok%C3%A9mon_X_-_FR.png"
            },
            new PokemonGame
            {
                Id = 22,
                Name = "Y",
                Generation = 6,
                Region = PokemonRegions.Kalos,
                Description = "Les premiers jeux de la série principale en 3D complète, se déroulant dans la région de Kalos, introduisant de nouvelles mécaniques de jeu telles que la Méga-Évolution et le mode de personnalisation du personnage.",
                ReleaseDate = new DateTime(2013, 10, 12),
                ImageUrl = "https://www.pokepedia.fr/images/9/9b/Pok%C3%A9mon_Y_-_FR.png"
            },
            new PokemonGame
            {
                Id = 23,
                Name = "Rubis Oméga",
                Generation = 6,
                Region = PokemonRegions.Hoenn,
                Description = "Des remakes de Rubis/Saphir pour la Nintendo 3DS, avec des graphismes améliorés, la Méga-Évolution, des fonctionnalités en ligne et une intrigue étendue.",
                ReleaseDate = new DateTime(2014, 11, 21),
                ImageUrl = "https://www.pokepedia.fr/images/6/63/Pok%C3%A9mon_Rubis_Om%C3%A9ga_-_FR.png"
            },
            new PokemonGame
            {
                Id = 24,
                Name = "Saphir Alpha",
                Generation = 6,
                Region = PokemonRegions.Hoenn,
                Description = "Des remakes de Rubis/Saphir pour la Nintendo 3DS, avec des graphismes améliorés, la Méga-Évolution, des fonctionnalités en ligne et une intrigue étendue.",
                ReleaseDate = new DateTime(2014, 11, 21),
                ImageUrl = "https://www.pokepedia.fr/images/c/c0/Pok%C3%A9mon_Saphir_Alpha_-_FR.png"
            },
            new PokemonGame
            {
                Id = 25,
                Name = "Soleil",
                Generation = 7,
                Region = PokemonRegions.Alola,
                Description = "Les jeux se déroulent dans la région d'Alola, proposant de nouvelles formes régionales de Pokémon, les Épreuves d'Alola à la place des arènes, et une histoire centrée sur les légendaires et la Fondation Æther.",
                ReleaseDate = new DateTime(2016, 11, 18),
                ImageUrl = "https://www.pokepedia.fr/images/4/40/Pok%C3%A9mon_Soleil_-_FR.png"
            },
            new PokemonGame
            {
                Id = 26,
                Name = "Lune",
                Generation = 7,
                Region = PokemonRegions.Alola,
                Description = "Les jeux se déroulent dans la région d'Alola, proposant de nouvelles formes régionales de Pokémon, les Épreuves d'Alola à la place des arènes, et une histoire centrée sur les légendaires et la Fondation Æther.",
                ReleaseDate = new DateTime(2016, 11, 18),
                ImageUrl = "https://www.pokepedia.fr/images/0/0e/Pok%C3%A9mon_Lune_-_FR.png"
            },
            new PokemonGame
            {
                Id = 27,
                Name = "Ultra-Soleil",
                Generation = 7,
                Region = PokemonRegions.Alola,
                Description = "Des versions améliorées de Soleil/Lune avec une histoire alternative, de nouveaux Pokémon légendaires et la possibilité de voyager dans l'Ultra-Dimension.",
                ReleaseDate = new DateTime(2017, 11, 17),
                ImageUrl = "https://www.pokepedia.fr/images/6/6b/Jaquette_de_Pok%C3%A9mon_Ultra-Soleil.jpg"
            },
            new PokemonGame
            {
                Id = 28,
                Name = "Ultra-Lune",
                Generation = 7,
                Region = PokemonRegions.Alola,
                Description = "Des versions améliorées de Soleil/Lune avec une histoire alternative, de nouveaux Pokémon légendaires et la possibilité de voyager dans l'Ultra-Dimension.",
                ReleaseDate = new DateTime(2017, 11, 17),
                ImageUrl = "https://www.pokepedia.fr/images/c/c6/Jaquette_de_Pok%C3%A9mon_Ultra-Lune.jpg"
            },
            new PokemonGame
            {
                Id = 29,
                Name = "Let's Go Pikachu",
                Generation = 7,
                Region = PokemonRegions.Kanto,
                Description = "Ces jeux sont des remakes modernisés du jeu Pokémon Jaune, conçus pour la console Nintendo Switch.",
                ReleaseDate = new DateTime(2018, 11, 16),
                ImageUrl = "https://www.pokepedia.fr/images/b/bd/Jaquette_de_Pok%C3%A9mon_Let%27s_Go_Pikachu.png"
            },
            new PokemonGame
            {
                Id = 30,
                Name = "Let's Go Evoli",
                Generation = 7,
                Region = PokemonRegions.Kanto,
                Description = "Ces jeux sont des remakes modernisés du jeu Pokémon Jaune, conçus pour la console Nintendo Switch.",
                ReleaseDate = new DateTime(2018, 11, 16),
                ImageUrl = "https://www.pokepedia.fr/images/1/16/Jaquette_de_Pok%C3%A9mon_Let%27s_Go_%C3%89voli.png"
            },
            new PokemonGame
            {
                Id = 31,
                Name = "Epée",
                Generation = 8,
                Region = PokemonRegions.Galar,
                Description = "Les jeux se déroulent dans la région de Galar, inspirée du Royaume-Uni, avec de nouveaux Pokémon, des raids Dynamax, des combats en ligne et l'introduction du phénomène Gigamax.",
                ReleaseDate = new DateTime(2019, 11, 15),
                ImageUrl = "https://www.pokepedia.fr/images/6/61/Jaquette_de_Pok%C3%A9mon_%C3%89p%C3%A9e.png"
            },
            new PokemonGame
            {
                Id = 32,
                Name = "Bouclier",
                Generation = 8,
                Region = PokemonRegions.Galar,
                Description = "Les jeux se déroulent dans la région de Galar, inspirée du Royaume-Uni, avec de nouveaux Pokémon, des raids Dynamax, des combats en ligne et l'introduction du phénomène Gigamax.",
                ReleaseDate = new DateTime(2019, 11, 15),
                ImageUrl = "https://www.pokepedia.fr/images/e/ee/Jaquette_de_Pok%C3%A9mon_Bouclier.png"
            },
            new PokemonGame
            {
                Id = 33,
                Name = "Diamant Étincelant",
                Generation = 8,
                Region = PokemonRegions.Sinnoh,

                Description = "Des remakes de Diamant/Perle pour la Nintendo Switch, avec des graphismes remaniés, des mécaniques de jeu modernisées et des fonctionnalités en ligne.",
                ReleaseDate = new DateTime(2021, 11, 19),
                ImageUrl = "https://www.pokepedia.fr/images/8/8e/Jaquette_de_Pok%C3%A9mon_Diamant_%C3%89tincelant.png"
            },
            new PokemonGame
            {
                Id = 34,
                Name = "Perle Scintillante",
                Generation = 8,
                Region = PokemonRegions.Sinnoh,
                Description = "Des remakes de Diamant/Perle pour la Nintendo Switch, avec des graphismes remaniés, des mécaniques de jeu modernisées et des fonctionnalités en ligne.",
                ReleaseDate = new DateTime(2021, 11, 19),
                ImageUrl = "https://www.pokepedia.fr/images/6/69/Jaquette_de_Pok%C3%A9mon_Perle_Scintillante.png"
            },
            new PokemonGame
            {
                Id = 35,
                Name = "Légendes Arceus",
                Generation = 8,
                Region = PokemonRegions.Hisui,
                Description = "Un jeu d'action-aventure en monde ouvert situé dans la région de Sinnoh antique, où les joueurs deviennent des chercheurs de Pokémon et contribuent à la création du premier Pokédex.",
                ReleaseDate = new DateTime(2022, 01, 28),
                ImageUrl = "https://www.pokepedia.fr/images/0/02/Jaquette_de_L%C3%A9gendes_Pok%C3%A9mon_Arceus.png"
            },
            new PokemonGame
            {
                Id = 36,
                Name = "Ecarlate",
                Generation = 9,
                Region = PokemonRegions.Paldea,
                Description = "L'histoire se déroule dans la région de Paldea, inspiré de l'Espagne et du Portugal. Le joueur incarne un élève de l'Académie Raisin ou Orange dont l'objectif est d'explorer la région et trouver son propre trésor.",
                ReleaseDate = new DateTime(2022, 11, 18),
                ImageUrl = "https://www.pokepedia.fr/images/d/dc/Jaquette_de_Pok%C3%A9mon_%C3%89carlate.png"
            },
            new PokemonGame
            {
                Id = 37,
                Name = "Violet",
                Generation = 9,
                Region = PokemonRegions.Paldea,
                Description = "L'histoire se déroule dans la région de Paldea, inspiré de l'Espagne et du Portugal. Le joueur incarne un élève de l'Académie Raisin ou Orange dont l'objectif est d'explorer la région et trouver son propre trésor.",
                ReleaseDate = new DateTime(2022, 11, 18),
                ImageUrl = "https://www.pokepedia.fr/images/1/12/Jaquette_de_Pok%C3%A9mon_Violet.png"
            }
        };
    }
}
