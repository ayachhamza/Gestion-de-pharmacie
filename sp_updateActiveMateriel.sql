create proc sp_updateActiveMateriel
@id int,@nom varchar(50),@description varchar(max)
as
	update active_materielle set name_am=@nom ,description_am=@description where id_am=@id
return