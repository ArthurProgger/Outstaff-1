use `oustaff_test_project`;

select clients.Id, clients.ClientName
from clientcontacts
inner join clients on clients.Id = clientcontacts.ClientId
group by clients.ClientName, clients.Id
having count(*) > 2