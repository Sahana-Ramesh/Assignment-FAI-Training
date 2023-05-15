select * from exam

Select e1.name as Manager, e2.name  from exam e1 Join exam e2 on e1.Emp_Id= e2.Manager_Id order by e1.Name asc;