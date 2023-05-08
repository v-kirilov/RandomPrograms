if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName,LastName)
	values ('Tim','Corey'),
	('Sue','Storm'),
	('John','Smith'),
	('Mary','Jones');
end

/*this script will search for records in the table and if there are no records it will fill it with these provided here*/