BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "TeamLists" (
	"Id"	INTEGER NOT NULL,
	"Name"	TEXT,
	"Age"	INTEGER NOT NULL,
	"Job"	TEXT,
	"Description"	TEXT,
	"Photo"	TEXT,
	CONSTRAINT "PK_TeamLists" PRIMARY KEY("Id" AUTOINCREMENT)
);
INSERT INTO "TeamLists" VALUES (1,'Jean',28,'Chef de cuisine','Avec une passion pour la gastronomie, il supervise la préparation des plats, crée de nouvelles recettes et assure que chaque assiette qui quitte la cuisine reflète la qualité et le goût exceptionnels de l''établissement.','gege.webp');
INSERT INTO "TeamLists" VALUES (2,'Marie',24,'Serveur','Aimable et attentionnée, elle assure un service de qualité en prenant les commandes, en conseillant les clients sur le menu, et en veillant à ce que chaque repas soit une expérience agréable.','serveuse.jpg');
INSERT INTO "TeamLists" VALUES (3,'Pierre',32,'Sommelier','Pierre possède une connaissance approfondie des vins et des accords mets et vins. Il guide les clients dans le choix du vin parfait pour accompagner leur repas, contribuant ainsi à une expérience gastronomique complète.','sommelier.jpg');
INSERT INTO "TeamLists" VALUES (4,'Sophie',22,'Assistante de cuisine','Apportant son soutien précieux au chef de cuisine, Sophie participe à la préparation des ingrédients, à l''organisation de la cuisine, et contribue à maintenir une efficacité optimale dans les opérations de cuisine.','assistante.jpg');
INSERT INTO "TeamLists" VALUES (5,'Luc',30,'Manager','supervise l''ensemble de l''établissement, s''assurant que tout fonctionne harmonieusement. De la gestion du personnel aux opérations quotidiennes, Luc veille à ce que l''expérience des clients soit exceptionnelle à tous égards.','manager.jpg');
COMMIT;
