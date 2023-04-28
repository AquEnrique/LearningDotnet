CREATE DATABASE EvaluationStudent;
use EvaluationStudent

--Tables without foreign key
CREATE TABLE "Student" (
  "IdStudent" long primary key not null identity(1001,1),
  "Name" nvarchar(80),
  "LastName" nvarchar(80)
);

CREATE TABLE "Teacher" (
  "IdTeacher" long primary key not null identity(1001,1),
  "Name" nvarchar(80),
  "LastName" nvarchar(80)
);

CREATE TABLE "Semester" (
  "IdSemester" long primary key not null identity(1,1),
  "NameSemester" nvarchar(80)
);

CREATE TABLE "ProfessionalSchool" (
  "IdProfSchool" long primary key not null identity(1,1),
  "Name" nvarchar(80)
);

CREATE TABLE "Question" (
  "IdQuestion" long primary key not null identity(1,1),
  "Question_description" nvarchar(500),
  "TopicQuestion" nvarchar(80),
);
-------------------
--Tables with foreign key
-------------------

CREATE TABLE "Career" (
  "IdCareer" long primary key not null identity(1,1),
  "Name" nvarchar(80),
  "IdProfSchool" long,
  foreign key (IdProfSchool) references ProfessionalSchool (IdProfSchool)
);

CREATE TABLE "Course" (
  "IdCourse" long primary key not null identity(1,1),
  "IdCareer" long not null,
  "Name" nvarchar(80),
  foreign key (IdCareer) references Career (IdCareer)
);

CREATE TABLE "TeacherCourse" (
  "IdTeacherCourse" long primary key not null identity(1,1),
  "IdTeacher" long,
  "IdSemester" long,
  "IdCourse" long,
  foreign key (IdTeacher) references Teacher (IdTeacher),
  foreign key (IdSemester) references Semester (IdSemester),
  foreign key (IdCourse) references Course (IdCourse),
);

CREATE TABLE "StudentCourse" (
  "IdStudentCourse" long primary key not null identity(1,1),
  "IdStudent" long not null,
  "IdTeacherCourse" long not null,
  "Grade1" float,
  "Grade2" float,
  "Grade3" float,
  foreign key (IdStudent) references Student (IdStudent),
  foreign key (IdTeacherCourse) references  TeacherCourse (IdTeacherCourse),
);

CREATE TABLE "Review" (
  "IdReview" long primary key not null identity(1,1),
  "IdStudent" long not null,
  "TopicReview" nvarchar(80),
  "StartDate" date not null,
  "EndDate" date,
  "ReviewInterval" long,
  foreign key (IdStudent) references Student (IdStudent),
);

CREATE TABLE "Evaluation" (
  "IdEvaluation" long primary key not null identity(1,1),
  "IdTeacherCourse" long ,
  "IdReview" long,
  foreign key (IdTeacherCourse) references  TeacherCourse (IdTeacherCourse),
  foreign key (IdReview) references  Review (IdReview),
);

CREATE TABLE "QuestionAlternative" (
  "IdQuestionAlternative" long primary key not null identity(1,1),
  "IdQuestion" long,
  "Alternative" nvarchar(500),
  "IsCorret" bit not null,
  foreign key (IdQuestion) references  Question (IdQuestion),
);

CREATE TABLE "EvaluationXQuestion" (
  "IdEvalXQuestion" long primary key not null identity(1,1),
  "IdEvaluation" long not null,
  "IdQuestion" long not null,
  foreign key (IdQuestion) references  Question (IdQuestion),
  foreign key (IdEvaluation) references  Evaluation (IdEvaluation),
);

CREATE TABLE "EvaluationAssignment" (
  "IdEvaluationAssignment" long primary key not null identity(1,1),
  "IdEvaluation" long not null,
  "IdStudent" long not null,
  "Note" float,
  foreign key (IdEvaluation) references Evaluation (IdEvaluation)
);

CREATE TABLE "Answer" (
  "IdAnswer" long primary key not null identity(1,1),
  "IdEvaluationAssignment" long not null,
  "IdQuestionAlternative" long not null,
  foreign key (IdEvaluationAssignment) references EvaluationAssignment (IdEvaluationAssignment)
);