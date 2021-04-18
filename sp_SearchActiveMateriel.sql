create proc sp_SearchActiveMateriel
@search varchar(50)
as
	select id_am 'ID Matiére actif' , name_am 'Nom Matiére actif', description_am 'Description Matiére actif' 
	from active_materielle
	where
	convert(varchar,id_am)+name_am+description_am like '%'+@search+'%'
return