use SC;
go
create trigger triggerID
on Administrators after insert
as
	declare @i int;
	set @i = (select MAX(ID) from Administrators) + 1;

	update Administrators
	set ID = @i
	where userName = (select userName from inserted);