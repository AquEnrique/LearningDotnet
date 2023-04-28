use EvaluationStudent

-- Add data(14) to Student
INSERT INTO Student (Name, LastName)
VALUES
  ('Juan', 'Pérez'),
  ('María', 'González'),
  ('Carlos', 'Sánchez'),
  ('Ana', 'Martínez'),
  ('Pedro', 'Fernández'),
  ('Lucía', 'Hernández'),
  ('Miguel', 'Rodríguez'),
  ('Laura', 'Ruiz'),
  ('Javier', 'Díaz'),
  ('Sara', 'Torres'),
  ('David', 'García'),
  ('Isabel', 'López'),
  ('Adrián', 'Moreno'),
  ('Carmen', 'Castillo')

-- Add data(3) to Teacher
INSERT INTO Teacher (Name, LastName)
VALUES
  ('Laura', 'García'),
  ('Miguel', 'López'),
  ('Sara', 'Martínez');

-- Add data(1) to Semester
INSERT INTO Semester
VALUES ('2023-I')

-- Add data(1) to ProfessionalSchool
INSERT INTO ProfessionalSchool (IdProfSchool, Name)
VALUES ('PS001', 'Facultad de Ingeniería Eléctrica, Electrónica, informática y Mecánica');

-- Add data(1) to Career
INSERT INTO Career (IdCareer, Name, IdProfSchool)
VALUES ('C001','INGENIERÍA INFORMÁTICA Y DE SISTEMAS', 'PS001')

-- Add data(2) to Course
INSERT INTO Course (IdCourse, IdCareer, Name)
VALUES 
  ('C001-M01', 'C001', 'Introducción a la programación'),
  ('C001-M02', 'C001', 'Estructuras de datos');


-- Add data(3) to Course
INSERT INTO TeacherCourse (IdTeacher, IdSemester, IdCourse)
VALUES 
  (1001, '2023-I', 'C001-M01'),
  (1002, '2023-I', 'C001-M02'),
  (1003, '2023-I', 'C001-M02');

-- Add data(20) to Course
INSERT INTO StudentCourse (IdStudent, IdTeacherCourse, Grade1, Grade2, Grade3)
VALUES 
  (1001, 1, null, null, null),
  (1002, 1, null, null, null),
  (1003, 1, null, null, null),
  (1004, 1, null, null, null),
  (1005, 1, null, null, null),
  (1006, 1, null, null, null),
  (1007, 2, null, null, null),
  (1008, 2, null, null, null),
  (1009, 3, null, null, null),
  (1010, 3, null, null, null),
  (1011, 1, null, null, null),
  (1012, 1, null, null, null),
  (1013, 1, null, null, null),
  (1014, 2, null, null, null),
  (1001, 2, null, null, null),
  (1002, 2, null, null, null),
  (1003, 2, null, null, null),
  (1004, 2, null, null, null),
  (1005, 3, null, null, null),
  (1006, 3, null, null, null);


-- Generación de preguntas y alternativas
--30 preguntas
INSERT INTO Question (Question, TopicQuestion)
VALUES
	('Question 1 - Topic 1', 'Topic 1'),
	('Question 2 - Topic 1', 'Topic 1'),
	('Question 3 - Topic 1', 'Topic 1'),
	('Question 4 - Topic 1', 'Topic 1'),
	('Question 5 - Topic 1', 'Topic 1'),
	('Question 6 - Topic 1', 'Topic 1'),
	('Question 7 - Topic 1', 'Topic 1'),
	('Question 8 - Topic 1', 'Topic 1'),
	('Question 9 - Topic 1', 'Topic 1'),
	('Question 10 - Topic 1', 'Topic 1'),
	('Question 1 - Topic 2', 'Topic 2'),
	('Question 2 - Topic 2', 'Topic 2'),
	('Question 3 - Topic 2', 'Topic 2'),
	('Question 4 - Topic 2', 'Topic 2'),
	('Question 5 - Topic 2', 'Topic 2'),
	('Question 6 - Topic 2', 'Topic 2'),
	('Question 7 - Topic 2', 'Topic 2'),
	('Question 8 - Topic 2', 'Topic 2'),
	('Question 9 - Topic 2', 'Topic 2'),
	('Question 10 - Topic 2', 'Topic 2'),
	('Question 1 - Topic 3', 'Topic 3'),
	('Question 2 - Topic 3', 'Topic 3'),
	('Question 3 - Topic 3', 'Topic 3'),
	('Question 4 - Topic 3', 'Topic 3'),
	('Question 5 - Topic 3', 'Topic 3'),
	('Question 6 - Topic 3', 'Topic 3'),
	('Question 7 - Topic 3', 'Topic 3'),
	('Question 8 - Topic 3', 'Topic 3'),
	('Question 9 - Topic 3', 'Topic 3'),
	('Question 10 - Topic 3', 'Topic 3');

