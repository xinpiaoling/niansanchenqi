CREATE TABLE  [dbo].[TEST](
  [ID] INT PRIMARY KEY IDENTITY(10,5),
  [NAME]  NCHAR(10)  NOT NULL
)

--NCHAR的数据类型是固定的，定长文本数据。比如NCHAR(10)数据不足十个，会以空白格的形式补足文本
--NVARCHAR的数据类型不是固定的。常用NVARCHAR

--NTEXT通常用于大篇幅不限字数的文章正文等


insert [TEST]([NAME]) VALUES('ZBB')

--数据类型
--int 整数类型，相应的从大到小有bigint,int,smallint,tinyint
--decimal,numeric  小数类型.可以精确的指定最多整体长度位数和小数位数。比如decimal(5,2),定义为最多整体长度为5位，小数位数为2位；如586.31,12.7；1986就不行，系统会自动补足两位小数.00，导致整体长度为6位
--float，real   小数类型，常用这个float.小数位数可变，输入多少就是多少 
--datetime    日期 时间
--bit   整数类型，只有0和1.输入0就是false,输入1就是true
--null  空值   不等于任何值，和任何值相比都是false

--其他约束
--not null   不是空值  非空约束
--unique    唯一值     唯一约束
--primary key         主键约束    同时保证非空和唯一
--check               自定义约束
--default             默认值    比如insert时候没有填数据给一个默认值

CREATE TABLE Student(                --创建一个表单表头，数据类型要求，约束
  [ID]   INT   PRIMARY KEY,
 [NAME]  NVARCHAR(10)  UNIQUE,  
 [FEMALE] BIT   DEFAULT(1),
 ENROLL DATETIME NOT NULL,
 AGE    INT   CHECK(AGE>0),
 SCORE  FLOAT   ,

)

INSERT Student([ID],[NAME],[FEMALE],ENROLL,AGE,SCORE) values(3,N'xin',1,'2019/8/10',18,86.5)          --插入数据 

ALTER table Student  nocheck constraint all      --需要添加不符合约束的值，删除约束
ALTER table Student check constraint all        --添加约束

CREATE TABLE Student(
  [id] INT IDENTITY,        --设置自增
)

--SQL2 homework

CREATE TABLE Problem(
  [Id] INT PRIMARY KEY IDENTITY,
  Title NVARCHAR(20)  NOT NULL,
  Content NVARCHAR(4000) NOT NULL,
  NeedRemoteHelp BIT DEFAULT(1),
  Reward  NVARCHAR(4000) NULL,
  PublishDateTime  DATETIME  NOT NULL,
)

--所有修改表结构的语句，前面都要加
alter table Problem       --修改表
 

alter table Problem
ADD Score decimal(3,1)        --添加Score列，设置数据类型为小数一位


alter table Problem
ADD Score decimal(5,1) not null     --也可以直接添加约束 



alter table Problem
DROP COLUMN Score         --删除列
   


ALTER TABLE Problem
DROP CONSTRAINT CK_Age                --删除列约束



ALTER TABLE Problem
ALTER COLUMN Score  float   null       --修改列数据类型和约束

alter table Problem
ADD constraint PK_Id PRIMARY KEY(Id)     --给Id列添加主键属性


alter table Problem
add constraint UK_NAME UNIQUE([NAME])     --给NAME列添加唯一属性


alter table Problem
add constraint CK_Score check(Score>0)     --给Score列添加自定义属性


alter table Problem 
add constraint DEFAULT  18  for NeedRometeHelp        --给需要发布求助行添加默认属性



注意：不能直接改变identity的属性，
只能先DROP属性，再ADD属性
alter table Student
drop constraint  Score
alter table Student
add CONSTRAINT CK_Score check(Score)



更新数据

update Student set Age=18             --将列Age值更新为固定的18

UPDATE Student set Age = Age+10       --将列的Age值全部添加10

update Student set Score = Age + Score    --列新Score的值等于Age和原Score的值相加


删除

delete Student           
TRUNCATE  table Student 

--上面两者都是删除表格列和数据，保留表。delete删除会有备份文件，TRUNCATE 删除没有备份文件。delete删除可以在后面添加条件,删除指定行

drop  table Student         --删除整张表
drop  database [17BANG]     --删除数据库

--注意：删除是一件高风险的动作，记得一定要备份

备份

USE master                                     --注意不能在当前数据库下恢复，可以备份
GO
BACKUP database [17bang] to disk='D:\\17bang.bak'       --备份数据库到指定位置
RESTORE DATABASE [17bang] from disk='D:\\17bang.bak'    --恢复数据库

--注意：如果看到如下提示，可以在RESTORE语句后加上 WITH REPLACE，意思就是用备份数据库替换掉现在使用的（in use）数据库




