BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
	"MigrationId"	TEXT NOT NULL,
	"ProductVersion"	TEXT NOT NULL,
	CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY("MigrationId")
);
CREATE TABLE IF NOT EXISTS "Categories" (
	"Id"	INTEGER NOT NULL,
	"Nom"	TEXT,
	CONSTRAINT "PK_Categories" PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "FeedBacks" (
	"Id_FeedBack"	INTEGER NOT NULL,
	"Pseudo_FeedBack"	TEXT NOT NULL,
	"Notation_FeedBack"	INTEGER NOT NULL,
	"Email_FeedBack"	TEXT NOT NULL,
	"Message_FeedBack"	TEXT NOT NULL,
	CONSTRAINT "PK_FeedBacks" PRIMARY KEY("Id_FeedBack" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Menus" (
	"Id"	INTEGER NOT NULL,
	"Name"	TEXT,
	"Description"	TEXT,
	"Price"	TEXT NOT NULL,
	"CategoryId"	INTEGER NOT NULL,
	CONSTRAINT "PK_Menus" PRIMARY KEY("Id" AUTOINCREMENT),
	CONSTRAINT "FK_Menus_Categories_CategoryId" FOREIGN KEY("CategoryId") REFERENCES "Categories"("Id") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "TeamLists" (
	"Id"	INTEGER NOT NULL,
	"Name"	TEXT,
	"Age"	INTEGER NOT NULL,
	"Job"	TEXT,
	"Description"	TEXT,
	"Photo"	TEXT,
	CONSTRAINT "PK_TeamLists" PRIMARY KEY("Id" AUTOINCREMENT)
);
INSERT INTO "__EFMigrationsHistory" ("MigrationId","ProductVersion") VALUES ('20240103134338_AllTables','8.0.0');
INSERT INTO "FeedBacks" ("Pseudo_FeedBack", "Notation_FeedBack", "Email_FeedBack", "Message_FeedBack") VALUES
('Alice', 4, 'alice@example.com', 'Très bonne expérience culinaire, j''ai adoré les plats!'),
('Bob', 5, 'bob@example.com', 'Le service était exceptionnel et la cuisine était délicieuse.'),
('Charlie', 3, 'charlie@example.com', 'Pas mal, mais je pense que certaines portions pourraient être plus grandes.'),
('David', 5, 'david@example.com', 'Tout était parfait, de l''accueil au dessert!'),
('Eva', 2, 'eva@example.com', 'Malheureusement, la qualité des plats ne correspondait pas à mes attentes.');
INSERT INTO "Categories" ("Id","Nom") VALUES (1,'Entrées'),
 (2,'Plats'),
 (3,'Desserts'),
 (4,'Boissons Sans Alcool'),
 (5,'Boissons Alcoolisées');
INSERT INTO "Menus" ("Id","Name","Description","Price","CategoryId") VALUES (50,'Filet Mignon','Un morceau tendre et juteux de filet mignon de bœuf, grillé à la perfection.','35.99',2),
 (51,'Côte de Porc Glacée au Miel','Côtes de porc épaisses cuites lentement et glacées avec une sauce au miel délicieusement sucrée.','28.5',2),
 (52,'Assiette Mixte Grillée','Une sélection de viandes grillées comprenant du bœuf, de l''agneau et du poulet, servie avec des légumes grillés.','42.75',2),
 (53,'Steak au Poivre','Un steak savoureux recouvert d''une sauce au poivre noir, accompagné de pommes de terre rissolées.','31.5',2),
 (54,'Brochettes de Bœuf Marinées','Brochettes de bœuf tendre marinées dans des épices exotiques, grillées à la perfection.','14.99',1),
 (55,'Carpaccio de Filet de Bœuf','Tranches fines de filet de bœuf cru assaisonné avec de l''huile d''olive, du parmesan et des câpres.','16.5',1),
 (56,'Ailes de Poulet Épicées','Ailes de poulet croustillantes assaisonnées avec un mélange d''épices piquantes, accompagnées de sauce au choix.','11.75',1),
 (57,'Assiette de Charcuterie','Une sélection de charcuteries fines, comprenant du salami, du jambon et des saucisses, accompagnée de cornichons et de moutarde.','18.25',1),
 (58,'Tiramisu','Un classique italien de couches de biscuits imbibés de café, de mascarpone et de cacao.','8.99',3),
 (59,'Mousse au Chocolat','Une mousse onctueuse et riche au chocolat noir, garnie de copeaux de chocolat.','7.25',3),
 (60,'Tarte aux Fruits de la Passion','Une délicieuse tarte avec une garniture fruitée et acidulée de fruits de la passion.','11.5',3),
 (61,'Crème Brûlée','Une crème à la vanille cuite, recouverte d''une fine couche de sucre caramélisé.','9.75',3),
 (62,'Limonade Fraîche','Limonade maison rafraîchissante préparée avec des citrons fraîchement pressés.','5.99',4),
 (63,'Thé Glacé aux Pêches','Thé glacé infusé avec des pêches juteuses, sucré à la perfection.','4.5',4),
 (64,'Smoothie aux Baies','Smoothie onctueux aux baies mélangées avec du yaourt et du miel.','6.75',4),
 (65,'Café Mocha','Café expresso mélangé avec du chocolat chaud et du lait mousseux.','3.99',4),
 (66,'Jus de Mangue Frais','Jus de mangue pressé à froid pour une saveur naturelle et rafraîchissante.','7.25',4),
 (67,'Eau Infusée aux Agrumes','Eau infusée avec des tranches d''orange, de citron et de citron vert pour une touche d''agrumes.','3.5',4),
 (68,'Mocktail Mojito','Version sans alcool du célèbre mojito, avec menthe fraîche, citron vert et soda.','6.99',4),
 (69,'Lait de Coco Frappé','Lait de coco mélangé avec de la glace, créant une boisson crémeuse et rafraîchissante.','5.5',4),
 (70,'Margarita','Tequila, triple sec et jus de citron vert, servi avec du sel sur le rebord du verre.','10.99',5),
 (71,'Old Fashioned','Bourbon infusé avec un sucre, des amers et une touche d''orange, servi sur glace.','12.5',5),
 (72,'Piña Colada','Rhum, crème de coco et jus d''ananas, mixés avec de la glace.','9.75',5),
 (73,'Martini aux Fraises','Vodka infusée aux fraises, vermouth sec et garni de fraises fraîches.','11.25',5),
 (74,'Negroni','Gin, vermouth rouge et Campari, garni d''une tranche d''orange.','13.5',5),
 (75,'Mojito Classique','Rhum blanc, menthe fraîche, sucre, eau gazeuse et citron vert.','11.99',5),
 (76,'Whisky Sour','Bourbon, sirop de sucre, jus de citron et blanc d''œuf, secoués et servis avec de la glace.','12.75',5),
 (77,'Cosmopolitan','Vodka, triple sec, jus de canneberge et jus de lime, servi dans un verre à cocktail.','10.25',5),
 (78,'Daiquiri aux Fraises','Rhum blanc, jus de citron, sirop de sucre et fraises fraîches, mixés avec de la glace.','11.5',5),
 (79,'Moscow Mule','Vodka, gingembre frais, jus de lime, sirop de sucre et eau gazeuse, servi dans une tasse en cuivre.','12.99',5),
 (80,'Tom Collins','Gin, jus de citron, sirop de sucre et eau gazeuse, garni d''une tranche de citron.','10.75',5),
 (81,'Mai Tai','Rhum blanc, rhum brun, curaçao, sirop d''orgeat et jus de lime, sur glace pilée.','13.25',5),
 (82,'Whisky Highball','Whisky, eau gazeuse et glace, garni d''une tranche de citron.','11.5',5),
 (83,'Caipirinha','Cachaça, sucre, et quartiers de citron vert, écrasés avec de la glace.','12.75',5),
 (84,'Raspberry Mojito','Rhum blanc, framboises fraîches, menthe, sucre, eau gazeuse et citron vert.','14.25',5),
 (85,'Aperol Spritz','Aperol, prosecco, eau gazeuse et une tranche d''orange, servi sur glace.','13.99',5);
INSERT INTO "TeamLists" ("Id","Name","Age","Job","Description","Photo") VALUES (1,'Jean',28,'Chef de cuisine','Avec une passion pour la gastronomie, il supervise la préparation des plats, crée de nouvelles recettes et assure que chaque assiette qui quitte la cuisine reflète la qualité et le goût exceptionnels de l''établissement.','gege.webp'),
 (2,'Marie',24,'Serveur','Aimable et attentionnée, elle assure un service de qualité en prenant les commandes, en conseillant les clients sur le menu, et en veillant à ce que chaque repas soit une expérience agréable.','serveuse.jpg'),
 (3,'Pierre',32,'Sommelier','Pierre possède une connaissance approfondie des vins et des accords mets et vins. Il guide les clients dans le choix du vin parfait pour accompagner leur repas, contribuant ainsi à une expérience gastronomique complète.','sommelier.jpg'),
 (4,'Sophie',22,'Assistant de cuisine','Apportant son soutien précieux au chef de cuisine, Sophie participe à la préparation des ingrédients, à l''organisation de la cuisine, et contribue à maintenir une efficacité optimale dans les opérations de cuisine.','assistante.jpg'),
 (5,'Luc',30,'Manager','supervise l''ensemble de l''établissement, s''assurant que tout fonctionne harmonieusement. De la gestion du personnel aux opérations quotidiennes, Luc veille à ce que l''expérience des clients soit exceptionnelle à tous égards.','manager.jpg');
CREATE INDEX IF NOT EXISTS "IX_Menus_CategoryId" ON "Menus" (
	"CategoryId"
);
COMMIT;
