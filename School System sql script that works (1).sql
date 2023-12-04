Drop database SchoolSystem
GO

CREATE database SchoolSystem
GO

USE SchoolSystem;
GO

Create TABLE dbo.person (
	personID int NOT NULL  identity(1,1),
	firstName varchar (15) NOT NULL,
	lastName varchar (15) NOT NULL,
	middleIn char,
	title varchar (15),
	suffix varchar (15),
	email varchar (100) NOT NULL,
	CONSTRAINT [PK_person] primary key clustered(personID asc),
	CONSTRAINT [UK_email] unique ([email]),
	CONSTRAINT [UK_person] unique (firstName, lastName, middleIn, title, suffix),
	--new column to distinguish?
	) 
Create TABLE dbo.admin (
	adminID int NOT NULL  identity(1,1),
	personID int NOT NULL,
	position varchar (25) NOT NULL,
	accessLevel int NOT NULL,
	campus varchar (30) NOT NULL,
	office varchar (30) NOT NULL,
	CONSTRAINT [PK_admin] primary key clustered(adminID asc),
	CONSTRAINT [FK_personAdminForeign] foreign key (personID) REFERENCES person (personID),
	CONSTRAINT [UK_adminPerson] unique (adminID, personID)
	) 

CREATE TABLE dbo.teacher (
	teacherID int NOT NULL  identity(1,1),
	personID int NOT NULL,
	campus varchar (30) NOT NULL,
	advisor int,
	department varchar (30) NOT NULL,
	officeHours varchar (75),
	CONSTRAINT [PK_teacher] primary key clustered(teacherID asc),
	CONSTRAINT [FK_personTeacherForeign] foreign key (personID) REFERENCES person (personID),
	CONSTRAINT [UK_teacherPerson] unique (teacherID, personID),
	) 

CREATE TABLE dbo.major (
	majorID int identity (1,1) NOT NULL,
	[name] varchar (30) NOT NULL,
	requiredCred int NOT NULL,
	CONSTRAINT [PK_major] primary key (majorID)
	)

CREATE TABLE dbo.minor (
	minorID int identity (1,1) NOT NULL,
	[name] varchar (30) NOT NULL,
	requiredCred int NOT NULL,
	CONSTRAINT [PK_minor] primary key (minorID)
	)

CREATE TABLE dbo.student (
	studentID int NOT NULL  identity(1,1),
	personID int NOT NULL,
	campus varchar (30) NOT NULL,
	majorID int NOT NULL,
	minorID int,
	CONSTRAINT [PK_student] primary key clustered(studentID asc),
	CONSTRAINT [FK_personStudentForeign] foreign key (personID) REFERENCES person (personID),
	--should we put student dynamic as a foreign key yes
	CONSTRAINT [FK_major] foreign key (majorID) REFERENCES major (majorID),
	CONSTRAINT [FK_minor] foreign key (minorID) REFERENCES minor (minorID),
	CONSTRAINT [UK_studentPerson] unique (studentID, personID),
	) 
	
CREATE TABLE dbo.studentDynamic (
	studentDynamicID int NOT NULL identity (1,1),
	studentID int NOT NULL,
	gpa float NOT NULL,
	creditsComp int NOT NULL,
	batchStatus varchar (15) NOT NULL,
	CONSTRAINT [PK_studentDynamic] primary key (studentDynamicID),
	CONSTRAINT [FK_student] foreign key (studentID) REFERENCES student (studentID),
	)


CREATE TABLE dbo.room (
	roomID int NOT NULL identity (1,1),
	[location] varchar (30) NOT NULL,
	floorNum int NOT NULL,
	roomNum int NOT NULL,
	roomType varchar (30) NOT NULL,
	capacity int NOT NULL,
	CONSTRAINT [PK_room] primary key (roomID asc),
	CONSTRAINT [UK_uniqueRoom] unique (floorNum, roomNum, [location]),
	)

