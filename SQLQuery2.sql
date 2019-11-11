--CREATE FUNCTION YZadd(@ziyoufei int,@yuanzhan  int)
--RETURNS INT
--as
--BEGIN
--    RETURN @ziyoufei+@yuanzhan
--END


--ALTER FUNCTION YZadd(@ziyoufei int,@yuanzhan INT = 10)
--RETURNS INT
--WITH ENCRYPTION
--as
--BEGIN
--    RETURN @ziyoufei*@yuanzhan
--END

--alter FUNCTION YuanZhan(@ywq int)
--returns table
--return select top (@ywq) id from Student


--create function  tableLine(@id int ,@name NVARCHAR(20))
--RETURNS  @T TABLE (ID INT ,[NAME] NVARCHAR(20))
--BEGIN
--      INSERT @T VALUES(@id ,@name)
--      RETURN 
--END

--print dbo.delta(1,3)

--create function delta(@number int,@space int )
--returns  int
--as
--begin
--      while(@number<8)
--	  space(@space)+replicate(@number,@number)
--	  set @number+=2
--	  set @space=@space-1
--	  return @number
--end


--利用循环，打印如下所示的等腰三角形：
--   1 
--  333
-- 55555
--7777777

--declare @num  int = 1,@space int =3
--while  @num<8
--begin
--	  print space(@space)+replicate(@num,@num)
--	  set @num+=2
--	  set @space=@space-1
--end


--定义一个函数GetBigger(INT a, INT b)，可以取a和b之间的更大的一个值

--create function  GetBigger(@a int ,@b int)
--returns  int
--as
--begin
--DECLARE @RESULT INT
--if @a>@b
--SET @RESULT=@a
--else
--set @RESULT=@b
--return @result
--end

--print dbo.GetBigger(3,10)

--创建一个单行表值函数GetLatestPublish(INT n)，返回最近发布的n篇求助
--create function GetLatestPublsh(@n int)
--returns table
--return select top(@n) * from Student order by [datetime] desc

--alter table Student
--add  Publish int  null

--select * from GetLatestPublsh(2)


--创建一个多行表值函数GetByReward(INT n, BIT asc)，如果asc为1，返回悬赏最少的n位同学；否则，返回悬赏最多的n位同学。

--create function GetByReward(@A INT,@ASC BIT)
--RETURNS @T TABLE([NAME] NVARCHAR(20),[ASC] BIT)
--AS
--BEGIN
     
--	 IF @ASC=1
--	    INSERT @T SELECT TOP (@A) REWARD FROM Problem
--	 ELSE
--	    INSERT @T SELECT TOP (@A) REWARD FROM Problem order by REWARD desc
--	 RETURN
--END



--在表TProblem中：
--找出所有周末发布的求助（添加CreateTime列，如果还没有的话）
--SELECT * FROM TProblem where datepart(dw,createtime)=7 or datepart(dw,createtime)=1
--找出每个作者所有求助悬赏的平均值，精确到小数点后两位
--SELECT CONVERT(DECIMAL ,ROUND(AVG(reward*1.0),2)) AS [AVERAGE] FROM TProblem group by author 
--有一些标题以test、[test]后者Test-开头的求助，找打他们并把这些前缀都换成大写
--SELECT replace (title,'test','TEST') FROM TProblem WHERE TITLE LIKE 'test%'


--update TProblem
--set title=replace(title,'test','TEST')
--WHERE TITLE LIKE 'test%'

--SET TITLE='TEST'+SUBSTRING(TITLE,5,LEN(TITLE))


ALTER TABLE STUDENT
ADD CONSIRAINT FK_TEACHER_ID
FOREIGN KEY (ID)
REFERENCES TEACHER(ID)

alter table student
add constraint pk_student_id primary key(id) 

ALTER TABLE Student
drop PK__Student__3214EC27FB5D2382


alter table Student
add problem int 

CREATE TABLE Keyword(
 id  int not null PRIMARY KEY,
 [name] NVARCHAR(20) NULL 
)

CREATE TABLE Problem(
 id  int not null ,
 teacher  NVARCHAR(20) NOT NULL
)

--观察并模拟17bang项目中的：

