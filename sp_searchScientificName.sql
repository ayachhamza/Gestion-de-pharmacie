create proc sp_searchScientificName
@search varchar(50)
as
	select id_NS 'ID Le nom scientifique', nom_NS 'Nom scientifique'
	from Nom_scientifique
	where 
	CONVERT(varchar,id_NS)+nom_NS LIKE '%'+@search+'%'
return