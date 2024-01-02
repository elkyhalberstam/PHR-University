--getStudentSchedule
Create procedure getStudentSchedule(@studentID int, @semester varchar(30)) as
with tempClassList as(
	Select classID, studentID, grades
	from studentClassList
	where studentID = @studentID

--getCurrentSemesterSTD
Create procedure getCurrentSemesterSTD (@studentID int) as
with studentClasses as(
	select classID
	from VstudentClassList
	where studentID = @studentID and isnull(grades,'') <> ''
)
Select semester
from Vclass
join studentClasses on studentClasses.classID = Vclass.classID