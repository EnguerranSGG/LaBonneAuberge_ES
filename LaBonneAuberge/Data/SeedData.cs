using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LaBonneAuberge.Models;
using LaBonneAuberge.Data;
namespace LaBonneAuberge.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LaBonneAubergeContext(
                serviceProvider.GetRequiredService<DbContextOptions<LaBonneAubergeContext>>()))
            {
                context.Database.EnsureCreated();
                if (context.Menus.Any())
                {
                    return; // DB has been seeded
                }

                /*var users = new AspNetUsers[]
                {
                    new AspNetUsers { Id = "8aed5fd1-f09c-4cf3-b8a7-d5e44f058638", UserName = "george@admin.fr", NormalizedUserName = "GEORGE@ADMIN.FR", Email = "george@admin.fr", NormalizedEmail = "GEORGE@ADMIN.FR", EmailConfirmed= true, PasswordHash = "AQAAAAIAAYagAAAAEBTwUIoCDARQCWMTp2AihQGANLthCPMFQ8Dcnw5Z7Rk4YgExhLyt60BEX2gjjTC9ZA==", SecurityStamp="GXYR3E64DLSVMBBCFP3EPCJ2DUUZITBM", ConcurrencyStamp="1cba2b8d-2e95-46d4-879a-69c3f03e7468", LockoutEnd="1"},
                };
                
                foreach (AspNetUsers u in users)
                {
                    context.AspNetUsers.Add(u);
                }
                context.SaveChanges();*/

                var categories = new Category[]
                {
                    new Category { Id = 1, Nom = "Entrées" },
                    new Category { Id = 2, Nom = "Plats Principaux" },
                    new Category { Id = 3, Nom = "Desserts" },
                    new Category { Id = 4, Nom = "Boissons sans Alcool" },
                    new Category { Id = 5, Nom = "Cocktails" },
                };

                foreach (Category c in categories)
                {
                    context.Categories.Add(c);
                }
                context.SaveChanges();

                var menus = new Menu[]
        {
    new Menu { Id = 1, Name = "Filet Mignon", Description = "Un morceau tendre et juteux de filet mignon de bœuf, grillé à la perfection.", Price = 35.99M, CategoryId = 2, Img = "filet mignon-min.jpeg" },
    new Menu { Id = 2, Name = "Côte de Porc Glacée au Miel", Description = "Côtes de porc épaisses cuites lentement et glacées avec une sauce au miel délicieusement sucrée.", Price = 28.50M, CategoryId = 2, Img = "cotedeporc-min.jpg" },
    new Menu { Id = 3, Name = "Assiette Mixte Grillée", Description = "Une sélection de viandes grillées comprenant du bœuf, de l'agneau et du poulet, servie avec des légumes grillés.", Price = 42.75M, CategoryId = 2, Img = "Assiette Mixte grillée-min.jpg" },
    new Menu { Id = 4, Name = "Steak au Poivre", Description = "Un steak savoureux recouvert d'une sauce au poivre noir, accompagné de pommes de terre rissolées.", Price = 31.50M, CategoryId = 2, Img = "steakaupoivre-min.jpeg" },
    new Menu { Id = 5, Name = "Carpaccio de Bœuf", Description = "Fines tranches de bœuf cru assaisonné, garnies de copeaux de parmesan.", Price = 12.99M, CategoryId = 1, Img = "carpaccio-min.jpg" },
    new Menu { Id = 6, Name = "Tiramisu", Description = "Un classique italien à base de biscuits imbibés de café et de mascarpone.", Price = 9.99M, CategoryId = 3, Img = "tiramitsu-min.jpg" },
    new Menu { Id = 7, Name = "Crème Brûlée", Description = "Crème à la vanille avec une croûte de sucre caramélisé.", Price = 8.75M, CategoryId = 3, Img = "creme-min.jpeg" },
    new Menu { Id = 8, Name = "Citronnade Fraîche", Description = "Citronnade maison rafraîchissante.", Price = 4.99M, CategoryId = 4, Img = "citronnade-min.jpg" },
    new Menu { Id = 9, Name = "Mocktail Tropical", Description = "Mélange de fruits tropicaux, de jus et de soda.", Price = 6.25M, CategoryId = 4, Img = "mocktail-min.jpg" },
    new Menu { Id = 10, Name = "Martini Classique", Description = "Martini sec avec une olive.", Price = 10.50M, CategoryId = 5, Img = "martini.jpg" },
    new Menu { Id = 11, Name = "Margarita", Description = "Tequila, triple sec et jus de citron vert, servi sur glace.", Price = 11.75M, CategoryId = 5, Img = "margarita.jpg" },
    new Menu { Id = 18, Name = "Brochettes de Bœuf Marinées", Description = "Brochettes de bœuf tendre marinées dans des épices exotiques, grillées à la perfection.", Price = 14.99M, CategoryId = 1, Img = "brochette-min.jpg" },
    new Menu { Id = 19, Name = "Carpaccio de Filet de Bœuf", Description = "Tranches fines de filet de bœuf cru assaisonné avec de l'huile d'olive, du parmesan et des câpres.", Price = 16.50M, CategoryId = 1, Img = "capacciocapre-min.jpg" },
    new Menu { Id = 20, Name = "Ailes de Poulet Épicées", Description = "Ailes de poulet croustillantes assaisonnées avec un mélange d'épices piquantes, accompagnées de sauce au choix.", Price = 11.75M, CategoryId = 1, Img = "ailesdepoulet-min.jpg" },
    new Menu { Id = 21, Name = "Assiette de Charcuterie", Description = "Une sélection de charcuteries fines, comprenant du salami, du jambon et des saucisses, accompagnée de cornichons et de moutarde.", Price = 18.25M, CategoryId = 1, Img = "assiettecharcut-min.jpg" },
    new Menu { Id = 23, Name = "Mousse au Chocolat", Description = "Une mousse onctueuse et riche au chocolat noir, garnie de copeaux de chocolat.", Price = 7.25M, CategoryId = 3, Img = "mousse-min.jpg" },
    new Menu { Id = 24, Name = "Tarte aux Fruits de la Passion", Description = "Une délicieuse tarte avec une garniture fruitée et acidulée de fruits de la passion.", Price = 11.5M, CategoryId = 3, Img = "passion-min.jpeg" },
    new Menu { Id = 26, Name = "Limonade Fraîche", Description = "Limonade maison rafraîchissante préparée avec des citrons fraîchement pressés.", Price = 5.99M, CategoryId = 4, Img = "limonade-min.jpg" },
    new Menu { Id = 27, Name = "Thé Glacé aux Pêches", Description = "Thé glacé infusé avec des pêches juteuses, sucré à la perfection.", Price = 4.50M, CategoryId = 4, Img = "pechethe-min.jpg" },
    new Menu { Id = 28, Name = "Smoothie aux Baies", Description = "Smoothie onctueux aux baies mélangées avec du yaourt et du miel.", Price = 6.75M, CategoryId = 4, Img = "smoothiebaie-min.jpeg" },
    new Menu { Id = 29, Name = "Café Mocha", Description = "Café expresso mélangé avec du chocolat chaud et du lait mousseux.", Price = 3.99M, CategoryId = 4, Img = "cafemocha-min.jpg" },
    new Menu { Id = 30, Name = "Jus de Mangue Frais", Description = "Jus de mangue pressé à froid pour une saveur naturelle et rafraîchissante.", Price = 7.25M, CategoryId = 4, Img = "mangue-min.jpg" },
    new Menu { Id = 31, Name = "Eau Infusée aux Agrumes", Description = "Eau infusée avec des tranches d'orange, de citron et de citron vert pour une touche d'agrumes.", Price = 3.50M, CategoryId = 4, Img = "eau-min.jpg" },
    new Menu { Id = 32, Name = "Mocktail Mojito", Description = "Version sans alcool du célèbre mojito, avec menthe fraîche, citron vert et soda.", Price = 6.99M, CategoryId = 4, Img = "mojitomock-min.jpg" },
    new Menu { Id = 33, Name = "Lait de Coco Frappé", Description = "Lait de coco mélangé avec de la glace, créant une boisson crémeuse et rafraîchissante.", Price = 5.50M, CategoryId = 4, Img = "coco-min.jpg" },
    new Menu { Id = 34, Name = "Cuba Libre", Description = "Rhum Ambré, coca cola, citron vert.", Price = 10.99M, CategoryId = 5, Img = "cubralibre.jpg" },
    new Menu { Id = 35, Name = "Old Fashioned", Description = "Bourbon infusé avec un sucre, des amers et une touche d'orange, servi sur glace.", Price = 12.50M, CategoryId = 5, Img = "oldfashion.jpg" },
    new Menu { Id = 36, Name = "Piña Colada", Description = "Rhum, crème de coco et jus d'ananas, mixés avec de la glace.", Price = 9.75M, CategoryId = 5, Img = "pina.jpg" },
    new Menu { Id = 37, Name = "Martini aux Fraises", Description = "Vodka infusée aux fraises, vermouth sec et garni de fraises fraîches.", Price = 11.25M, CategoryId = 5, Img = "martinifraise.jpg" },
    new Menu { Id = 38, Name = "Negroni", Description = "Gin, vermouth rouge et Campari, garni d'une tranche d'orange.", Price = 13.50M, CategoryId = 5, Img = "negroni.jpg" },
    new Menu { Id = 39, Name = "Mojito Classique", Description = "Rhum blanc, menthe fraîche, sucre, eau gazeuse et citron vert.", Price = 11.99M, CategoryId = 5, Img = "mojitoclassique.jpg" },
    new Menu { Id = 40, Name = "Whisky Sour", Description = "Bourbon, sirop de sucre, jus de citron et blanc d'œuf, secoués et servis avec de la glace.", Price = 12.75M, CategoryId = 5, Img = "WhiskySour.jpg" },
    new Menu { Id = 41, Name = "Cosmopolitan", Description = "Vodka, triple sec, jus de canneberge et jus de lime, servi dans un verre à cocktail.", Price = 10.25M, CategoryId = 5, Img = "cosmopolitan.jpg" },
            // ... (menus suivants)
        };

                foreach (Menu m in menus)
                {
                    // Notez le changement ici pour utiliser CategoryId plutôt que Category
                    m.Category = categories.Single(c => c.Id == m.CategoryId);
                    context.Menus.Add(m);
                }
                context.SaveChanges();

                var teamList = new TeamList[]
             {
                     new TeamList { Id = 1, Name = "Jean", Age = 28, Job = "Chef de cuisine", Description = "Avec une passion pour la gastronomie, il supervise la préparation des plats, crée de nouvelles recettes et assure que chaque assiette qui quitte la cuisine reflète la qualité et le goût exceptionnels de l'établissement.", Photo = "gege.webp" },
    new TeamList { Id = 2, Name = "Marie", Age = 24, Job = "Serveuse", Description = "Aimable et attentionnée, elle assure un service de qualité en prenant les commandes, en conseillant les clients sur le menu, et en veillant à ce que chaque repas soit une expérience agréable.", Photo = "serveuse.jpg" },
    new TeamList { Id = 3, Name = "Pierre", Age = 32, Job = "Sommelier", Description = "Pierre possède une connaissance approfondie des vins et des accords mets et vins. Il guide les clients dans le choix du vin parfait pour accompagner leur repas, contribuant ainsi à une expérience gastronomique complète.", Photo = "sommelier.jpg" },
    new TeamList { Id = 4, Name = "Sophie", Age = 22, Job = "Assistante de cuisine", Description = "Apportant son soutien précieux au chef de cuisine, Sophie participe à la préparation des ingrédients, à l'organisation de la cuisine, et contribue à maintenir une efficacité optimale dans les opérations de cuisine.", Photo = "assistante.jpg" },
    new TeamList { Id = 5, Name = "Luc", Age = 30, Job = "Manager", Description = "Supervise l'ensemble de l'établissement, s'assurant que tout fonctionne harmonieusement. De la gestion du personnel aux opérations quotidiennes, Luc veille à ce que l'expérience des clients soit exceptionnelle à tous égards.", Photo = "manager.jpg" },
};
                foreach (TeamList member in teamList)
                {
                    // Notez le changement ici pour utiliser CategoryId plutôt que Category
                    context.TeamLists.Add(member);
                }
                context.SaveChanges();
                var feed = new FeedBackModel[]
                            {
                     new FeedBackModel { Id_FeedBack = 1, Pseudo_FeedBack = "Alice", Notation_FeedBack = 4, Email_FeedBack = "alice@example.com", Message_FeedBack = "Très bonne expérience culinaire, j'ai adoré les plats!" },
    new FeedBackModel { Id_FeedBack = 2, Pseudo_FeedBack = "Bob", Notation_FeedBack = 5, Email_FeedBack = "bob@example.com", Message_FeedBack = "Le service était exceptionnel et la cuisine était délicieuse." },
    new FeedBackModel { Id_FeedBack = 3, Pseudo_FeedBack = "Charlie", Notation_FeedBack = 3, Email_FeedBack = "charlie@example.com", Message_FeedBack = "Pas mal, mais je pense que certaines portions pourraient être plus grandes." },
    new FeedBackModel { Id_FeedBack = 4, Pseudo_FeedBack = "David", Notation_FeedBack = 5, Email_FeedBack = "david@example.com", Message_FeedBack = "Tout était parfait, de l'accueil au dessert!" },
    new FeedBackModel { Id_FeedBack = 5, Pseudo_FeedBack = "Eva", Notation_FeedBack = 2, Email_FeedBack = "eva@example.com", Message_FeedBack = "Malheureusement, la qualité des plats ne correspondait pas à mes attentes." },

               };
                foreach (FeedBackModel f in feed)
                {
                    // Notez le changement ici pour utiliser CategoryId plutôt que Category
                    context.FeedBacks.Add(f);
                }
                context.SaveChanges();
            };
        }
    }

}