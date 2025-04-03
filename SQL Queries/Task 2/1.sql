use `oustaff_test_project`;

select clients.ClientName, (
	select count(*)
	from clientcontacts
	where clientcontacts.ClientId = clients.Id) as ContactsCount
from clients;