--用户资料，新建用户资料（Profile）表，和Register形成1:1关联（有无约束？）。用SQL语句演示：
--新建一个填写了用户资料的注册用户
--通过Id查找获得某注册用户及其用户资料
--删除某个Id的注册用户

CREATE TABLE [Profile](
   RegisterID  int  identity primary key,
  [name] NVARCHAR(20)  NOT NULL,
  [data] NVARCHAR(256)  NOT NULL,
)

CREATE TABLE Register(
  ID  INT  NOT NULL,
  [name]  NVARCHAR(20) NOT NULL
)

ALTER TABLE [Profile]
add constraint FK_Register_id
foreign key (RegisterID)
references Register(ID)

INSERT [Profile] values(N'彭于晏',N'一个有肌肉的明星')
DECLARE @PID INT =@@IDENTITY 
INSERT  Register values(@PID,N'姓彭')




--帮帮点说明：新建Credit表，可以记录用户的每一次积分获得过程，即：某个用户，在某个时间，因为某某原因，获得若干积分
CREATE TABLE Credit(
   ID    INT   IDENTITY  PRIMARY KEY,
  [user]  NVARCHAR(20)  NULL,
  [datetime]  DATETIME  NOT NULL,
  reason  NVARCHAR(256)  NULL,
  score   FLOAT   NOT NULL
)
CREATE TABLE [User](
  Userid  int  not null,
  [name]  NVARCHAR(20) NOT NULL
)


ALTER TABLE  Credit
ADD CONSTRAINT  FK_Credit_ID
FOREIGN KEY(ID)
REFERENCES [User](Userid)

insert [User] values(2,N'yf')
insert Credit  values(N'wx',2019/2/10,N'上课迟到',85)

select * from  Credit
select * from [User]

--发布求助，在Problem和Register之间建立1:n关联（含约束）。用SQL语句演示：
--某用户发布一篇求助，
--将该求助的作者改成另外一个用户
--删除该用户的求助 

ALTER TABLE Problem
ADD CONSTRAINT FK_Problem_ID
FOREIGN KEY (RegisterID)
REFERENCES Register(ID)

INSERT Problem values ()       --插入求助内容

INSERT Register values (2)        --有外键的列，必须要从表有键值，主表才可以添加上
update Problem set authorid=2 where authorid=1     --@@IDENTITY 是全局变量。自增列的最后插入行的值


UPDATE Problem set Authorid=null where authorid=2

--求助列表：新建Keyword表，和Problem形成n:n关联（含约束）。用SQL语句演示：
--查询获得：某求助使用了多少关键字，某关键字被多少求助使用
--发布了一个使用了若干个关键字的求助
--该求助不再使用某个关键字
--删除该求助
--删除某关键字

CREATE TABLE Keyword(
  id  int  not null unique,
  [Studentname] NVARCHAR(20) NULL
)

CREATE TABLE Problem(
  id  int  not null unique,
  [Teachername] NVARCHAR(20) NULL
)

CREATE TABLE RelationTable(
   KeywordID  int  not null unique,
   ProblemID  int  not null unique
)

insert Keyword values(1,N'wx')
insert Keyword values(2,N'pzq')

insert Problem values(1,N'叶飞')
insert Problem values(2,N'余鑫')

insert RelationTable values(1,1)
insert RelationTable values(2,2)

ALTER TABLE RelationTable
ADD CONSTRAINT FK_RelationTable_KeywordID
FOREIGN KEY(KeywordID)
REFERENCES Keyword(ID)

ALTER TABLE RelationTable
ADD CONSTRAINT FK_RelationTable_ProblemID
FOREIGN KEY(ProblemID)
REFERENCES Problem(ID)



--select into 可以复制null，identity 不能复制主外键关系



--以Problem中的数据为基础，使用SELECT INTO，新建一个Author和Reward都没有NULL值的新表：NewProblem 
--（把原Problem里Author或Reward为NULL值的数据删掉）

--SELECT * INTO NewProblem  FROM Problem WHERE  Reward IS NOT NULL and Author IS NOT NULL
SELECT AUTHOR,REWARD INTO NewProblem FROM Problem  WHERE Reward IS NOT NULL AND Author IS NOT NULL

--使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中

--INSERT NewProblem select * from Problem where Reward is null