SQL3---homework
ALTER TABLE Problem
DROP COLUMN Title     --删除Title列

ALTER TABLE Problem
ADD Title NVARCHAR(20) NOT NULL    --添加 Title列

alter table Problem
ALTER COLUMN Content NTEXT  NULL     --更改列属性

alter table Problem
ALTER COLUMN NeedRomoteHelp NVARCHAR(MAX) NULL   --更改约束为允许null，只能用ALTER

alter table Problem
ADD CONSTRAINT CK_Reward check(Reward>0)     --添加Reward约束


USE master
GO
BACKUP DATABASE [17bang] to disk='D:\\17bang.bak'    --备份17bang数据库


delete TProblem      --删除表格列和数据
truncate TABLE TProblem    --删除表格列和数据

drop table TProblem      --删除表

alter table [User]
add constraint PK_Id PRIMARY KEY(Id)

alter table [User]
add constraint UK_UserName unique(UserName)


update [User] set [Password]='1234'



create table KeyWord (
    Id  int primary key identity(10,5)
)





--查找
select * from Student          --*通配符。查找所有数据

select [name],Age from Student    --可以指定列查找


SELECT 888+98                   --可以直接显示计算数值


declear @Result  int            --声明一个INT类型的变量，SQL变量必须加@

set @Result=32                  --将32赋值为@Result

set @Result=@Result+10          --在原基础上添加10


--% 匹配多个字符
--_ 匹配单个字符
--[]匹配[]内的字符
--^为不在范围内的字符
--like 为包含的意思
--ESCAPE为转义        只在条件语句中使用，要配合 like 

IF('ABCD' LIKE '_BC%')

IF('B' LIKE '[A,B,C,D]')

IF('E' LIKE '[^A,^B,^C,^D')

IF('源栈85%的就业率' LIKE '%#%%' ESCAPE '#')  

运算符有优先级，比如+-*/,一般使用()进行优先运算。取余：%.比如偶数为age%2=0.

select * from  Problem  where age%2=0    --查找Problem表格里面age为偶数的数据

select * from Problem  where  content  like  N'%喜欢%'   --查找。。。content里面包含'喜欢'关键字的数据

--UNICODE文档要加N,如N'源栈欢迎您！！！'


--使用这个显示上述结果
IF('ABCD' LIKE '_BC%') 
	SELECT 'true'
ELSE
	SELECT 'false'


比较运算符：<,>,=.不等于号为<>或!=。6 between 5 and 7   

IF(NULL=0)    --null是不能进行比较运算的,任何情况下都是fault，只能使用 IF(NULL IS NULL)


IF(1<any(SELECT ID from Problem))
IF(1<some(SELECT ID from Problem))          --any,some是只要其中有一个满足条件,结果就为真
IF(10>ALL(SELECT ID FROM Problem))            --all是集合里面的数据全部满足条件，结果才为真
IF(5 in (SELECT ID FROM Problem))             --in是指包含这个条件，结果为真

--注意： IF(null IN (SELECT NULL))  结果还是为假        


IF(EXISTS(SELECT ID FROM Problem))             --检查是否有返回数据，如果有，返回真。注意：行内ID为NULL，但其他列这行内有值，那么返回真。

--逻辑运算
IF(NOT 3<2)      --取反
IF(3>0 AND 5>2)  --和运算，并集。全部为真才是真
IF(3>0 OR 10<2)  --或运算，有一个为真就是真.全部为假才是假

IF(5>3 AND  2019/5/10>2019/8/20 OR 60<3 OR NOT 50>9)  --混合运算时，按照优先级进行运算。NOT>AND>OR.另外（）的优先级最大，建议使用（）


select * from student where Age is null      --查找所有数据未录入的学生

update Problem set Score+=10 where [datetime] between 2019/8/10 and 2019/10/1


--SQL4  homework

select * from [User] where Password  is null
delete [User] where username like [%N'管理员'% or %N'17bang'%]

update Problem set title=N'[推荐]'+title where Reward > 10         

update Problem set title=N'[加急]'+title where Reward >20 and Created > 2019/10/10

delete Problem where title like '#[%#]%'  ESCAPE '#'

SELECT [NAME] FROM Keyword where Used>10 and  Used<50

update KeyWord set Used=1 where  Used>=0 or Used is null or Used>100

delete Keyword WHERE Used%2=1    

--提出问题
--CREATE TABLE Solution(
-- ID  int  Primary key,
-- title  nvarchar(20)  not null,
-- content  nvarchar(max)  not null,
-- reward  nvarchar(20)  not null,  
--)

--insert Solution  values(1,N'标题',N'解决问题',N'是否要解决问题')

----只删除包含'问题'关键字 的reward列,不删除content列,怎么写？

