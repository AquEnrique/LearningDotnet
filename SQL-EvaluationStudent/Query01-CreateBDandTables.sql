CREATE DATABASE EvaluationStudent;
use EvaluationStudent

--Tables without foreign key
CREATE TABLE "Student" (
  "IdStudent" int primary key not null identity(1001,1),
  "Name" nvarchar(80),
  "LastName" nvarchar(80)
);

CREATE TABLE "Teacher" (
  "IdTeacher" int primary key not null identity(1001,1),
  "Name" nvarchar(80),
  "LastName" nvarchar(80)
);

CREATE TABLE "Semester" (
  "IdSemester" int primary key not null identity(1,1),
  "NameSemester" nvarchar(80)
);

CREATE TABLE "ProfessionalSchool" (
  "IdProfSchool" int primary key not null identity(1,1),
  "Name" nvarchar(80)
);

CREATE TABLE "Question" (
  "IdQuestion" int primary key not null identity(1,1),
  "Question_description" nvarchar(500),
  "TopicQuestion" nvarchar(80),
);
-------------------
--Tables with foreign key
-------------------

CREATE TABLE "Career" (
  "IdCareer" int primary key not null identity(1,1),
  "Name" nvarchar(80),
  "IdProfSchool" int,
  foreign key (IdProfSchool) references ProfessionalSchool (IdProfSchool)
);

CREATE TABLE "Course" (
  "IdCourse" int primary key not null identity(1,1),
  "IdCareer" int not null,
  "Name" nvarchar(80),
  foreign key (IdCareer) references Career (IdCareer)
);

CREATE TABLE "TeacherCourse" (
  "IdTeacherCourse" int primary key not null identity(1,1),
  "IdTeacher" int,
  "IdSemester" int,
  "IdCourse" int,
  foreign key (IdTeacher) references Teacher (IdTeacher),
  foreign key (IdSemester) references Semester (IdSemester),
  foreign key (IdCourse) references Course (IdCourse),
);

CREATE TABLE "StudentCourse" (
  "IdStudentCourse" int primary key not null identity(1,1),
  "IdStudent" int not null,
  "IdTeacherCourse" int not null,
  "Grade1" float,
  "Grade2" float,
  "Grade3" float,
  foreign key (IdStudent) references Student (IdStudent),
  foreign key (IdTeacherCourse) references  TeacherCourse (IdTeacherCourse),
);

CREATE TABLE "Review" (
  "IdReview" int primary key not null identity(1,1),
  "IdStudent" int not null,
  "TopicReview" nvarchar(80),
  "StartDate" date not null,
  "EndDate" date,
  "ReviewInterval" int,
  foreign key (IdStudent) references Student (IdStudent),
);

CREATE TABLE "Evaluation" (
  "IdEvaluation" int primary key not null identity(1,1),
  "IdTeacherCourse" int ,
  "IdReview" int,
  foreign key (IdTeacherCourse) references  TeacherCourse (IdTeacherCourse),
  foreign key (IdReview) references  Review (IdReview),
);

CREATE TABLE "QuestionAlternative" (
  "IdQuestionAlternative" int primary key not null identity(1,1),
  "IdQuestion" int,
  "Alternative" nvarchar(500),
  "IsCorret" bit not null,
  foreign key (IdQuestion) references  Question (IdQuestion),
);

CREATE TABLE "EvaluationXQuestion" (
  "IdEvalXQuestion" int primary key not null identity(1,1),
  "IdEvaluation" int not null,
  "IdQuestion" int not null,
  foreign key (IdQuestion) references  Question (IdQuestion),
  foreign key (IdEvaluation) references  Evaluation (IdEvaluation),
);

CREATE TABLE "EvaluationAssignment" (
  "IdEvaluationAssignment" int primary key not null identity(1,1),
  "IdEvaluation" int not null,
  "IdStudent" int not null,
  "Note" float,
  foreign key (IdEvaluation) references Evaluation (IdEvaluation)
);

CREATE TABLE "Answer" (
  "IdAnswer" int primary key not null identity(1,1),
  "IdEvaluationAssignment" int not null,
  "IdQuestionAlternative" int not null,
  foreign key (IdEvaluationAssignment) references EvaluationAssignment (IdEvaluationAssignment)
);