--使用OVER，统计出求助里每个Author悬赏值的平均值、最大值和最小值，
--然后用新表ProblemStatus存放上述数据

ALTER TABLE NewProblem
ADD [MIN] int null

INSERT NewProblem(AUTHOR,AVERAGE,[MAX],[MIN]) 
SELECT AUTHOR, AVG(Reward) OVER(PARTITION BY Author ORDER BY REWARD)AS AVERAGE,
MAX(Reward) OVER(PARTITION BY Author ORDER BY REWARD)AS [MAX],
MIN(Reward) OVER(PARTITION BY Author ORDER BY REWARD)AS [MIN]
FROM Problem 

SELECT AUTHOR, AVG(Reward) OVER(PARTITION BY Author )AS AVERAGE,
MAX(Reward) OVER(PARTITION BY Author )AS [MAX],
MIN(Reward) OVER(PARTITION BY Author )AS [MIN]
into NewProblem1
FROM Problem 



SELECT * FROM NewProblem1

--使用CASE...WHEN，颠倒Problem中的NeedRemote（以前是1的，现在变成0；以前是0的，现在变成1）

UPDATE Problem
SET NeedRemote =
CASE 
       WHEN NeedRemote=1  THEN 0
	   ELSE 1
END

--在表TProblem中：
--有一些标题以test、[test]后者Test-开头的求助，找打他们并把这些前缀都换成大写

UPDATE TProblem
SET TITLE =
CASE 
    WHEN  TITLE LIKE 'test%'  THEN  TEST+ SUBSTRING(TITLE,5,LEN(TITLE))
	WHEN  TITLE LIKE '#[test]%' ESCAPE '#' THEN TEST+ SUBSTRING(TITLE,5,LEN(TITLE))
	ELSE TITLE
END 
WHERE TITLE LIKE 'test%' OR TITLE LIKE '#[test]%' ESCAPE '#'


SELECT ID,[Name],SCORE,SCORE-(SELECT round(AVG(SCORE),1) FROM Student) AS gap FROM Student

INSERT Student VALUES(3,N'无语',0,2019/5/20,25,98,null,null)

select * from student

update Student set score= (select score from Student where id=1) where ID=3


SELECT *FROM Student WHERE ID NOT IN  (SELECT MAX(ID) FROM Student GROUP BY SCORE)

SELECT * FROM Student OE 
WHERE SCORE=
(SELECT MAX(SCORE)  FROM   STUDENT IE  
WHERE  OE.USERNAME=IE.UESRNAME  ) 


--使用子查询：
--删除每个作者悬赏最低的求助
DELETE Student AS OE where REWARD=(
SELECT MIN(REWARD) FROM Student IE where OE.AUTHOR=IE.AUTHOR)



DELETE STUDENT
WHERE REWARD  IN (
SELECT MIN(REWARD) FROM Student GROUP BY Author)

SELECT * FROM Student

ALTER TABLE Student
--ADD AUTHOR NVARCHAR(20)  NULL 
DROP COLUMN PUBLISH,PROBLEM

INSERT Student(AUTHOR) VALUES(N'美梦')  WHERE ID=1

ALTER TABLE Student
ALTER COLUMN AUTHOR=N'美梦'  WHERE ID=1

UPDATE Student SET AUTHOR=N'美梦' WHERE ID=1 


CREATE TABLE NeedHelp(
   ID INT PRIMARY KEY ,
   [USER]  NVARCHAR(20)  NULL,
   INVITE NVARCHAR(20)  NULL,
   REWARD INT  ,
   REQUEST  NVARCHAR(20) ,
   ESSAY  INT  ,
   PUBLISHTIME DATETIME NOT NULL,

)


--使用子查询：
--删除每个作者悬赏最低的求助

DELETE NeedHelp WHERE ID IN(
SELECT ID FROM NeedHelp OE WHERE REWARD IN
(SELECT MIN(REWARD) FROM NeedHelp IE WHERE OE.[USER]=IE.[USER] GROUP BY [USER]))


--找到从未成为邀请人的用户
SELECT * FROM NeedHelp 
WHERE ID NOT IN(SELECT INVITEBY FROM NeedHelp)

