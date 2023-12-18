Create procedure checkLogin(@email varchar(255), @password varchar(255)) as
select count(*)
from Vperson
where email = @email and [password] = @password



exec checkLogin 'Olivia.Brown@phruniversity.edu', 'abcd'

Create procedure checkPersonAdmin(@email varchar(255)) as
with tempPerson as(
	Select personID
	from Vperson
	where email = @email
)
select count(tempPerson.personID)
from Vadmin
join tempPerson on tempPerson.personID = Vadmin.personID

select * from Vadmin
select * from Vperson

exec checkPersonAdmin 'Olivia.Brown@phruniversi'

Create procedure checkPersonTeacher(@email varchar(255)) as
with tempPerson as(
	Select personID
	from Vperson
	where email = @email
)
select count(tempPerson.personID)
from Vteacher
join tempPerson on tempPerson.personID = Vteacher.personID

select * from Vteacher
select * from Vperson

exec checkPersonTeacher 'James.Green@phruniversity.edu'


Create procedure checkPersonStudent(@email varchar(255)) as
with tempPerson as(
	Select personID
	from Vperson
	where email = @email
)
select count(tempPerson.personID)
from Vstudent
join tempPerson on tempPerson.personID = Vstudent.personID

select * from Vstudent
select * from Vperson

exec checkPersonStudent 'Ava.Wilson@phruniversity.edu'