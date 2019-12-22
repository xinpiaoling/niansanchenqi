


CREATE TABLE Employee(
  Id  INT IDENTITY,
  Salary  INT ,
  City    NVARCHAR(20)
)

INSERT Employee VALUES(100,N'宁夏')
INSERT Employee VALUES(NULL,N'北京')
INSERT Employee VALUES(300,N'西安')
DELETE Employee WHERE ID =2

--SELECT * FROM Employee
SELECT ISNULL(Salary,NULL) FROM Employee WHERE ID=2
SELECT ISNULL(
(SELECT DISTINCT Salary  FROM Employee
WHERE Salary BETWEEN 2 AND 2 
ORDER BY Salary DESC),NULL)
AS SecondHighestSalary


 SELECT NULLIF((SELECT Salary FROM 
(
SELECT ROW_NUMBER() OVER(ORDER BY Salary DESC) AS seq 
,Salary  FROM Employee
)a
WHERE seq =2  ),NULL) AS SecondHighestSalary



select NULLIF((SELECT Salary FROM
(
SELECT Salary, row_number () OVER (ORDER BY Salary DESC) AS rn
FROM
(SELECT DISTINCT Salary FROM          --去重
Employee
) g
) a
WHERE rn = 2),NULL) AS SecondHighestSalary


GO

--DECLARE 
CREATE FUNCTION useFunction(@N INT)
RETURNS @t TABLE(getNthHighestSalary(@P) INT)        
AS
BEGIN
        /* Write your T-SQL query statement below. */  
		DECLARE @P INT ;
        IF(@N<1)
          SET @P=0;
        ELSE
          SET @P=@N;

    INSERT @t
	SELECT NULLIF((SELECT Salary FROM(
       SELECT Salary, row_number () OVER (ORDER BY Salary DESC) AS rn
       FROM (SELECT DISTINCT Salary FROM Employee) g) a
       WHERE rn = @P),NULL) AS getNthHighestSalary('@P')
 RETURN 

END
go

SELECT * FROM   dbo.useFunction(3)
DROP FUNCTION dbo.useFunction
UPDATE Employee SET Salary=200 WHERE Id=4

DECLARE @A NVARCHAR(20) =N'试试'
--PRINT @A
SELECT Id AS '+@A+',* FROM Employee  EXEC(@A)
SELECT * FROM Employee

IF NULL=NULL
  PRINT 2
ELSE
  PRINT 3