--查出所有发布一篇以上（不含一篇）文章的用户信息


SELECT * FROM [USER] WHERE  ID=(SELECT ID FROM SS WHERE ESSAYNUMBER >1)



--为求助添加一个发布时间（PublishTime），查找每个作者最近发布的一篇文章
SELECT TITLE FROM NeedHelp WHERE ID IN 
(SELECT ID FROM NeedHelp  [ON]  where PublishTime =
(SELECT  MAX(PublishTime) OVER(PARTITION BY AUTHOR) FROM  NeedHelp  [IN] 
WHERE [IN].AUTHOR=[ON].AUTHOR))


--查出每一篇求助的悬赏都大于5个帮帮币的作者
----SELECT * FROM NEEDHELP
----SELECT [USER],MAX(REWARD) AS [MAX] FROM NEEDHELP  GROUP BY [USER]
----SELECT [USER],MAX(REWARD)  OVER(PARTITION BY [USER])AS [MAX] FROM NeedHelp

-- SELECT * FROM NeedHelp  [NO]
-- WHERE REWARD  IN (SELECT  MIN(REWARD) FROM NeedHelp NI GROUP BY [USER]
-- WHERE NI.[USER] =[NO].[USER])

-- SELECT * FROM Problem WHERE AUTHOR IN 
-- (SELECT AUTHOR  FROM Problem GROUP BY AUTHOR HAVING MIN(Reward)>5)

 select author from problem group by  author having min(Reward)>5 
 select * from problem



--根据Exam的Age进行分组，获取每个年龄段的前三位成绩最好的同学\
CREATE TABLE Exam(
 Id   int identity ,
 [Name] NVARCHAR(20) ,
 Age INT  ,
 SCORE INT 
)
INSERT Exam VALUES (N'飞羽0',15,85)
INSERT Exam VALUES (N'飞羽1',20,90)
INSERT Exam VALUES (N'飞羽2',15,65)
INSERT Exam VALUES (N'飞羽3',18,20)
INSERT Exam VALUES (N'haku',29,50)
INSERT Exam VALUES (N'飞羽4',15,100)
INSERT Exam VALUES (N'飞羽5',15,68)
SELECT * FROM Exam

SELECT * FROM (
SELECT *,ROW_NUMBER() OVER(PARTITION BY AGE ORDER BY SCORE DESC) AS RO FROM EXAM ) EO
WHERE EO.RO<4 



--派生表的格式为 将条件检索出来的表作为外表，（）进行再次条件检索

--分别使用派生表和CET，查询求助表（表中只有一列整体的发布时间，没有年月的列），以获得：

--一起帮每月各发布了求助多少篇
--每月发布的求助中，悬赏最多的3篇
--每个作者，每月发布的，悬赏最多的3篇
--分别按发布时间和悬赏数量进行分页查询的结果


--一起帮每月各发布了求助多少篇
--派生表
SELECT  ENROLLYEAR,ENROLLMONTH,count(*) FROM  
(SELECT *,YEAR(ENROLL) AS ENROLLYEAR ,
MONTH(ENROLL) AS ENROLLMONTH FROM Student) EnrollStudent
GROUP BY ENROLLYEAR,ENROLLMONTH
----CET
--WITH EnrollStudent
--AS
--(SELECT *,YEAR(ENROLL) AS ENROLLYEAR ,MONTH(ENROLL) AS ENROLLMONTH FROM Student)
--SELECT ENROLLYEAR,ENROLLMONTH, COUNT(*)
--FROM EnrollStudent GROUP BY ENROLLYEAR,ENROLLMONTH

--每月发布的求助中，悬赏最多的3篇
--派生表
--SELECT * FROM( 
--SELECT ROW_NUMBER()  
--OVER(PARTITION BY ENROLLYEAR,ENROLLMONTH ORDER BY Score DESC) AS RN,
--* FROM  (SELECT *,YEAR(ENROLL) AS ENROLLYEAR ,
--MONTH(ENROLL) AS ENROLLMONTH FROM Student) EnrollStudent)E WHERE E.RN BETWEEN 1 AND 3
--简化写法
SELECT * FROM (
SELECT ROW_NUMBER() OVER (PARTITION BY YEAR(ENROLL),MONTH(ENROLL) 
ORDER BY SCORE) AS R ,* FROM  Student ) EnrollStudent WHERE  EnrollStudent.R BETWEEN 1 AND 3

