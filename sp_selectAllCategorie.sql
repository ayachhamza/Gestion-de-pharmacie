create proc sp_selectAllCategorie
as
	select id_cat 'ID Famille', nom_cat 'Nom Famille' from categorie 
return