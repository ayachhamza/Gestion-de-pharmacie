create proc sp_deleteActiveMateriel
@id int
as
	delete active_materielle where id_am=@id
return