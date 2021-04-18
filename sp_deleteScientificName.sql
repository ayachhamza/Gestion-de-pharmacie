create proc sp_deleteScientificName
@id int
as
	delete from Nom_scientifique where id_NS=@id
return