CREATE TABLE dbo.course (
	courseID int NOT NULL identity (1,1),
	[name] varchar (45) NOT NULL,
	department varchar (30) NOT NULL,
	creditsApplied int NOT NULL,
	CONSTRAINT [PK_course] primary key (courseID asc),
	)

CREATE TABLE dbo.[time] (
	timeID int NOT NULL identity (1,1),
	[days] varchar (20) NOT NULL,
	duration int NOT NULL, --minutes 
	startTime time NOT NULL,
	endTime time NOT NULL,
	CONSTRAINT [PK_time] primary key (timeID asc),
	CONSTRAINT [UK_uniqueTime] unique ([days], startTime, endTime),
	)

CREATE TABLE dbo.class (
	classID int NOT NULL identity (1,1),
	semester varchar(20) NOT NULL,
	timeID int NOT NULL,
	roomID int,
	courseID int NOT NULL,
	teacherID int,
	classCapacity int NOT NULL,
	roomType varchar(30),
	CONSTRAINT [PK_class] primary key (classID asc),
	CONSTRAINT [UK_uniqueClass] unique (semester, timeID, roomID),
 	CONSTRAINT [FK_time] foreign key (timeID) REFERENCES [time] (timeID),
	CONSTRAINT [FK_room] foreign key (roomID) REFERENCES room (roomID),
	CONSTRAINT [FK_course] foreign key (courseID) REFERENCES course (courseID),
	CONSTRAINT [FK_teacher] foreign key (teacherID) REFERENCES teacher (teacherID)
)

CREATE TABLE dbo.studentClassList (
	studentClassListID int NOT NULL identity (1,1),
	classID int NOT NULL,
	studentID int NOT NULL,
	grades varchar(2),
	addDrop int,
	CONSTRAINT [PK_studentClassList] primary key (studentClassListID),
	CONSTRAINT [FK_class] foreign key (classID) REFERENCES class (classID),
	CONSTRAINT [FK_studentClassListFK] foreign key (studentID) REFERENCES student (studentID),
	)

