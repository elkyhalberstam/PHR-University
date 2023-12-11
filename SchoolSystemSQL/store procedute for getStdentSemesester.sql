Create procedure getStudentSchedule(@studentID int, @semester varchar(30)) as
with tempClassList as(
	Select classID, studentID, grades
	from studentClassList
	where studentID = @studentID
)
Select Vcourse.[name], semester, 
		[name] = tempTeacher.title +' ' +tempTeacher.firstname + ' ' +tempTeacher.lastname, 
		tempTeacher.advisor,
		[time] = Convert(varchar,Vtime.startTime) +' ' +Vtime.[days],
		Vroom.[location]
from Vclass
join tempClassList on tempClassList.classID = Vclass.classID
--join Vteacher on teacherID.Vteacher = teacherID.Vclass
join (Select Vteacher.teacherID, Vteacher.personID, Vperson.firstName, Vperson.lastName, Vperson.title, Vteacher.advisor
		from Vteacher
		join Vperson on Vperson.personID = Vteacher.teacherID)tempTeacher on tempTeacher.TeacherID = Vclass.teacherID
join Vtime on Vtime.timeID = Vclass.timeID
join Vroom on Vroom.roomID = Vclass.roomID
join Vcourse on Vcourse.courseID = Vclass.courseID
where semester = @semester

exec getStudentSchedule 2, 'Spring 2002'