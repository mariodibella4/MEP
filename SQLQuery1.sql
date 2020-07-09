CREATE TABLE EmployeeInfo 
(
 emp_id      char(10)  NOT NULL Primary Key ,
 emp_name    char(50)  NOT NULL ,
 emp_pic     char(400) Not Null,
 emp_age     INT  NULL ,
 emp_birth    DATE  NULL ,
 emp_position   char(50)   NULL ,
 emp_salary     nvarchar(50) NULL ,
);

INSERT INTO EmployeeInfo
(
 emp_id  ,
 emp_name     ,
 emp_pic ,
 emp_age     ,
 emp_birth  ,
 emp_position    ,
 emp_salary     
)
Values
(
'0000000002','Jess DiBella','https://www.congress.gov/img/member/p000587_200.jpg','31','10/11/1989','VP','54000'
);
UPDate EmployeeInfo
SET emp_age='34',emp_salary='86000'
Where emp_id='0000000001';

CREATE TABLE EmployeePersonal
(
emp_id      char(10)  NOT NULL Primary Key ,
emp_name    char(50)  NOT NULL,
emp_married char(10) Not Null,
emp_childrenOrPEts char(10) Not Null,
emp_numberOfChildrenOrPets char(10) Null,
emp_famInfo char(300) Null,
emp_hobbies char(300) Null,
emp_stress char(300) Null,
emp_feedback char(300) Null
);