--schoolsystemtables.sql
--Displaying schoolsystemtables.sql.
--Insert Person sheet 
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Emma','Smith','A','Professor','','Emma.Smith@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Liam','Johnson','B','Mr.','','Liam.Johnson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Olivia','Brown','C','Miss','','Olivia.Brown@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Noah','Davis','D','Dr.','IV','Noah.Davis@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Ava','Wilson','E','Mrs.','','Ava.Wilson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Isabella','Lee','F','Miss','','Isabella.Lee@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Sophia','Harris','G','Miss','','Sophia.Harris@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Mia','Patel','H','Mr.','','Mia.Patel@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Charlotte','Miller','I','Miss','','Charlotte.Miller@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Amelia','Anderson','J','Dr.','','Amelia.Anderson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Harper','Jackson','K','Mr.','','Harper.Jackson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Evelyn','Thompson','L','Mr.','','Evelyn.Thompson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Abigail','White','M','Miss','','Abigail.White@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Emily','Martin','N','Mrs.','','Emily.Martin@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Elizabeth','Garcia','O','Miss','','Elizabeth.Garcia@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Sofia','Martinez','P','Mr.','','Sofia.Martinez@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Scarlett','Jones','Q','Mr.','','Scarlett.Jones@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Madison','Clark','R','Mr.','','Madison.Clark@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Grace','Taylor','S','Dr.','D.D.S. ','Grace.Taylor@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Lily','Lewis','T','Miss','','Lily.Lewis@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Aria','Walker','U','Miss','','Aria.Walker@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Chloe','Hall','V','Mr.','','Chloe.Hall@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Ella','Turner','W','Mrs.','C.P.A. ','Ella.Turner@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Avery','Adams','X','Dr.','','Avery.Adams@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Riley','Wright','Y','Mr.','','Riley.Wright@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Zoey','King','Z','Mr.','','Zoey.King@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Aiden','Hill','','Professor','','Aiden.Hill@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Mason','Scott','','Dr.','','Mason.Scott@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'James','Green','','Professor','','James.Green@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Benjamin','Baker','','Mr.','','Benjamin.Baker@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Lucas','Carter','','Mr.','','Lucas.Carter@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Henry','Murphy','','Mr.','','Henry.Murphy@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Alexander','Rodriguez','','Mr.','','Alexander.Rodriguez@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'William','Hall','','Mr.','','William.Hall@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Michael','Thomas','','Mr.','','Michael.Thomas@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Elijah','Young','','Sir','Sr. ','Elijah.Young@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Daniel','Wright','','Dr.','M.D. ','Daniel.Wright@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Oliver','Allen','','Mr.','','Oliver.Allen@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Matthew','Mitchell','','Dr.','','Matthew.Mitchell@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Joseph','Lopez','','Dr.','','Joseph.Lopez@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'David','Hall','','Mr.','','David.Hall@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Josephine','Walker','','Mrs.','','Josephine.Walker@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Samuel','Parker','','Professor','','Samuel.Parker@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Ethan','Roberts','','Mr.','','Ethan.Roberts@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Jackson','Morris','','Mr.','','Jackson.Morris@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Sebastian','Edwards','','Dr.','','Sebastian.Edwards@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Jack','Evans','','Sir','','Jack.Evans@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Owen','Stewart','','Mr.','III ','Owen.Stewart@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Dylan','Kim','','Mr.','','Dylan.Kim@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Luke','Johnson','','Mr.','','Luke.Johnson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Grayson','Moore','','Mr.','','Grayson.Moore@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Levi','Clark','','Mr.','','Levi.Clark@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Nicholas','Lewis','','Mr.','','Nicholas.Lewis@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Caleb','Hall','','Mr.','','Caleb.Hall@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Wyatt','Turner','','Mr.','','Wyatt.Turner@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Andrew','Baker','','Mr.','','Andrew.Baker@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Gabriel','Carter','','Mr.','','Gabriel.Carter@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Anthony','Murphy','','Mr.','','Anthony.Murphy@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Isaac','Martinez','','Professor','','Isaac.Martinez@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Sophia','Rodriguez','','Mrs.','','Sophia.Rodriguez@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Evelyn','Davis','','Mrs.','Esq. ','Evelyn.Davis@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Grace','Walker','','Miss','','Grace.Walker@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Lily','Allen','','Professor','','Lily.Allen@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Riley','Thomas','','Miss','','Riley.Thomas@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Mia','King','','Miss','','Mia.King@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Zoe','Hill','','Miss','','Zoe.Hill@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Amelia','Scott','','Miss','','Amelia.Scott@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Avery','Green','','Miss','','Avery.Green@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Harper','White','','Miss','','Harper.White@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Abigail','Jackson','','Miss','','Abigail.Jackson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Emily','Martin','','Mrs.','','Emily.Martin@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Elizabeth','Wilson','','Miss','','Elizabeth.Wilson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Scarlett','Harris','','Miss','','Scarlett.Harris@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Chloe','Lee','','Miss','','Chloe.Lee@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Sofia','Anderson','','Miss','','Sofia.Anderson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Charlotte','Thompson','','Miss','','Charlotte.Thompson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Madison','Garcia','','Miss','','Madison.Garcia@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Aria','Smith','','Miss','','Aria.Smith@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Ella','Patel','','Miss','','Ella.Patel@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Isabella','Johnson','','Miss','','Isabella.Johnson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Olivia','Brown','','Miss','','Olivia.Brown@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Emma','Davis','','Miss','','Emma.Davis@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Ava','Williams','','Miss','','Ava.Williams@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Liam','Miller','','Mr.','Jr.','Liam.Miller@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Noah','Jones','','Mr.','','Noah.Jones@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'William','Anderson','','Mr.','','William.Anderson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'James','Wilson','','Mr.','','James.Wilson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Oliver','Lee','','Mr.','II ','Oliver.Lee@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Benjamin','Scott','','Rabbi','','Benjamin.Scott@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Elijah','Taylor','','Mr.','','Elijah.Taylor@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Henry','Martin','','Mr.','','Henry.Martin@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Alexander','Adams','','Mr.','','Alexander.Adams@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Daniel','Hall','','Mr.','','Daniel.Hall@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Joseph','Turner','','Mr.','','Joseph.Turner@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Matthew','Patel','','Mr.','','Matthew.Patel@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Samuel','Harris','','Rabbi','','Samuel.Harris@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Ethan','Baker','','Mr.','','Ethan.Baker@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Michael','Jackson','','Mr.','','Michael.Jackson@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'David','White','','Mr.','','David.White@phruniversity.edu')
INSERT person (firstName, lastName, middleIn, title, suffix, email) Values ( 'Jackson','Lewis','','Mr.','','Jackson.Lewis@phruniversity.edu')

