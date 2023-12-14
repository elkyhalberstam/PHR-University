--getAllClasses - list of all current classes available 
CREATE PROC getFacultyList AS 
(
	SELECT Vperson.title + ' ' + Vperson.firstname +  ' ' + Vperson.lastname AS [name], title
	FROM Vperson 
	JOIN Vteacher ON Vperson.personID = Vteacher.personID
)

exec getFacultyList