Alter table person
add [password] varchar (255) null
Select * from person

update person
set password = 'password'

Alter view Vperson as
Select personID, firstName,lastName,
middleIn, title, suffix, email,  [password]
from person
where archived is Null

select * from Vperson