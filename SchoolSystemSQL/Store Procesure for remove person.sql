Create procedure removePerson(@email varchar(254)) as
update person 
set archived = GETDATE()
where email = @email 

exec removePerson 'Michael.Jackson@phruniversity.edu'

select * from Vperson where email = 'Michael.Jackson@phruniversity.edu'