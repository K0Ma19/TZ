USE TZ

select a.* 
from EMPLOYEE a, EMPLOYEE b
where  b.Id = a.Chief_id  and  a.Salary > b.Salary