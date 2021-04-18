create proc sp_Fill_combo_sn
as
	select id_NS ,nom_NS from Nom_scientifique
return