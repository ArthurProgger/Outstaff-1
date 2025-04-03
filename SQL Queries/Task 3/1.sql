use `oustaff_test_project`;

select 
    Id,
    Dt,
    lead(Dt) over (partition by Id order by Dt) as Ed
from 
    dates
order by
    Id, Dt;