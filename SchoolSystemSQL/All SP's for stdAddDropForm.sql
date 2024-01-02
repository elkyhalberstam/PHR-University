-- addDropClassProcedure
Alter PROC addDropClassProcedure(@studentID int, @classID int, @addDrop int) as
Insert into studentClassList (classID, studentID, addDrop, grades)
values(@classID, @studentID, @addDrop, '')

--addDropClassUpdate
CREATE PROC addDropClassUpdate(@studentID int, @classID int) as
UPDATE studentClassList 
	SET archived = GETDATE()
	WHERE studentClassList.classID = @classID and studentClassList.studentID = @studentID


--getStudentSchedule
Create procedure getStudentSchedule(@studentID int, @semester varchar(30)) as
with tempClassList as(
	Select classID, studentID, grades
	from studentClassList
	where studentID = @studentID
)
Select tempClassList.classID, Vcourse.[name], semester, 
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

--getAllClassesInSemester
Create procedure getAllClassesInSemester (@semester varchar(30)) as
select classID, [name]
from Vclass
join Vcourse on Vclass.courseID = Vcourse.courseID
where semester = @semester

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


--getSemesterList
Create procedure getSemesterList as
Select distinct semester 
from Vclass