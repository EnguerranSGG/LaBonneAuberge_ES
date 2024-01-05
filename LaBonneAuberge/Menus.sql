BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Menus" (
	"Id"	INTEGER NOT NULL,
	"Name"	TEXT,
	"Description"	TEXT,
	"Price"	TEXT NOT NULL,
	"CategoryId"	INTEGER NOT NULL,
	"Img"	TEXT,
	CONSTRAINT "FK_Menus_Categories_CategoryId" FOREIGN KEY("CategoryId") REFERENCES "Categories"("Id") ON DELETE CASCADE,
	CONSTRAINT "PK_Menus" PRIMARY KEY("Id" AUTOINCREMENT)
);
INSERT INTO "Menus" VALUES (1,'Filet Mignon','Un morceau tendre et juteux de filet mignon de bœuf, grillé à la perfection.','35.99',2,'filet mignon-min.jpeg');
INSERT INTO "Menus" VALUES (2,'Côte de Porc Glacée au Miel','Côtes de porc épaisses cuites lentement et glacées avec une sauce au miel délicieusement sucrée.','28.50',2,'cotedeporc-min.jpg');
INSERT INTO "Menus" VALUES (3,'Assiette Mixte Grillée','Une sélection de viandes grillées comprenant du bœuf, de l''agneau et du poulet, servie avec des légumes grillés.','42.75',2,'Assiette Mixte grillée-min.jpg');
INSERT INTO "Menus" VALUES (4,'Steak au Poivre','Un steak savoureux recouvert d''une sauce au poivre noir, accompagné de pommes de terre rissolées.','31.50',2,'steakaupoivre-min.jpeg');
INSERT INTO "Menus" VALUES (5,'Carpaccio de Bœuf','Fines tranches de bœuf cru assaisonné, garnies de copeaux de parmesan.','12.99',1,'carpaccio-min.jpg');
INSERT INTO "Menus" VALUES (6,'Tiramisu','Un classique italien à base de biscuits imbibés de café et de mascarpone.','9.99',3,'tiramitsu-min.jpg');
INSERT INTO "Menus" VALUES (7,'Crème Brûlée','Crème à la vanille avec une croûte de sucre caramélisé.','8.75',3,'creme-min.jpeg');
INSERT INTO "Menus" VALUES (8,'Citronnade Fraîche','Citronnade maison rafraîchissante.','4.99',4,'citronnade-min.jpg');
INSERT INTO "Menus" VALUES (9,'Mocktail Tropical','Mélange de fruits tropicaux, de jus et de soda.','6.25',4,'mocktail-min.jpg');
INSERT INTO "Menus" VALUES (10,'Martini Classique','Martini sec avec une olive.','10.50',5,'martini.jpg');
INSERT INTO "Menus" VALUES (11,'Margarita','Tequila, triple sec et jus de citron vert, servi sur glace.','11.75',5,'margarita.jpg');
INSERT INTO "Menus" VALUES (18,'Brochettes de Bœuf Marinées','Brochettes de bœuf tendre marinées dans des épices exotiques, grillées à la perfection.','14.99',1,'brochette-min.jpg');
INSERT INTO "Menus" VALUES (19,'Carpaccio de Filet de Bœuf','Tranches fines de filet de bœuf cru assaisonné avec de l''huile d''olive, du parmesan et des câpres.','16.50',1,'capacciocapre-min.jpg');
INSERT INTO "Menus" VALUES (20,'Ailes de Poulet Épicées','Ailes de poulet croustillantes assaisonnées avec un mélange d''épices piquantes, accompagnées de sauce au choix.','11.75',1,'ailesdepoulet-min.jpg');
INSERT INTO "Menus" VALUES (21,'Assiette de Charcuterie','Une sélection de charcuteries fines, comprenant du salami, du jambon et des saucisses, accompagnée de cornichons et de moutarde.','18.25',1,'assiettecharcut-min.jpg');
INSERT INTO "Menus" VALUES (23,'Mousse au Chocolat','Une mousse onctueuse et riche au chocolat noir, garnie de copeaux de chocolat.','7.25',3,'mousse-min.jpg');
INSERT INTO "Menus" VALUES (24,'Tarte aux Fruits de la Passion','Une délicieuse tarte avec une garniture fruitée et acidulée de fruits de la passion.','11.5',3,'passion-min.jpeg');
INSERT INTO "Menus" VALUES (26,'Limonade Fraîche','Limonade maison rafraîchissante préparée avec des citrons fraîchement pressés.','5.99',4,'limonade-min.jpg');
INSERT INTO "Menus" VALUES (27,'Thé Glacé aux Pêches','Thé glacé infusé avec des pêches juteuses, sucré à la perfection.','4.50',4,'pechethe-min.jpg');
INSERT INTO "Menus" VALUES (28,'Smoothie aux Baies','Smoothie onctueux aux baies mélangées avec du yaourt et du miel.','6.75',4,'smoothiebaie-min.jpeg');
INSERT INTO "Menus" VALUES (29,'Café Mocha','Café expresso mélangé avec du chocolat chaud et du lait mousseux.','3.99',4,'cafemocha-min.jpg');
INSERT INTO "Menus" VALUES (30,'Jus de Mangue Frais','Jus de mangue pressé à froid pour une saveur naturelle et rafraîchissante.','7.25',4,'mangue-min.jpg');
INSERT INTO "Menus" VALUES (31,'Eau Infusée aux Agrumes','Eau infusée avec des tranches d''orange, de citron et de citron vert pour une touche d''agrumes.','3.50',4,'eau-min.jpg');
INSERT INTO "Menus" VALUES (32,'Mocktail Mojito','Version sans alcool du célèbre mojito, avec menthe fraîche, citron vert et soda.','6.99',4,'mojitomock-min.jpg');
INSERT INTO "Menus" VALUES (33,'Lait de Coco Frappé','Lait de coco mélangé avec de la glace, créant une boisson crémeuse et rafraîchissante.','5.50',4,'coco-min.jpg');
INSERT INTO "Menus" VALUES (34,'Cuba Libre','Rhum Ambré, coca cola, citron vert','10.99',5,'cubralibre.jpg');
INSERT INTO "Menus" VALUES (35,'Old Fashioned','Bourbon infusé avec un sucre, des amers et une touche d''orange, servi sur glace.','12.50',5,'oldfashion.jpg');
INSERT INTO "Menus" VALUES (36,'Piña Colada','Rhum, crème de coco et jus d''ananas, mixés avec de la glace.','9.75',5,'pina.jpg');
INSERT INTO "Menus" VALUES (37,'Martini aux Fraises','Vodka infusée aux fraises, vermouth sec et garni de fraises fraîches.','11.25',5,'martinifraise.jpg');
INSERT INTO "Menus" VALUES (38,'Negroni','Gin, vermouth rouge et Campari, garni d''une tranche d''orange.','13.50',5,'negroni.jpg');
INSERT INTO "Menus" VALUES (39,'Mojito Classique','Rhum blanc, menthe fraîche, sucre, eau gazeuse et citron vert.','11.99',5,'mojitoclassique.jpg');
INSERT INTO "Menus" VALUES (40,'Whisky Sour','Bourbon, sirop de sucre, jus de citron et blanc d''œuf, secoués et servis avec de la glace.','12.75',5,'WhiskySour.jpg');
INSERT INTO "Menus" VALUES (41,'Cosmopolitan','Vodka, triple sec, jus de canneberge et jus de lime, servi dans un verre à cocktail.','10.25',5,'cosmopolitan.jpg');
INSERT INTO "Menus" VALUES (42,'Daiquiri aux Fraises','Rhum blanc, jus de citron, sirop de sucre et fraises fraîches, mixés avec de la glace.','11.50',5,'daiquiri.jpg');
INSERT INTO "Menus" VALUES (43,'Moscow Mule','Vodka, gingembre frais, jus de lime, sirop de sucre et eau gazeuse, servi dans une tasse en cuivre.','12.99',5,'moscowmule.jpg');
INSERT INTO "Menus" VALUES (44,'Tom Collins','Gin, jus de citron, sirop de sucre et eau gazeuse, garni d''une tranche de citron.','10.75',5,'collins.jpg');
INSERT INTO "Menus" VALUES (45,'Mai Tai','Rhum blanc, rhum brun, curaçao, sirop d''orgeat et jus de lime, sur glace pilée.','13.25',5,'maitai.jpg');
INSERT INTO "Menus" VALUES (46,'Whisky Highball','Whisky, eau gazeuse et glace, garni d''une tranche de citron.','11.50',5,'highball.jpg');
INSERT INTO "Menus" VALUES (47,'Caipirinha','Cachaça, sucre, et quartiers de citron vert, écrasés avec de la glace.','12.75',5,'capirinha.jpg');
INSERT INTO "Menus" VALUES (48,'Raspberry Mojito','Rhum blanc, framboises fraîches, menthe, sucre, eau gazeuse et citron vert.','14.25',5,'raspberry mojito.jpg');
INSERT INTO "Menus" VALUES (49,'Aperol Spritz','Aperol, prosecco, eau gazeuse et une tranche d''orange, servi sur glace.','13.99',5,'aperol spritz.jpg');
CREATE INDEX IF NOT EXISTS "IX_Menus_CategoryId" ON "Menus" (
	"CategoryId"
);
COMMIT;
