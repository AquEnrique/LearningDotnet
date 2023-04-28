use EvaluationStudent

-- Create and evaluation of one course
INSERT INTO Evaluation (IdTeacherCourse, IdReview)
VALUES
	(3,null);

-- Generate (manually) the EvaluationAssignment
INSERT INTO EvaluationAssignment (IdEvaluation, IdStudent, Note)
VALUES
	(1,1009,null),
	(1,1010,null),
	(1,1005,null),
	(1,1006,null);
--select * from EvaluationAssignment
--select * from StudentCourse
--where IdTeacherCourse = 3


-- Create questions for evaluation
-- 10 questions of 2 topics
INSERT INTO EvaluationXQuestion (IdEvaluation, IdQuestion)
VALUES
(1,1),
(1,2),
(1,3),
(1,4),
(1,5),

(1,11),
(1,13),
(1,15),
(1,17),
(1,19);

--select * from EvaluationXQuestion
--select * from Question

--select * from QuestionAlternative
-- Create answers for each Student

--El primer alumno (1009) Contesta todo perfecto
INSERT INTO Answer (IdEvaluationAssignment,IdQuestionAlternative)
VALUES
	(1, 1),
	(1, 6),
	(1, 9),
	(1, 12),
	(1, 17),
	(1, 39),
	(1, 47),
	(1, 55),
	(1, 61),
	(1, 69);

-- Second student (1010) have 1 mistake in 1 topic
INSERT INTO Answer (IdEvaluationAssignment,IdQuestionAlternative)
VALUES
	(2, 2), -- Mistake
	(2, 6),
	(2, 9),
	(2, 12),
	(2, 17),
	(2, 39),
	(2, 47),
	(2, 55),
	(2, 61),
	(2, 69);

-- Third student (105) have 3 mistakes in 1 topic
INSERT INTO Answer (IdEvaluationAssignment,IdQuestionAlternative)
VALUES
	(3, 1),
	(3, 6),
	(3, 9),
	(3, 12),
	(3, 17),
	(3, 39),
	(3, 47),
	(3, 57), --Mistake
	(3, 62), --Mistake
	(3, 71); --Mistake

-- Fourth student (1006) have 4 mistakes in 2 topics -> 2 topic 1 & 2 topic 2
INSERT INTO Answer (IdEvaluationAssignment,IdQuestionAlternative)
VALUES
	(4, 2), -- Mistake
	(4, 6),
	(4, 9),
	(4, 15), -- Mistake
	(4, 17),
	(4, 43), -- Mistake
	(4, 47),
	(4, 57), -- Mistake
	(4, 61),
	(4, 69);

-- Generate procedure to calculate Notes of an evaluation

--DROP PROCEDURE CalculateEvaluationNote
CREATE PROCEDURE CalculateEvaluationNote
    @IdEvaluation int
AS
BEGIN
	Update
		EvaluationAssignment
	SET
		EvaluationAssignment.Note = fn.Note
	FROM
		EvaluationAssignment ea
	INNER JOIN
		-- Calculate final note
		(SELECT IdEvaluationAssignment, (1 - (CantPreguntas - CantCorrectas )/CantPreguntas)*20 as Note
		FROM
			-- COUNT CORRECT ANSWERS AND CANT. QUESTIONS
			(select IdEvaluationAssignment, SUM(CAST(IsCorret as float)) AS CantCorrectas, COUNT(IdQuestion) AS CantPreguntas
			from 
				(SELECT ea.IdEvaluationAssignment, qa.IdQuestion, a.IdAnswer, qa.IsCorret
				FROM 
					-- GET all answers of this evaluation
					Answer a
					INNER JOIN QuestionAlternative qa ON a.IdQuestionAlternative = qa.IdQuestionAlternative
					INNER JOIN EvaluationAssignment ea ON a.IdEvaluationAssignment = ea.IdEvaluationAssignment
					WHERE
						ea.IdEvaluation = @IdEvaluation) as EvaluationAnswer -- <-Variable
			group by IdEvaluationAssignment) as EvaluationCount) as fn
	ON
		ea.IdEvaluationAssignment = fn.IdEvaluationAssignment

END


exec CalculateEvaluationNote 1
-- select * from EvaluationAssignment


------
-- Generate function to view  failed by examn
CREATE FUNCTION funcGetWrongAnswersEval (
    @IdEvaluation INT
)
RETURNS TABLE
AS
RETURN
    SELECT ea.IdEvaluation, ea.IdStudent, q.IdQuestion, q.Question, a.IdAnswer as IdAnswer, qa.Alternative, qa.IsCorret, q.TopicQuestion
	FROM
		Answer as a
	INNER JOIN EvaluationAssignment ea ON ea.IdEvaluationAssignment = a.IdEvaluationAssignment
	INNER JOIN QuestionAlternative qa ON qa.IdQuestionAlternative = a.IdQuestionAlternative
	INNER JOIN Question q ON q.IdQuestion = qa.IdQuestion
	WHERE 
		ea.IdEvaluation = @IdEvaluation
	AND
		qa.IsCorret = 0
------
select *
from funcGetWrongAnswersEval(1)

-- Generate a procedure to create reviews of eval
--DROP PROCEDURE GenerateReviewOfEval
CREATE PROCEDURE GenerateReviewOfEval
	@IdEval int, @ReviewInterval int
AS
BEGIN
	DECLARE @presentDAY date = CAST(GETDATE() AS Date );

	INSERT INTO Review(IdStudent, TopicReview, StartDate, ReviewInterval)
	SELECT IdStudent, TopicQuestion, @presentDAY, @ReviewInterval
	FROM
		(SELECT DISTINCT IdStudent, TopicQuestion
		FROM funcGetWrongAnswersEval(@IdEval)) as TopicsToReview

END

select * from Review
exec GenerateReviewOfEval 1, 5

-- TO DO --> Make a trigger than create evals in the reviewInterval
