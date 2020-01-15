CREATE TABLE Student
(
   Id int IDENTITY PRIMARY KEY,
   [Name] NVARCHAR(128) ,
   Age SMALLINT
)

INSERT Student VALUES(N'cy',18)

SELECT * FROM Student

DELETE Student WHERE [Name]=N'yf'

UPDATE Student SET Age=18