--getGraduationStatisInfo
Create PROC getGraduationStatisInfo(@studentID int) as
with studentTemp as(
	select Vstudent.studentID, majorName = Vmajor.name, minorName = Vminor.name
	from Vstudent
	join Vmajor on Vstudent.majorID = Vmajor.majorID
	join Vminor on Vstudent.minorID = Vminor.minorID
	where studentID = @studentID
)
select batchStatus, gpa, majorName, minorName
from VstudentDynamic
join studentTemp on studentTemp.studentID = VstudentDynamic.studentID

--updateBatchStatus
Create PROC updateBatchStatus(@studentID int, @batchStatus int) as
UPDATE studentDynamic 
	SET batchStatus = @batchStatus
	WHERE studentDynamic.studentID = @studentID

--updateGPA
Create PROC updateGPA(@studentID int, @gpa int) as
UPDATE studentDynamic 
	SET gpa = @gpa
	WHERE studentDynamic.studentID = @studentID

--updateTotalCreditsCompleted
Create PROC updateTotalCreditsCompleted(@studentID int, @credits int) as
UPDATE studentDynamic 
	SET creditsComp = @credits
	WHERE studentDynamic.studentID = @studentID

--getAllStudentClasses
create PROC getAllStudentClasses(@studentID int) as
with classList as(
	select classID, grades
	from VstudentClassList
	where studentID = @studentID and addDrop = 1 and grades <> 'F' and grades <> 'W'
)
select [name], department, grades, semester, creditsApplied
from Vclass
join classList on Vclass.classID = classList.classID
join Vcourse on Vclass.courseID = Vcourse.courseID