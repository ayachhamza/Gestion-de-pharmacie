create proc sp_selectAllActiveMateriel
as
	select id_am 'ID Matiére actif' , name_am 'Nom Matiére actif', description_am 'Description Matiére actif' 
	from active_materielle
return