BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Contact" (
	"id"	INTEGER,
	"Email"	TEXT,
	"Message"	TEXT,
	PRIMARY KEY("id" AUTOINCREMENT)
);
COMMIT;