--Insert admin 
INSERT admin (personID, position, accessLevel, campus, office) Values ( '1','Dean','4','Main Campus','Deans Office')
INSERT admin (personID, position, accessLevel, campus, office) Values ( '2','President','3','Main Campus','Presidents Office')
INSERT admin (personID, position, accessLevel, campus, office) Values ( '3','Secretary','2','Main Campus','Main Office')
INSERT admin (personID, position, accessLevel, campus, office) Values ( '4','Bursar','1','Main Campus','Main Office')

--Insert major
INSERT major (name, requiredCred) Values ( 'Undecided','0')
INSERT major (name, requiredCred) Values ( 'Biology','52')
INSERT major (name, requiredCred) Values ( 'Chemistry','52')
INSERT major (name, requiredCred) Values ( 'Psychology','33')
INSERT major (name, requiredCred) Values ( 'Business','33')
INSERT major (name, requiredCred) Values ( 'Math','45')
INSERT major (name, requiredCred) Values ( 'Finance','45')
INSERT major (name, requiredCred) Values ( 'Computer Science','52')
INSERT major (name, requiredCred) Values ( 'Art & Design','33')
INSERT major (name, requiredCred) Values ( 'Education','33')
INSERT major (name, requiredCred) Values ( 'Marketing','33')
INSERT major (name, requiredCred) Values ( 'English','33')
INSERT major (name, requiredCred) Values ( 'Political Science','45')
INSERT major (name, requiredCred) Values ( 'Economics','45')
INSERT major (name, requiredCred) Values ( 'History','33')


--Insert Minor
INSERT minor (name, requiredCred) Values ( 'Biology','24')
INSERT minor (name, requiredCred) Values ( 'Chemistry','24')
INSERT minor (name, requiredCred) Values ( 'Psychology','18')
INSERT minor (name, requiredCred) Values ( 'Business','18')
INSERT minor (name, requiredCred) Values ( 'Math','18')
INSERT minor (name, requiredCred) Values ( 'Finance','18')
INSERT minor (name, requiredCred) Values ( 'Computer Science','18')
INSERT minor (name, requiredCred) Values ( 'Art & Design','18')
INSERT minor (name, requiredCred) Values ( 'Education','24')
INSERT minor (name, requiredCred) Values ( 'Marketing','18')
INSERT minor (name, requiredCred) Values ( 'History','15')
INSERT minor (name, requiredCred) Values ( 'Science','18')


