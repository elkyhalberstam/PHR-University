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