-- 114 alternativas
INSERT INTO QuestionAlternative (IdQuestion, Alternative, IsCorret)
VALUES
  (1,'Question 1 - Topic 1 - Alternative 1', 1),
  (1,'Question 1 - Topic 1 - Alternative 2', 0),
  (1,'Question 1 - Topic 1 - Alternative 3', 0),
  (1,'Question 1 - Topic 1 - Alternative 4', 0),
  (1,'Question 1 - Topic 1 - Alternative 5', 0),

  (2,'Question 2 - Topic 1 - Alternative 1', 1),
  (2,'Question 2 - Topic 1 - Alternative 2', 0),
  (2,'Question 2 - Topic 1 - Alternative 3', 0),

  (3,'Question 3 - Topic 1 - Alternative 1', 1),
  (3,'Question 3 - Topic 1 - Alternative 2', 0),
  (3,'Question 3 - Topic 1 - Alternative 3', 0),

  (4,'Question 4 - Topic 1 - Alternative 1', 1),
  (4,'Question 4 - Topic 1 - Alternative 2', 0),
  (4,'Question 4 - Topic 1 - Alternative 3', 0),
  (4,'Question 4 - Topic 1 - Alternative 4', 0),
  (4,'Question 4 - Topic 1 - Alternative 5', 0),

  (5,'Question 5 - Topic 1 - Alternative 1', 1),
  (5,'Question 5 - Topic 1 - Alternative 2', 0),
  (5,'Question 5 - Topic 1 - Alternative 3', 0),

  (6,'Question 6 - Topic 1 - Alternative 1', 1),
  (6,'Question 6 - Topic 1 - Alternative 2', 0),
  (6,'Question 6 - Topic 1 - Alternative 3', 0),

  (7,'Question 7 - Topic 1 - Alternative 1', 1),
  (7,'Question 7 - Topic 1 - Alternative 2', 0),
  (7,'Question 7 - Topic 1 - Alternative 3', 0),
  (7,'Question 7 - Topic 1 - Alternative 4', 0),
  (7,'Question 7 - Topic 1 - Alternative 5', 0),

  (8,'Question 8 - Topic 1 - Alternative 1', 1),
  (8,'Question 8 - Topic 1 - Alternative 2', 0),
  (8,'Question 8 - Topic 1 - Alternative 3', 0),

  (9,'Question 9 - Topic 1 - Alternative 1', 1),
  (9,'Question 9 - Topic 1 - Alternative 2', 0),
  (9,'Question 9 - Topic 1 - Alternative 3', 0),

  (10,'Question 10 - Topic 1 - Alternative 1', 1),
  (10,'Question 10 - Topic 1 - Alternative 2', 0),
  (10,'Question 10 - Topic 1 - Alternative 3', 0),
  (10,'Question 10 - Topic 1 - Alternative 4', 0),
  (10,'Question 10 - Topic 1 - Alternative 5', 0),


  (11,'Question 1 - Topic 1 - Alternative 1', 1),
  (11,'Question 1 - Topic 1 - Alternative 2', 0),
  (11,'Question 1 - Topic 1 - Alternative 3', 0),
  (11,'Question 1 - Topic 1 - Alternative 4', 0),
  (11,'Question 1 - Topic 1 - Alternative 5', 0),

  (12,'Question 2 - Topic 1 - Alternative 1', 1),
  (12,'Question 2 - Topic 1 - Alternative 2', 0),
  (12,'Question 2 - Topic 1 - Alternative 3', 0),

  (13,'Question 3 - Topic 1 - Alternative 1', 1),
  (13,'Question 3 - Topic 1 - Alternative 2', 0),
  (13,'Question 3 - Topic 1 - Alternative 3', 0),

  (14,'Question 4 - Topic 1 - Alternative 1', 1),
  (14,'Question 4 - Topic 1 - Alternative 2', 0),
  (14,'Question 4 - Topic 1 - Alternative 3', 0),
  (14,'Question 4 - Topic 1 - Alternative 4', 0),
  (14,'Question 4 - Topic 1 - Alternative 5', 0),

  (15,'Question 5 - Topic 1 - Alternative 1', 1),
  (15,'Question 5 - Topic 1 - Alternative 2', 0),
  (15,'Question 5 - Topic 1 - Alternative 3', 0),

  (16,'Question 6 - Topic 1 - Alternative 1', 1),
  (16,'Question 6 - Topic 1 - Alternative 2', 0),
  (16,'Question 6 - Topic 1 - Alternative 3', 0),

  (17,'Question 7 - Topic 1 - Alternative 1', 1),
  (17,'Question 7 - Topic 1 - Alternative 2', 0),
  (17,'Question 7 - Topic 1 - Alternative 3', 0),
  (17,'Question 7 - Topic 1 - Alternative 4', 0),
  (17,'Question 7 - Topic 1 - Alternative 5', 0),

  (18,'Question 8 - Topic 1 - Alternative 1', 1),
  (18,'Question 8 - Topic 1 - Alternative 2', 0),
  (18,'Question 8 - Topic 1 - Alternative 3', 0),

  (19,'Question 9 - Topic 1 - Alternative 1', 1),
  (19,'Question 9 - Topic 1 - Alternative 2', 0),
  (19,'Question 9 - Topic 1 - Alternative 3', 0),

  (20,'Question 10 - Topic 1 - Alternative 1', 1),
  (20,'Question 10 - Topic 1 - Alternative 2', 0),
  (20,'Question 10 - Topic 1 - Alternative 3', 0),
  (20,'Question 10 - Topic 1 - Alternative 4', 0),
  (20,'Question 10 - Topic 1 - Alternative 5', 0),


  (21,'Question 1 - Topic 1 - Alternative 1', 1),
  (21,'Question 1 - Topic 1 - Alternative 2', 0),
  (21,'Question 1 - Topic 1 - Alternative 3', 0),
  (21,'Question 1 - Topic 1 - Alternative 4', 0),
  (21,'Question 1 - Topic 1 - Alternative 5', 0),

  (22,'Question 2 - Topic 1 - Alternative 1', 1),
  (22,'Question 2 - Topic 1 - Alternative 2', 0),
  (22,'Question 2 - Topic 1 - Alternative 3', 0),

  (23,'Question 3 - Topic 1 - Alternative 1', 1),
  (23,'Question 3 - Topic 1 - Alternative 2', 0),
  (23,'Question 3 - Topic 1 - Alternative 3', 0),

  (24,'Question 4 - Topic 1 - Alternative 1', 1),
  (24,'Question 4 - Topic 1 - Alternative 2', 0),
  (24,'Question 4 - Topic 1 - Alternative 3', 0),
  (24,'Question 4 - Topic 1 - Alternative 4', 0),
  (24,'Question 4 - Topic 1 - Alternative 5', 0),

  (25,'Question 5 - Topic 1 - Alternative 1', 1),
  (25,'Question 5 - Topic 1 - Alternative 2', 0),
  (25,'Question 5 - Topic 1 - Alternative 3', 0),

  (26,'Question 6 - Topic 1 - Alternative 1', 1),
  (26,'Question 6 - Topic 1 - Alternative 2', 0),
  (26,'Question 6 - Topic 1 - Alternative 3', 0),

  (27,'Question 7 - Topic 1 - Alternative 1', 1),
  (27,'Question 7 - Topic 1 - Alternative 2', 0),
  (27,'Question 7 - Topic 1 - Alternative 3', 0),
  (27,'Question 7 - Topic 1 - Alternative 4', 0),
  (27,'Question 7 - Topic 1 - Alternative 5', 0),

  (28,'Question 8 - Topic 1 - Alternative 1', 1),
  (28,'Question 8 - Topic 1 - Alternative 2', 0),
  (28,'Question 8 - Topic 1 - Alternative 3', 0),

  (29,'Question 9 - Topic 1 - Alternative 1', 1),
  (29,'Question 9 - Topic 1 - Alternative 2', 0),
  (29,'Question 9 - Topic 1 - Alternative 3', 0),

  (30,'Question 10 - Topic 1 - Alternative 1', 1),
  (30,'Question 10 - Topic 1 - Alternative 2', 0),
  (30,'Question 10 - Topic 1 - Alternative 3', 0),
  (30,'Question 10 - Topic 1 - Alternative 4', 0),
  (30,'Question 10 - Topic 1 - Alternative 5', 0);