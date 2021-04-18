
create proc sp_addProduct
@name varchar(55),
@desc varchar(max),
@image image,
@buy_price varchar(55),
@sell_price varchar(55),
@catID int ,
@amID int,
@snID int,
@barcode varchar(100)
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
           (@name,@desc ,@image ,@buy_price ,@sell_price ,@catID  ,@amID ,@snID,@barcode )
return