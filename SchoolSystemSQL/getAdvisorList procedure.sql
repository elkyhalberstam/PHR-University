--get advisor list 
CREATE PROC getAdvisorList AS 
(
	SELECT Vperson.title + ' ' + Vperson.firstname +  ' ' + Vperson.lastname AS [name], title
	FROM Vperson 
	JOIN Vteacher ON Vperson.personID = Vteacher.personID
	WHERE Vteacher.advisor = 1
)
exec getAdvisorList