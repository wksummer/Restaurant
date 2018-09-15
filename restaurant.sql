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
(username nchar(10) not null primary key,
 password nchar(10) not null,
 remark int check(remark=1 or remark=2) not null/*1��ͨ�û�2����Ա*/
);
create table fooditem--ÿһ�ַ�������:������һ�ࣨ�桢�硢�ء����������ơ��۸񡢿��
( 
 itemname nchar(10) primary key,
 category nchar(10),
 itemprice decimal(6,1),
 amount int,
);
create table taocan  --�ײͲ˵������֡��۸񡢰���������
(
 taocanname nchar(10) primary key,
 itemname1  nchar(10) foreign key references fooditem(itemname),
 itemname2  nchar(10) foreign key references fooditem(itemname),
 itemname3  nchar(10) foreign key references fooditem(itemname),
 itemname4  nchar(10) foreign key references fooditem(itemname),
 taocanprice decimal(6,1),  /*���е�Ʒ�ܺʹ�9��*/
);
create table foodlist--��Ʒ���ۣ���Ʒ�����������ڣ���������
(
 itemname nchar(10) foreign key references fooditem,
 tradedate datetime default getdate(),
 saleamount int,
 username nchar(10) foreign key references [User],
);
create table taocanlist--�ײ����ۣ��ײ������������ڣ���������
(
 taocanname nchar(10) foreign key references taocan,
 tradedate datetime default getdate(),
 saleamount int,
 username nchar(10) foreign key references [User],
);

insert into taocanlist values('{0}', GETDATE(), 1, '{1}'); 
insert into foodlist
values('��������',GETDATE(),1,'ghr');

select count(*) from [user] where username='ghr' and remark= 2;
update [User]
set password='1234'
where username='ghr' and remark=1;

insert into fooditem values('��������','���','30','5');
insert into fooditem values('���ռ�צ','���','25','10');
insert into fooditem values('������','���','48.5','10');
insert into fooditem values('�Ǵ��Ｙ','���','27','6');
insert into fooditem values('��Ȼ����','���','38','3');
insert into fooditem values('����С��Ϻ','���','60','7');
insert into fooditem values('���ּ���','���','38','2');
insert into fooditem values('ëѪ��','���','45','4');
insert into fooditem values('����ţ��','���','32','5');
insert into fooditem values('������','���','38.5','8');

insert into fooditem values('������','�ز�','14','8');
insert into fooditem values('������������','�ز�','16.5','10');
insert into fooditem values('��������˿','�ز�','10','9');
insert into fooditem values('��ζ����','�ز�','20','6');
insert into fooditem values('��������','�ز�','28','5');
insert into fooditem values('������','�ز�','13','12');
insert into fooditem values('�ӱ���','�ز�','23','5');
insert into fooditem values('���Ŷ���','�ز�','25.5','5');
insert into fooditem values('������','�ز�','19','9');
insert into fooditem values('����ƹ�','�ز�','10','5');

insert into fooditem values('��ͷ','��ʳ','3','20');
insert into fooditem values('�׷�','��ʳ','3','20');
insert into fooditem values('�ͱ�','��ʳ','3','15');
insert into fooditem values('ˮ��(��)','��ʳ','15','15');
insert into fooditem values('ˮ��(��)','��ʳ','12','15');
insert into fooditem values('����','��ʳ','3.5','20');
insert into fooditem values('����','��ʳ','7','20');
insert into fooditem values('����','��ʳ','10','20');

insert into fooditem values('������������','����','12','10');
insert into fooditem values('�ϲ˵�����','����','12','10');
insert into fooditem values('Ƥ��������','����','15','10');
insert into fooditem values('�˱���','����','10','10');
insert into fooditem values('����������','����','15','10');
insert into fooditem values('ѩ��','����','5','10');
insert into fooditem values('����','����','5','10');
insert into fooditem values('�Ҵ�','����','5','10');

insert into taocan values('�ײ�һ','��������','��������˿','��ͷ','������������','47.7');
insert into taocan values('�ײͶ�','��Ȼ����','��ζ����','����','�ϲ˵�����','69.3');
insert into taocan values('�ײ���','�Ǵ��Ｙ','���Ŷ���','�ͱ�','�˱���','58.5');
insert into taocan values('�ײ���','��Ȼ����','�ӱ���','�׷�','Ƥ��������','71.1');
insert into taocan values('�ײ���','���ּ���','������������','����','����������','65.7');

select distinct category from fooditem;

select taocanname,itemname1,itemname2,itemname3,itemname4,taocanprice,min(amount) as amount
from taocan,fooditem
where itemname=itemname1 or itemname=itemname2 or itemname=itemname3 or itemname=itemname4 
group by taocanname,itemname1,itemname2,itemname3,itemname4,taocanprice;



update fooditem
set amount=amount-1
where itemname='��������';

update foodlist
set itemname='��������',tradedate=GETDATE(),saleamount=1,username='ghr';

select amount
from fooditem
where itemname='���ռ�צ';


select  fooditem.itemname as ��Ʒ�� ,zongshu ���� 
from fooditem, (select sum(saleamount) as zongshu, itemname from foodlist Where DateDiff(dd, tradedate, '2018-9-9') = 0 group by itemname) as tongji 
where tongji.itemname = fooditem.itemname and fooditem.category = '��ʳ'
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


