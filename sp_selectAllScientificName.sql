create proc sp_selectAllScientificName
as
	select id_NS 'ID Le nom scientifique', nom_NS 'Nom scientifique'
	from Nom_scientifique
return