----CET
WITH EnrollStudent
AS
(SELECT *, ROW_NUMBER() OVER(PARTITION BY YEAR(Enroll),MONTH(Enroll) ORDER BY SCORE DESC)
AS RN FROM Student)
SELECT * FROM EnrollStudent WHERE EnrollStudent.RN BETWEEN 1 AND 3

--每个作者，每月发布的，悬赏最多的3篇
--派生表
SELECT  * FROM 
(select * ,ROW_NUMBER() OVER (PARTITION BY AUTHOR,YEAR(ENROLL),MONTH(ENROLL)
ORDER BY SCORE DESC)AS RN FROM Student) EN WHERE EN .RN BETWEEN 1 AND 3 

------CET
WITH EnrollStudent
AS
(SELECT *, ROW_NUMBER() OVER (PARTITION BY AUTHOR,YEAR(ENROLL),MONTH(ENROLL) 
ORDER BY SCORE DESC )AS RN FROM Student )
SELECT * FROM EnrollStudent WHERE EnrollStudent.RN BETWEEN 1 AND 3

--分别按发布时间和悬赏数量进行分页查询的结果
SELECT * FROM Student ORDER BY [Enroll]
OFFSET 1 ROWS
FETCH  NEXT 3 ROWS  ONLY

SELECT * FROM Student ORDER BY Score
OFFSET 1 ROWS
FETCH NEXT 3 ROWS ONLY

GO

CREATE VIEW  V_Credit 
AS 
SELECT 
 ID  ,
 [USER]
FROM Credit
--视图没有索引，没有约束
SELECT * FROM V_Credit
SELECT * FROM Credit

UPDATE V_Credit SET [USER]='SS' WHERE ID=1

DROP view V_Credit 

DELETE 

go

CREATE VIEW V_Student ([Year],[Month],[Day],Age,Score)
AS
SELECT  year(enroll) AS [YEAR],month(enroll) AS [MONTH],day(enroll) AS [DATE]
,Age,Score  from Student

select * from Student 
select * from V_Student 

--创建求助的应答表 Response(Id, Content, AuthorId, ProblemId, CreateTime)
CREATE TABLE Response (
 ID INT  IDENTITY PRIMARY KEY,
 Content NVARCHAR(256)  NULL,
 AuthorId  INT   NULL,
 ProblemId  INT  NULL,
 CreateTime  INT  NULL
)

GO
--然后生成一个视图 Response(ResponseId, Content,  ReponseAuthorName,
--ProblemId, ProblemAuthorName, ProblemTitle, CreateTime)，要求该视图：
--能展示应答作者的用户名、应答对应求助的标题和作者用户名 	（JOIN）	
--只显示求助悬赏值大于5的数据   （JOIN）
--已被加密 		
--保证其使用的基表结构无法更改

CREATE VIEW V_Response(
ResponseId,
Content,
ReponseAuthorName,
ProblemId,
ProblemAuthorName,
ProblemTitle,
CreateTime)
WITH SCHEMABINDING      --绑定表结构
--WITH ENCRYPTION         --加密
AS 
SELECT R.Id,
R.Content,
R.AuthorName,
P.Id,
P.AuthorName,
P.Title,
R.CreateTime 
FROM Response R JOIN Problem P   ON R.ProblemId=P.Id   
                JOIN [USER]  UR  ON R.AuthorId =UR.ID
				JOIN [USER]  UP  ON P.AuthorId =UP.ID
WHERE P.Reward > 5


--演示：在VVResponse中插入一条数据，却不能在视图中显示

CREATE VIEW  VV_Response
AS
SELECT * FROM Response
WHERE Response.ProblemId<5

SELECT * FROM VV_Response

INSERT VV_Response VALUES('WUWUWU',1,10,3)


--修改Response，让其能避免上述情形
ALTER VIEW VV_Response
AS
SELECT * FROM Response
WHERE Response.ProblemId < 5
WITH CHECK OPTION 

INSERT VV_Response VALUES(N'无卡',2,10,5)    --不能插入

