create database restaurant
go
use restaurant
/*create table foodcategory--��������:�������ͱ�š�������������(��㡢��ˡ��زˡ�����) 
(
  categoryid int identity(1,1) primary key,
  categoryname nchar(10)not null unique,
  remark char(10),
 );*/
create table [User]--�û����û��������롢�û�����
(username nchar(10) primary key,
 password nchar(10) not null,
 remark bit check(remark=1 or remark=2)/*1��ͨ�û�2����Ա*/
);
create table fooditem--ÿһ�ַ�������:������һ�ࣨ�桢�硢�ء����������ơ��۸񡢿��
( 
 itemname nchar(10) primary key,
 category nchar(10),
 itemprice decimal,
 amount int,
);
create table taocan  --�ײͲ˵������֡��۸񡢰���������
(
 taocanname nchar(10) primary key,
 itemname1  nchar(10) foreign key references fooditem(itemname),
 itemname2  nchar(10) foreign key references fooditem(itemname),
 itemname3  nchar(10) foreign key references fooditem(itemname),
 taocanprice decimal,  /*���е�Ʒ�ܺʹ�9��*/
);
create table foodlist--��Ʒ���ۣ���Ʒ�����������ڣ���������
(
 itemname nchar(10) foreign key references fooditem,
 tradedate datetime default getdate(),
 saleamount int,
 primary key(itemname,tradedate)
);
create table taocanlist--�ײ����ۣ��ײ������������ڣ���������
(
 taocanname nchar(10) foreign key references taocan,
 tradedate datetime default getdate(),
 saleamount int,
 primary key(taocanname,tradedate)
);

/*insert foodcategory(categoryname)values('���',default);
insert foodcategory(categoryname) values('���',default);
insert foodcategory(categoryname) values('�ز�',default);
insert foodcategory(categoryname) values('����',default);*/
insert fooditem(itemname,itemprice ,amount)values('����',1,100);
insert fooditem(itemname,itemprice ,amount)values('��ͷ',1,100);
insert fooditem(itemname,itemprice ,amount)values('�˱���',3,100);
insert fooditem(itemname,itemprice ,amount)values('������',8,80);
insert fooditem(itemname,itemprice ,amount)values('������������',4,120);
insert taocan(taocanid,taocanname,taocanprice)values(1,'1���ײ�',18);
insert list(itemid,saleamount,salemoney)values(,3,24);








