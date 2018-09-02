create database restaurant
go
use restaurant
/*create table foodcategory--饭菜种类:所属类型编号、所属类型名称(面点、荤菜、素菜、汤粥) 
(
  categoryid int identity(1,1) primary key,
  categoryname nchar(10)not null unique,
  remark char(10),
 );*/
create table [User]--用户：用户名、密码、用户种类
(username nchar(10) primary key,
 password nchar(10) not null,
 remark bit check(remark=1 or remark=2)/*1普通用户2管理员*/
);
create table fooditem--每一种饭菜详情:属于哪一类（面、荤、素、汤）、名称、价格、库存
( 
 itemname nchar(10) primary key,
 category nchar(10),
 itemprice decimal,
 amount int,
);
create table taocan  --套餐菜单：名字、价格、包含的内容
(
 taocanname nchar(10) primary key,
 itemname1  nchar(10) foreign key references fooditem(itemname),
 itemname2  nchar(10) foreign key references fooditem(itemname),
 itemname3  nchar(10) foreign key references fooditem(itemname),
 taocanprice decimal,  /*所有单品总和打9折*/
);
create table foodlist--单品销售：单品名，交易日期，销售数量
(
 itemname nchar(10) foreign key references fooditem,
 tradedate datetime default getdate(),
 saleamount int,
 primary key(itemname,tradedate)
);
create table taocanlist--套餐销售：套餐名，交易日期，销售数量
(
 taocanname nchar(10) foreign key references taocan,
 tradedate datetime default getdate(),
 saleamount int,
 primary key(taocanname,tradedate)
);

/*insert foodcategory(categoryname)values('面点',default);
insert foodcategory(categoryname) values('荤菜',default);
insert foodcategory(categoryname) values('素菜',default);
insert foodcategory(categoryname) values('汤粥',default);*/
insert fooditem(itemname,itemprice ,amount)values('花卷',1,100);
insert fooditem(itemname,itemprice ,amount)values('馒头',1,100);
insert fooditem(itemname,itemprice ,amount)values('八宝粥',3,100);
insert fooditem(itemname,itemprice ,amount)values('红烧肉',8,80);
insert fooditem(itemname,itemprice ,amount)values('西红柿炒鸡蛋',4,120);
insert taocan(taocanid,taocanname,taocanprice)values(1,'1号套餐',18);
insert list(itemid,saleamount,salemoney)values(,3,24);








