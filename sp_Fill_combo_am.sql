create proc sp_Fill_combo_am
as
	select id_am,name_am from active_materielle
return