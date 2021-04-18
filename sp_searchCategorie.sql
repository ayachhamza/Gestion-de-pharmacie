create proc sp_deleteCategorie
@id int
as
    delete from categorie where id_cat=@id
return