--创建视图VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)，要求该视图：
--能反映求助的标题、使用关键字数量和悬赏
--在ProblemId上有一个唯一聚集索引
--在ProblemReward上有一个非聚集索引
go
--CREATE VIEW V_ProblemKeyword1 (
--ProblemId,ProblemTitle,ProblemReward,Keyword1Amount)
--WITH SCHEMABINDING
--AS
--SELECT Problem.id,Problem.Title,Problem.Reward,Keyword1.Amount 
--FROM dbo.Problem inner JOIN dbo.Keyword1
--ON Problem.Keyword1id =Keyword1.Id
CREATE VIEW V_ProblemKeywordTest
WITH SCHEMABINDING
SELECT     FROM Problem join Keyword
GO

CREATE UNIQUE CLUSTERED INDEX V_INDEX
ON V_ProblemKeyword1(ProblemId)


CREATE   NONCLUSTERED INDEX V_INDEX_Reward
ON V_ProblemKeyword1(ProblemReward)



--在基表中插入/删除数据，观察VProblemKeyword是否相应的发生变化
SELECT * FROM V_ProblemKeyword1
INSERT Problem values (7,N'柳絮',N'飘飞',68,N'萨克斯看')
INSERT Keyword1 values (7,N'闪烁',10,54)

--因为是内连接，所以要把两个表都添加数据才会显示

DELETE Problem WHERE ID =7 
DELETE 


--因为是内连接。正常的删除一个表的一行，视图表随着变化删除


--联表查出求助的标题和作者用户名
SELECT * FROM NeedHelp
SELECT * FROM [USER]
go
SELECT NeedHelp.TITLE,[User].[name] FROM
NeedHelp JOIN  [User]
ON NeedHelp.UserId=[User].Userid

--查找并删除从未发布过求助的用户
DELETE [user] WHERE [USER].[USERID] NOT IN (SELECT NeedHelp.USERID 
FROM NeedHelp)


INSERT [User] VALUES(5,'SI',N'叶飞')

DELETE [User]
FROM NeedHelp n RIGHT JOIN [User] u ON n.UserId=u.Userid 
WHERE n.UserId IS NULL



--用一句SELECT显示出用户和他的邀请人用户名
SELECT [NAME],INVITE FROM [USER] 

--17bang的关键字有“一级”“二级”和其他“普通级”的区别：
--请在表Keyword中添加一个字段，记录这种关系
--然后用一个SELECT语句查出所有普通关键字的上一级、以及上上一级的关键字名称，比如：
CREATE TABLE Keyword (
  Id   int   NULL,
  keywords  NVARCHAR(20),
  SecondLevel  NVARCHAR(20),
  FirstLevel   NVARCHAR(20)
)
SELECT * FROM Keyword
--常规的两个JOIN 可以做出来
SELECT  bk.keywords,ak.keywords,CK.keywords
FROM Keyword ak right join Keyword bk ON ak.Id=bk.SecondLevel 
                left join keyword  CK ON AK.SecondLevel=CK.ID
--使用FULL JION 最左侧列会出现NULL，与需求不符合
SELECT  bk.keywords,ak.keywords,CK.keywords
FROM Keyword ak FULL join Keyword bk ON ak.Id=bk.SecondLevel 
                FULL join keyword  CK ON AK.SecondLevel=CK.ID
--使用表表达式也可以做出来
SELECT  abk.akk,abk.bkk,CK.keywords
FROM (SELECT ak.keywords as akk,bk.keywords as bkk,bk.SecondLevel AS bs FROM Keyword ak 
left JOIN Keyword bk ON ak.SecondLevel=bk.Id) as abk 
LEFT JOIN Keyword ck ON abk.bs=ck.Id




--SELECT qq.akk ,qq.bkk,ck.keywords 
--FROM
--(
--SELECT AK.id, bk.keywords as bkk,ak.keywords as  akk,bk.FirstLevel AS bkf
--FROM Keyword ak right join Keyword bk
--ON ak.Id=bk.SecondLevel) as qq right join Keyword ck 
--ON qq.bkf =ck.id 

SELECT 
--CK.keywords,
bk.keywords,
ak.keywords 
FROM (Keyword ak 
right join Keyword bk ON ak.Id=bk.SecondLevel)
left join Keyword ck ON ak.Id=ck.SecondLevel


