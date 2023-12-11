Create view Vperson as
Select personID, firstName,lastName, 
middleIn, title, suffix, email
from person
where archived is Null

Create view Vadmin as
Select personID, adminID,position, 
accessLevel, campus, office
from [admin]
where archived is Null

Create view Vstudent as
Select personID, studentID, campus, 
majorID, minorID
from student
where archived is Null

Create view Vteacher as
Select personID, teacherID,campus, 
advisor, department, officeHours
from teacher
where archived is Null

Create view VstudentDynamic as
Select studentDynamicID, studentID, 
gpa, creditsComp, batchStatus
from studentDynamic
where archived is Null

Create view Vroom as
Select roomID, [location], floorNum,
roomNum, roomType, capacity
from room
where archived is Null

Create view Vmajor as
Select majorID, [name],
requiredCred
from major
where archived is Null

Create view Vminor as
Select minorID, [name],
requiredCred
from minor
where archived is Null

Create view Vcourse as
Select courseID, [name], 
department, creditsApplied
from course
where archived is Null

Create view Vclass as
Select classID, semester, timeID,
roomID, courseID, teacherID, classCapacity, roomType
from class
where archived is Null

Create view Vtime as
Select timeID, [days], duration,
startTime, endTime
from [time]
where archived is Null

Create view VstudentClassList as
Select studentClassListID, classID,
studentID, grades, addDrop
from studentClassList
where archived is Null


Select * from Vadmin
Select * from Vclass
Select * from Vcourse
Select * from Vmajor
Select * from Vminor
Select * from Vperson
Select * from Vroom
Select * from Vstudent
Select * from VstudentClassList
Select * from VstudentDynamic
Select * from Vteacher
Select * from Vtime