--Insert student 
INSERT student (personID, campus, majorID, minorID) Values ( '5','Main Campus','1','1')
INSERT student (personID, campus, majorID, minorID) Values ( '6','Main Campus','2','2')
INSERT student (personID, campus, majorID, minorID) Values ( '7','Main Campus','3','3')
INSERT student (personID, campus, majorID, minorID) Values ( '8','Main Campus','4','4')
INSERT student (personID, campus, majorID) Values ( '9','Main Campus','5')
INSERT student (personID, campus, majorID) Values ( '10','Main Campus','6')
INSERT student (personID, campus, majorID) Values ( '11','Main Campus','7')
INSERT student (personID, campus, majorID) Values ( '12','Main Campus','8')
INSERT student (personID, campus, majorID, minorID) Values ( '13','Main Campus','9','9')
INSERT student (personID, campus, majorID, minorID) Values ( '14','Main Campus','10','10')
INSERT student (personID, campus, majorID) Values ( '15','Main Campus','11')
INSERT student (personID, campus, majorID) Values ( '16','Main Campus','1')
INSERT student (personID, campus, majorID) Values ( '17','Main Campus','13')
INSERT student (personID, campus, majorID) Values ( '18','Main Campus','14')
INSERT student (personID, campus, majorID) Values ( '19','Main Campus','15')
INSERT student (personID, campus, majorID) Values ( '20','Main Campus','1')
INSERT student (personID, campus, majorID, minorID) Values ( '21','Online','1','3')
INSERT student (personID, campus, majorID, minorID) Values ( '22','Online','1','7')
INSERT student (personID, campus, majorID, minorID) Values ( '23','Online','1','2')
INSERT student (personID, campus, majorID) Values ( '24','Online','3')
INSERT student (personID, campus, majorID) Values ( '25','Online','2')
INSERT student (personID, campus, majorID) Values ( '24','Online','1')
INSERT student (personID, campus, majorID) Values ( '25','Online','7')

--Insert Student Dynamic
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '1','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '2','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '3','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '4','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '5','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '6','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '7','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '8','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '9','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '10','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '11','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '12','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '13','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '14','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '15','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '16','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '17','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '18','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '19','4','0','Freshmen')
INSERT studentDynamic (studentID, gpa, creditsComp, batchStatus) Values ( '20','4','0','Freshmen')

--Insert Teacher
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '40','Online','0','Science','T/TH 3-4pm')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '27','Main Campus','0','English','T/TH 3-4pm')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '28','Main Campus','0','Science','F 8-9am')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '29','Main Campus','0','Arts','M/W 9-10am')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '30','Main Campus','0','Math','T/TH 12-1pm')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '31','Main Campus','0','English','F 10-11am')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '32','Main Campus','0','Science','M/W 1-2pm')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '33','Main Campus','0','Arts','T/TH 3-4pm')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '34','Main Campus','0','Math','F 8-9am')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '35','Main Campus','0','English','M/W 9-10am')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '36','Main Campus','1','Science','M/W 1-2pm')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '37','Main Campus','1','Arts','T/TH 12-1pm')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '38','Online','1','Math','F 8-9am')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '39','Online','0','English','M/W 9-10am')
INSERT teacher (personID, campus, advisor, department, officeHours) Values ( '40','Online','0','Science','T/TH 3-4pm')

--Insert clourse
INSERT course (name, department, creditsApplied) Values ( 'Psych 101','Psychology','3')
INSERT course (name, department, creditsApplied) Values ( 'Econ Principles','Economics','3')
INSERT course (name, department, creditsApplied) Values ( 'Calculus I','Mathematics','3')
INSERT course (name, department, creditsApplied) Values ( 'Modern History','History','3')
INSERT course (name, department, creditsApplied) Values ( 'Org Chemistry','Chemistry','3')
INSERT course (name, department, creditsApplied) Values ( 'Poli Sci Intro','Political Science','3')
INSERT course (name, department, creditsApplied) Values ( 'Romantic Lit','English Literature','3')
INSERT course (name, department, creditsApplied) Values ( 'Enviro Science','Biology','3')
INSERT course (name, department, creditsApplied) Values ( 'Intro to Coding','Computer Science','3')
INSERT course (name, department, creditsApplied) Values ( 'Art History','Art History','3')
INSERT course (name, department, creditsApplied) Values ( 'Anatomy & Phys','Biology','3')
INSERT course (name, department, creditsApplied) Values ( 'Marketing Basics','Marketing','3')
INSERT course (name, department, creditsApplied) Values ( 'Intl Relations','Business','4')
INSERT course (name, department, creditsApplied) Values ( 'Creative Writing','Ebglish','4')
INSERT course (name, department, creditsApplied) Values ( 'Astro Intro','Science','1')

