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
(username nchar(10) not null primary key,
 password nchar(10) not null,
 remark int check(remark=1 or remark=2) not null/*1普通用户2管理员*/
);
create table fooditem--每一种饭菜详情:属于哪一类（面、荤、素、汤）、名称、价格、库存
( 
 itemname nchar(10) primary key,
 category nchar(10),
 itemprice decimal(6,1),
 amount int,
);
create table taocan  --套餐菜单：名字、价格、包含的内容
(
 taocanname nchar(10) primary key,
 itemname1  nchar(10) foreign key references fooditem(itemname),
 itemname2  nchar(10) foreign key references fooditem(itemname),
 itemname3  nchar(10) foreign key references fooditem(itemname),
 itemname4  nchar(10) foreign key references fooditem(itemname),
 taocanprice decimal(6,1),  /*所有单品总和打9折*/
);
create table foodlist--单品销售：单品名，交易日期，销售数量
(
 itemname nchar(10) foreign key references fooditem,
 tradedate datetime default getdate(),
 saleamount int,
 username nchar(10) foreign key references [User],
);
create table taocanlist--套餐销售：套餐名，交易日期，销售数量
(
 taocanname nchar(10) foreign key references taocan,
 tradedate datetime default getdate(),
 saleamount int,
 username nchar(10) foreign key references [User],
);

insert into taocanlist values('{0}', GETDATE(), 1, '{1}'); 
insert into foodlist
values('宫保鸡丁',GETDATE(),1,'ghr');

select count(*) from [user] where username='ghr' and remark= 2;
update [User]
set password='1234'
where username='ghr' and remark=1;

insert into fooditem values('宫保鸡丁','荤菜','30','5');
insert into fooditem values('红烧鸡爪','荤菜','25','10');
insert into fooditem values('红烧肉','荤菜','48.5','10');
insert into fooditem values('糖醋里脊','荤菜','27','6');
insert into fooditem values('孜然羊肉','荤菜','38','3');
insert into fooditem values('麻辣小龙虾','荤菜','60','7');
insert into fooditem values('可乐鸡翅','荤菜','38','2');
insert into fooditem values('毛血旺','荤菜','45','4');
insert into fooditem values('土豆牛肉','荤菜','32','5');
insert into fooditem values('麻辣鱼','荤菜','38.5','8');

insert into fooditem values('西兰花','素菜','14','8');
insert into fooditem values('西红柿炒鸡蛋','素菜','16.5','10');
insert into fooditem values('酸辣土豆丝','素菜','10','9');
insert into fooditem values('风味茄子','素菜','20','6');
insert into fooditem values('松子玉米','素菜','28','5');
insert into fooditem values('炒豆角','素菜','13','12');
insert into fooditem values('杏鲍菇','素菜','23','5');
insert into fooditem values('麻婆豆腐','素菜','25.5','5');
insert into fooditem values('地三鲜','素菜','19','9');
insert into fooditem values('凉拌黄瓜','素菜','10','5');

insert into fooditem values('馒头','面食','3','20');
insert into fooditem values('米饭','面食','3','20');
insert into fooditem values('油饼','面食','3','15');
insert into fooditem values('水饺(肉)','面食','15','15');
insert into fooditem values('水饺(素)','面食','12','15');
insert into fooditem values('花卷','面食','3.5','20');
insert into fooditem values('面条','面食','7','20');
insert into fooditem values('蒸包','面食','10','20');

insert into fooditem values('西红柿鸡蛋汤','汤粥','12','10');
insert into fooditem values('紫菜蛋花汤','汤粥','12','10');
insert into fooditem values('皮蛋瘦肉粥','汤粥','15','10');
insert into fooditem values('八宝粥','汤粥','10','10');
insert into fooditem values('银耳莲子汤','汤粥','15','10');
insert into fooditem values('雪碧','汤粥','5','10');
insert into fooditem values('可乐','汤粥','5','10');
insert into fooditem values('芬达','汤粥','5','10');

insert into taocan values('套餐一','宫保鸡丁','酸辣土豆丝','馒头','西红柿鸡蛋汤','47.7');
insert into taocan values('套餐二','孜然羊肉','风味茄子','面条','紫菜蛋花汤','69.3');
insert into taocan values('套餐三','糖醋里脊','麻婆豆腐','油饼','八宝粥','58.5');
insert into taocan values('套餐四','孜然羊肉','杏鲍菇','米饭','皮蛋瘦肉粥','71.1');
insert into taocan values('套餐五','可乐鸡翅','西红柿炒鸡蛋','花卷','银耳莲子汤','65.7');

select distinct category from fooditem;

select taocanname,itemname1,itemname2,itemname3,itemname4,taocanprice,min(amount) as amount
from taocan,fooditem
where itemname=itemname1 or itemname=itemname2 or itemname=itemname3 or itemname=itemname4 
group by taocanname,itemname1,itemname2,itemname3,itemname4,taocanprice;



update fooditem
set amount=amount-1
where itemname='宫保鸡丁';

update foodlist
set itemname='宫保鸡丁',tradedate=GETDATE(),saleamount=1,username='ghr';

select amount
from fooditem
where itemname='红烧鸡爪';


select  fooditem.itemname as 单品名 ,zongshu 总数 
from fooditem, (select sum(saleamount) as zongshu, itemname from foodlist Where DateDiff(dd, tradedate, '2018-9-9') = 0 group by itemname) as tongji 
where tongji.itemname = fooditem.itemname and fooditem.category = '面食'
order by zongshu desc ;

select username,sum(itemprice)
from foodlist,fooditem
group by username 
order by sum(itemprice) desc;

select username,sum(taocanprice)
from taocanlist,taocan
group by username 
order by sum(taocanprice) desc;


select excel1.username
from 
(select username,sum(itemprice) as price1
from foodlist,fooditem
group by username) as excel1,
(select username,sum(taocanprice) as price2
from taocanlist,taocan
group by username) as excel2
order by price1+price2;


