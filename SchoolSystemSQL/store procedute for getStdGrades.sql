Create procedure getStudentGrades(@studentID int) as
with tempClassList as(
	Select classID, studentID, grades
	from studentClassList
	where studentID = @studentID
)
Select Vcourse.[name], semester, tempClassList.grades
from Vclass
join tempClassList on tempClassList.classID = Vclass.classID
join Vcourse on Vcourse.courseID = Vclass.courseID

exec getStudentGrades 3