--Insert Room
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Main Campus','1','1','Classroom',30)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Main Campus','2','1','Auditorium',200)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Main Campus','3','1','Classroom',30)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Main Campus','4','1','Auditorium',200)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Main Campus','1','2','Classroom',30)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Main Campus','2','2','Computer Lab',25)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Main Campus','3','2','Bio Lab',25)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Main Campus','4','2','Classroom',30)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Main Campus','1','3','Art Studio',20)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Main Campus','2','3','Classroom',30)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Main Campus','3','3','Classroom',30)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Main Campus','4','3','Classroom',30)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Online','1','4','Chem Lab',25)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Online','2','4','Auditorium', 200)
INSERT room (location, floorNum, roomNum, roomType, capacity) Values ( 'Online','3','4','Auditorium', 200)

--Insert time
INSERT time (days, duration, startTime, endTime) Values ( 'M','75','9:00am','10:15am')
INSERT time (days, duration, startTime, endTime) Values ( 'M/T','90','9:30am','11:00am')
INSERT time (days, duration, startTime, endTime) Values ( 'M/W','120','10:00am','12:00pm')
INSERT time (days, duration, startTime, endTime) Values ( 'M/TH','150','10:30am','1:00pm')
INSERT time (days, duration, startTime, endTime) Values ( 'M/F','75','11:00am','12:15pm')
INSERT time (days, duration, startTime, endTime) Values ( 'T','90','11:30am','1:00pm')
INSERT time (days, duration, startTime, endTime) Values ( 'T/W','120','12:00pm','2:30pm')
INSERT time (days, duration, startTime, endTime) Values ( 'T/TH','150','12:30pm','3:00pm')
INSERT time (days, duration, startTime, endTime) Values ( 'T/F','75','1:00pm','2:15pm')
INSERT time (days, duration, startTime, endTime) Values ( 'W','90','1:30pm','3:00pm')
INSERT time (days, duration, startTime, endTime) Values ( 'W/TH','120','2:00pm','4:00pm')
INSERT time (days, duration, startTime, endTime) Values ( 'W/F','150','2:30pm','5:00pm')
INSERT time (days, duration, startTime, endTime) Values ( 'TH/F','75','3:00pm','4:15pm')
INSERT time (days, duration, startTime, endTime) Values ( 'F','90','3:30pm','5:00pm')
INSERT time (days, duration, startTime, endTime) Values ( '','120','4:00pm','6:00pm')
INSERT time (days, duration, startTime, endTime) Values ( '','150','4:30pm','7:00pm')

--Insert Class
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Fall 2001','1','1','1','1','300','Gym')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Spring 2002','2','2','2','2','4','Classroom')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Fall 2002','3','3','3','3','200','Auditoprium')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Spring 2003','4','4','4','4','75','Classroom')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Fall 2002','5','5','5','5','100','Auditorium')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Spring 2003','6','6','6','6','50','Classroom')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Fall 2003','7','7','7','7','50','Computer Lab')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Spring 2004','8','8','8','8','20','Bio Lab')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Fall 2004','9','9','9','9','20','Classroom')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Spring 2005','10','10','10','10','15','Art Studio')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Fall 2005','11','11','11','11','15','Classroom')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Spring 2006','12','12','12','12','10','Classroom')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Fall 2006','13','13','13','13','10','Classroom')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Spring 2007','14','14','14','14','10','Chem Lab')
INSERT class (semester, timeID, roomID, courseID, teacherID, classCapacity, roomType) Values ( 'Fall 2007','15','15','15','15','75','Auditorium')

--Insert student class list 
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '1','1','A+','0')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '2','2','A','1')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '3','3','A-','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '4','4','B+','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '5','5','B','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '6','6','B-','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '7','7','C+','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '8','8','C','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '9','9','C-','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '10','10','D+','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '11','11','D','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '12','12','D-','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '13','13','F','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '14','14','','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '15','15','','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '2','16','','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '7','17','','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '3','18','','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '4','19','','')
INSERT studentClassList (classID, studentID, grades, addDrop) Values ( '2','20','','')
