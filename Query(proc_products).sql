use pharmacie_db
create procedure sp_addProduct

@name varchar(55),
@desc varchar(max),
@image image,
@buy_price varchar(55),
@sell_price varchar(55),
@catID int ,
@amID int,
@snID int

as
INSERT INTO [dbo].[products]
           ([nom_p]
           ,[desc_p]
           ,[image_p]
           ,[buy_price]
           ,[sell_price]
           ,[id_cat]
           ,[id_am]
           ,[id_NS]
           ,[barcode])
     VALUES
           (@name,@desc ,@image ,@buy_price ,@sell_price ,@catID  ,@amID ,@snID )
return
/*afficher tous*/
create procedure sp_selectAllProducts
as
select
p.id_p ,
c.nom_cat,
p.nom_p, 
a.name_am,
n.nom_NS,
p.buy_price,
p.sell_price,
isnull(sum(convert(decimal,e.Qty)),0) 'Quantité',
p.barcode,
p.desc_p

from products p 
left join expire_date e 
on p.id_p = e.id_p
inner join categorie c
on p.id_cat=c.id_cat
inner join active_materielle a
on a.id_am=p.id_am
inner join Nom_scientifique n
on n.id_NS=p.id_NS
group by 
p.id_p,
c.nom_cat,
p.nom_p, 
a.name_am,
n.nom_NS,
p.buy_price,
p.sell_price,
p.barcode,
p.desc_p

return

exec sp_selectAllProducts

/*search*/
alter procedure sp_searchProduct
@search varchar(50)
as
select * from
(select
p.id_p ,
c.nom_cat,
p.nom_p, 
a.name_am,
n.nom_NS,
p.buy_price,
p.sell_price,
isnull(sum(convert(decimal,e.Qty)),0) 'Quantité',
p.barcode,
p.desc_p

from products p 
left join expire_date e 
on p.id_p = e.id_p
inner join categorie c
on p.id_cat=c.id_cat
inner join active_materielle a
on a.id_am=p.id_am
inner join Nom_scientifique n
on n.id_NS=p.id_NS
group by 
p.id_p,
c.nom_cat,
p.nom_p, 
a.name_am,
n.nom_NS,
p.buy_price,
p.sell_price,
p.barcode,
p.desc_p) products
where
convert(varchar,id_p)+
nom_cat+
nom_p+
name_am+
nom_NS+
buy_price+
sell_price+
convert(varchar,Quantité)+
barcode+
desc_p like '%'+@search+'%'
return

/*image query*/

create proc sp_getImage
@id bigint
as
	select image_p from products where id_p=@id
return

/*expire date*/

alter procedure sp_expireDate
@id bigint
as
	select date_ex "date d'expédition",ISNULL(Qty,0)'Quantité' from expire_date where id_p=@id
return

/*delete product*/

create procedure sp_deletProduct
@id bigint
as
	delete from products where id_p=@id
return

/*update*/
create proc sp_getSelectedProduct
@id bigint
as
	select
c.nom_cat,
p.nom_p, 
a.name_am,
n.nom_NS,
p.buy_price,
p.sell_price,
p.barcode,
p.desc_p,
p.image_p
from products p 
inner join categorie c
on p.id_cat=c.id_cat
inner join active_materielle a
on a.id_am=p.id_am
inner join Nom_scientifique n
on n.id_NS=p.id_NS
where p.id_p=@id

return

create procedure sp_addProduct

@name varchar(55),
@desc varchar(max),
@image image,
@buy_price varchar(55),
@sell_price varchar(55),
@catID int ,
@amID int,
@snID int

create proc sp_updateProduct
@id int,
@name varchar(55),
@desc varchar(max),
@image image,
@buy_price varchar(55),
@sell_price varchar(55),
@catID int ,
@amID int,
@snID int,
@barcode varchar(55)
as
update products set
           [nom_p]=@name
           ,[desc_p]=@desc
           ,[image_p]=@image
           ,[buy_price]=@buy_price
           ,[sell_price]=@sell_price
           ,[id_cat]=@catID
           ,[id_am]=@amID
           ,[id_NS]=@snID
           ,[barcode]=@barcode
		   where
		   id_p=@id
return