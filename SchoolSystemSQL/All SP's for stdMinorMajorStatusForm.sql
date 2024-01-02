--switchMinor
Create PROC switchMinor(@studentID int, @minorID int) as
UPDATE student 
	SET minorID = @minorID
	WHERE student.studentID = @studentID

--switchMajor
Create PROC switchMajor(@studentID int, @majorID int) as
UPDATE student 
	SET majorID = @majorID
	WHERE student.studentID = @studentID

--getAllMinors
Create PROC getAllMinors as
Select [name], minorID
from minor

--getAllMajors
Create PROC getAllMajors as
Select [name], majorID
from major

--getStudentClassesFromMinor
Create PROC getStudentClassesFromMinor(@studentID int, @minor varchar(50)) as
with classList as(
	select classID 
	from VstudentClassList
	where studentID = @studentID and addDrop = 1 and grades <> 'F' and grades <> 'W'
)
select creditsApplied
from Vclass
join classList on Vclass.classID = classList.classID
join Vcourse on Vclass.courseID = Vcourse.courseID
where department = @minor


--getMinorInfo
Create PROC getMinorInfo(@minorID int) as
select [name], requiredCred
from Vminor
where minorID = @minorID

--getStudentClassesFromMajor
Create PROC getStudentClassesFromMajor(@studentID int, @major varchar(50)) as
with classList as(
	select classID 
	from VstudentClassList
	where studentID = @studentID and addDrop = 1 and grades <> 'F' and grades <> 'W'
)
select creditsApplied
from Vclass
join classList on Vclass.classID = classList.classID
join Vcourse on Vclass.courseID = Vcourse.courseID
where department = @major

--getMajorInfo
Create PROC getMajorInfo(@majorID int) as
select [name], requiredCred
from Vmajor
where majorID = @majorID

--getStudentMajorMinorID
Create PROC getStudentMajorMinorID(@studentID int) as
select majorID, minorID 
from Vstudent
where studentID = @studentID
