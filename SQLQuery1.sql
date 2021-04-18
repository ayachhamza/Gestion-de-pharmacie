create proc sp_addCategorie
@cat_name varchar(50)
as
insert into categorie (nom_cat) values(@cat_name)

return