--answer :无法对包含条件的列进行删除。





select TITLE+10 AS [NAME] from Problem      --在寻找结果上进行运算，也可以进行显示新的列名，列名也叫'别名'
select PublishDateTime+1 [name] from Problem     --一般可以省略as,这里只是显示上有，对原数据不进行更改

select distinct Age from Problem           -- distinct 是唯一.即相同的行会显示为同一行

select distinct Age,Number  from Problem     --有多行的情况下，必须要同时满足，才会显示一行


select top 5  Age  from Problem         --查找前5的数据
select distinct top 5 Age from Problem     --查找相同的前5的数据



排序
select * from Student order by Age       --进行排序	默认从小到大，
select * from Student order by Score desc      --进行排序，从大到小
select age,Score,id from Student order by score asc,Age DESC      --先按照score进行从小到大排序，然后再进行从大到小排序


--使用order 排序时候,null被认为无限小
分组，聚合函数
select Age,count(*) as [count] from Student  group by AGE        --按照AGE分组，并且将新行命名为count.count是统计个数的"聚合"函数
select Age,Score, count(score) as [count] from Student group by Age,Score   --先按照AGE，score分组，再统计score的个数

--注意：在select后面跟着的列名，必须要在group里面出现，否则会报错

除了count()以外，还有sum(),max(),min(),avg()函数。其中注意null值，在sum()中，null不进行+运算，在min()中，null为最小值，在avg()中，null忽略，不计入运算

select AGE,score,avg(score) from Student group by age,score    --求平均数

select age,sum(score) as [sum]  from student group by age having sum(score)>50     --可以使用having加判断条件


having和where的区别  having是在group中过滤，where是在group之前过滤





create table Problem(
   author NVARCHAR(20)  NULL,
   reward INT   NULL,
   title  NTEXT NULL,
   needhelp int NULL,
)
drop table Problem
INSERT Problem values(N'飞哥',3,N'数据库5',5)
INSERT Problem values(N'PZQ',4,N'数据库6',10)
INSERT Problem values(N'YWQ',5,N'数据库444',15)
INSERT Problem values(N'CY',6,N'数据库',20)
INSERT Problem values(N'AT',7,N'数据库55',25)
INSERT Problem values(N'JIMMY',8,N'数据库',30)
INSERT Problem values(N'王新',9,N'数据库155',35)
INSERT Problem values(N'ZJQ',10,N'数据库',40)
INSERT Problem values(N'CXB',11,N'数据库1',42)
INSERT Problem values(N'YJW',12,N'数据库1',50)
INSERT Problem values(N'飞哥',15,N'数据库5',88)
INSERT Problem values(N'飞哥',1,N'数据库5',60)

homework

1.查找出Author为“飞哥”的、Reward最多的3条求助（如果Reward有并列第三的数据，一并显示出来）
select top 3 needhelp,author,Reward from Problem where author=N'飞哥' order by reward desc
2.查找Title中第5个起，字符不为“数据库”的求助
select  from Problem where title not like  N'____%数据库%'


3.所有求助，先按作者“分组”，然后在“分组”中按悬赏从大到小排序
select  author,reward from Problem order by author asc,reward desc
4.查找并统计出每个作者的：求助数量、悬赏总金额和平均值
select author,count(needhelp) as [count]  from Problem  group by author          --求助数量

select author,sum(reward) as [sum]  from Problem  group by author                --悬赏总金额

select author,avg(reward) as [average]  from Problem  group by author            --平均值

select author ,count(needhelp) as [count],sum(reward) as [sum],avg(reward) as [average] from Problem  group by author


DECLARE @PAGE INT 
SET @PAGE = 10
PRINT RAND()*@page

create clustered index IX_student_AGE on student(AGE)

print year('2019/2/10')

select [Name] ,[type],is_unique,is_unique_constraint,is_primary_key  
from sys.indexes 
where object_id = OBJECT_ID('Student')

select  [name],[type],is_unique,is_unique_constraint, is_pirmary_key from sys.indexes 
where object_id=object_id('Student')  

select * from Student where [NAME]='xin'

print '   1   '
print '  333  '
print ' 55555 '
print '7777777'


alter table Student 
drop index Student.PK__Student__3214EC27FB5D2382






print dbo.YZadd(5,DEFAULT)

select * from  YuanZhan(1)

select * from  tableLine(1,N'于为谦')

--联表查出求助的标题和作者用户名

CREATE TABLE  [NeedHelp] (
    [ID]          INT           NOT NULL,

    TITLE         NVARCHAR(256) NULL,
	CONTENT       NVARCHAR(256) NULL,
	UserId        INT           NULL
);

SELECT * FROM NeedHelp
SELECT * FROM [USER]