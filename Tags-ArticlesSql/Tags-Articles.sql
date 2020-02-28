Create table Articles(
	Id int NOT NULL,
	Article varchar(50) NOT NULL,
	PRIMARY KEY (Id)
);

Create table Tags(
	Id int NOT NULL,
	Tag varchar(15) NOT NULL,
	PRIMARY KEY (Id)
);

Create table Tagged(
	Id int NOT NULL,
	Id_Article int NOT NULL,
	Id_Tag int NOT NULL
	PRIMARY KEY (Id)
);

INSERT INTO [test].[dbo].[Articles]
           ([Article])
     VALUES
           ('Что то про Илона Маска'),
           ('Что то про Путина'),
           ('Что то про Аниме')


INSERT INTO [test].[dbo].[Tags]
           ([Tag])
     VALUES
			('Бизнес'),
			('Политика'),
            ('Наука')

INSERT INTO [test].[dbo].[Tagged]
           (Id_Article, Id_Tag)
     VALUES
			(1,1),
			(1,3),
			(2,2)

SELECT art.Article, t.Tag
FROM Articles art
LEFT JOIN Tagged tgd On tgd.Id_Article = art.Id
LEFT JOIN Tags t On t.Id = tgd.Id_Tag

