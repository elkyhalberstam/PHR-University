-- all classes of current semseter with room time and teacher
Alter procedure getSemesterClasses(@semester varchar(30)) as
Begin
with tempClassList as(
	Select ClassID, semester, timeID, roomID, teacherID
	from Vclass
	where semester = @semester
)
Select Vcourse.[name], 
		[name] = tempTeacher.title +' ' +tempTeacher.firstname + ' ' +tempTeacher.lastname, 
		tempTeacher.advisor,
		[time] = Convert(varchar,Vtime.startTime) +' ' +Vtime.[days],
		Vroom.[location],
		[room] = STR(floorNum) +' - ' +STR(roomNum),
		Vcourse.department
from Vclass
join tempClassList on tempClassList.classID = Vclass.classID
join (Select Vteacher.teacherID, Vteacher.personID, Vperson.firstName, Vperson.lastName, Vperson.title, Vteacher.advisor
		from Vteacher
		join Vperson on Vperson.personID = Vteacher.teacherID)tempTeacher on tempTeacher.TeacherID = Vclass.teacherID
join Vtime on Vtime.timeID = Vclass.timeID
join Vroom on Vroom.roomID = Vclass.roomID
join Vcourse on Vcourse.courseID = Vclass.courseID
end 
go  
