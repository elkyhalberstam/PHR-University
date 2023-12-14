--get list of all current faculty 
CREATE PROC getFacultyList AS 
(
	SELECT Vperson.title + ' ' + Vperson.firstname +  ' ' + Vperson.lastname AS [name], title
	FROM Vperson 
	JOIN Vteacher ON Vperson.personID = Vteacher.personID
)

exec getFacultyList
