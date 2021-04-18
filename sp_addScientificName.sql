create proc sp_addScientificName
@nom varchar(50)
as
	insert into Nom_scientifique(nom_NS) values(@nom)
return