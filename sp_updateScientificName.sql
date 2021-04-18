create proc sp_updateScientificName
 @id int ,@nom varchar(50)
as
	update Nom_scientifique set nom_NS=@nom where id_NS=@id
return