--17bang中除了求助（Problem），还有意见建议（Suggest）和文章（Article），
--他们都包含Title、Content、PublishTime和Auhthor四个字段，但是：
--建议和文章没有悬赏（Reward）
--建议多一个类型：Kind NVARCHAR(20)）
--文章多一个分类：Category INT）
--请按上述描述建表。
--然后，用一个SQL语句按显示某用户发表的求助、建议和文章的Title、Content，
--并按PublishTime降序排列

CREATE TABLE Problem1(
   Id    INT, 
   Title   NVARCHAR(20),
   Content   NVARCHAR(256),
   PublishTime   DATETIME,
   Author      NVARCHAR(20),
   Reward     INT
)
CREATE TABLE Suggest(
   Id    INT, 
   Title   NVARCHAR(20),
   Content   NVARCHAR(256),
   PublishTime   DATETIME,
   Author      NVARCHAR(20),
   Kind NVARCHAR(20)
)
CREATE TABLE Article(
   Id    INT, 
   Title   NVARCHAR(20),
   Content   NVARCHAR(256),
   PublishTime   DATETIME,
   Author      NVARCHAR(20),
   Category INT
)

SELECT  Title,Content FROM Problem1
UNION
SELECT  Title,Content FROM Suggest
UNION
go
SELECT  Title,Content FROM Article
where Author =N'XI'
ORDER BY PublishTime


--事务

BEGIN TRY 
       BEGIN TRANSACTION
	    UPDATE Student SET SCORE +=100 WHERE [NAME]=N'xin'

	   COMMIT TRANSACTION         --没有异常就会提交事务
END TRY
BEGIN CATCH
       ROLLBACK                  -- 有异常就会回滚事务
END CATCH


CREATE TABLE TESS(Id INT NOT NULL)
SELECT * FROM TESS
BEGIN TRAN
   INSERT TESS VALUES(NULL)
   INSERT TESS VALUES('2')
COMMIT TRAN

-- SQL还是会执行第2个语句。因为他默认回滚错误的语句，继续执行其他的语句。

SET XACT_ABORT ON
BEGIN TRAN
   INSERT TESS VALUES(NULL)
   INSERT TESS VALUES('3')
COMMIT TRAN



SELECT * FROM sys.objects


--用户（Reigister）发布一篇悬赏币若干的求助（Problem），他的帮帮币（BMoney）也会相应减少，
--但他的帮帮币总额不能少于0分：请综合使用TRY...CATCH和事务完成上述需求。
CREATE TABLE ProblemC(
   Id  INT  PRIMARY KEY IDENTITY,
   UserId  INT,    
   Title   NVARCHAR(20),
   Body    NVARCHAR(256)
)

DROP TABLE ProblemB

go
BEGIN TRAN
  BEGIN TRY
      BEGIN  TRAN   
	    SAVE TRAN INNER_TRAN
      INSERT ProblemC  VALUES(1,N'发布6',N'文章6')   
	  UPDATE [User] SET BMoney-=100 WHERE [Name]=N'叶飞'  
	  COMMIT TRAN   
  END TRY  
  BEGIN CATCH
      ROLLBACK TRAN INNER_TRAN;           
  END CATCH  
  
COMMIT TRAN

PRINT @@TRANCOUNT
COMMIT TRAN

 SELECT * FROM ProblemC
 SELECT * FROM [User]





 SET IMPLICIT_TRANSACTIONS ON              --隐式事务的开启
       INSERT ProblemC  VALUES(1,N'发布6',N'文章6')   
	  UPDATE [User] SET BMoney-=100 WHERE [Name]=N'叶飞'  
	  ROLLBACK
 SET IMPLICIT_TRANSACTIONS ON              --隐式事务的关闭

 --隐式事务和显式事务是一样的。只是另一种写法，推荐使用显式事务。

 --事务的四大特性：持续性，原子性，持续性，隔离性


 DBCC USEROPTIONS      -- 查看当前连接的隔离级别


BEGIN TRAN
 UPDATE Student SET Score=30 WHERE [Name]=N'菜鸡'
 

 ROLLBACK


 SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED