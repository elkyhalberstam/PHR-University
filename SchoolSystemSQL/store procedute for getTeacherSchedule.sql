Create procedure getTeacherSchedule(@teacherID int, @semester varchar(30)) as
with tempClasses as(
	Select ClassID, semester, timeID, roomID, teacherID
	from Vclass
	where teacherID = @teacherID and semester = @semester
)
Select Vcourse.[name], tempClasses.semester,
		[time] = Convert(varchar,Vtime.startTime) +' ' +Vtime.[days],
		Vroom.[location]
from Vclass
join tempClasses on tempClasses.teacherID = Vclass.teacherID
join Vtime on Vtime.timeID = Vclass.timeID
join Vroom on Vroom.roomID = Vclass.roomID
join Vcourse on Vcourse.courseID = Vclass.courseID

exec getTeacherSchedule 3, 'Fall 2002'