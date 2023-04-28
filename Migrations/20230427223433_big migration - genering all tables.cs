using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotasApi.Migrations
{
    /// <inheritdoc />
    public partial class bigmigrationgeneringalltables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfessionalSchools",
                columns: table => new
                {
                    IdProfSchool = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalSchools", x => x.IdProfSchool);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    IdQuestion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopicQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.IdQuestion);
                });

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    IdSemester = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSemester = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.IdSemester);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IdStudent);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    IdTeacher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.IdTeacher);
                });

            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    IdCareer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdProfSchool = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.IdCareer);
                    table.ForeignKey(
                        name: "FK_Careers_ProfessionalSchools_IdProfSchool",
                        column: x => x.IdProfSchool,
                        principalTable: "ProfessionalSchools",
                        principalColumn: "IdProfSchool",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionAlternatives",
                columns: table => new
                {
                    IdQuestionAlternative = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdQuestion = table.Column<int>(type: "int", nullable: false),
                    Alternative = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorret = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAlternatives", x => x.IdQuestionAlternative);
                    table.ForeignKey(
                        name: "FK_QuestionAlternatives_Questions_IdQuestion",
                        column: x => x.IdQuestion,
                        principalTable: "Questions",
                        principalColumn: "IdQuestion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    IdReview = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    TopicReview = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReviewInterval = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.IdReview);
                    table.ForeignKey(
                        name: "FK_Reviews_Students_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "Students",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    IdCourse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCareer = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.IdCourse);
                    table.ForeignKey(
                        name: "FK_Courses_Careers_IdCareer",
                        column: x => x.IdCareer,
                        principalTable: "Careers",
                        principalColumn: "IdCareer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherCourses",
                columns: table => new
                {
                    IdTeacherCourse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTeacher = table.Column<int>(type: "int", nullable: false),
                    IdSemester = table.Column<int>(type: "int", nullable: false),
                    IdCourse = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCourses", x => x.IdTeacherCourse);
                    table.ForeignKey(
                        name: "FK_TeacherCourses_Courses_IdCourse",
                        column: x => x.IdCourse,
                        principalTable: "Courses",
                        principalColumn: "IdCourse",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherCourses_Semesters_IdSemester",
                        column: x => x.IdSemester,
                        principalTable: "Semesters",
                        principalColumn: "IdSemester",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherCourses_Teachers_IdTeacher",
                        column: x => x.IdTeacher,
                        principalTable: "Teachers",
                        principalColumn: "IdTeacher",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    IdEvaluation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTeacherCourse = table.Column<int>(type: "int", nullable: true),
                    IdReview = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.IdEvaluation);
                    table.ForeignKey(
                        name: "FK_Evaluations_Reviews_IdReview",
                        column: x => x.IdReview,
                        principalTable: "Reviews",
                        principalColumn: "IdReview");
                    table.ForeignKey(
                        name: "FK_Evaluations_TeacherCourses_IdTeacherCourse",
                        column: x => x.IdTeacherCourse,
                        principalTable: "TeacherCourses",
                        principalColumn: "IdTeacherCourse");
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    IdStudentCourse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    IdTeacherCourse = table.Column<int>(type: "int", nullable: false),
                    Grade1 = table.Column<float>(type: "real", nullable: true),
                    Grade2 = table.Column<float>(type: "real", nullable: true),
                    Grade3 = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => x.IdStudentCourse);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "Students",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_TeacherCourses_IdTeacherCourse",
                        column: x => x.IdTeacherCourse,
                        principalTable: "TeacherCourses",
                        principalColumn: "IdTeacherCourse",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationAssignments",
                columns: table => new
                {
                    IdEvaluationAssignment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEvaluation = table.Column<int>(type: "int", nullable: false),
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<float>(type: "real", nullable: true),
                    EvaluationIdEvaluation = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationAssignments", x => x.IdEvaluationAssignment);
                    table.ForeignKey(
                        name: "FK_EvaluationAssignments_Evaluations_EvaluationIdEvaluation",
                        column: x => x.EvaluationIdEvaluation,
                        principalTable: "Evaluations",
                        principalColumn: "IdEvaluation");
                    table.ForeignKey(
                        name: "FK_EvaluationAssignments_Students_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "Students",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationXQuestions",
                columns: table => new
                {
                    IdEvalXQuestion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEvaluation = table.Column<int>(type: "int", nullable: false),
                    IdQuestion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationXQuestions", x => x.IdEvalXQuestion);
                    table.ForeignKey(
                        name: "FK_EvaluationXQuestions_Evaluations_IdEvaluation",
                        column: x => x.IdEvaluation,
                        principalTable: "Evaluations",
                        principalColumn: "IdEvaluation",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvaluationXQuestions_Questions_IdQuestion",
                        column: x => x.IdQuestion,
                        principalTable: "Questions",
                        principalColumn: "IdQuestion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    IdAnswer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEvaluationAssignment = table.Column<int>(type: "int", nullable: false),
                    IdQuestionAlternative = table.Column<int>(type: "int", nullable: false),
                    EvaluationAssignmentIdEvaluationAssignment = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.IdAnswer);
                    table.ForeignKey(
                        name: "FK_Answers_EvaluationAssignments_EvaluationAssignmentIdEvaluationAssignment",
                        column: x => x.EvaluationAssignmentIdEvaluationAssignment,
                        principalTable: "EvaluationAssignments",
                        principalColumn: "IdEvaluationAssignment");
                    table.ForeignKey(
                        name: "FK_Answers_Questions_IdQuestionAlternative",
                        column: x => x.IdQuestionAlternative,
                        principalTable: "Questions",
                        principalColumn: "IdQuestion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_EvaluationAssignmentIdEvaluationAssignment",
                table: "Answers",
                column: "EvaluationAssignmentIdEvaluationAssignment");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_IdQuestionAlternative",
                table: "Answers",
                column: "IdQuestionAlternative");

            migrationBuilder.CreateIndex(
                name: "IX_Careers_IdProfSchool",
                table: "Careers",
                column: "IdProfSchool");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_IdCareer",
                table: "Courses",
                column: "IdCareer");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationAssignments_EvaluationIdEvaluation",
                table: "EvaluationAssignments",
                column: "EvaluationIdEvaluation");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationAssignments_IdStudent",
                table: "EvaluationAssignments",
                column: "IdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_IdReview",
                table: "Evaluations",
                column: "IdReview");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_IdTeacherCourse",
                table: "Evaluations",
                column: "IdTeacherCourse");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationXQuestions_IdEvaluation",
                table: "EvaluationXQuestions",
                column: "IdEvaluation");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationXQuestions_IdQuestion",
                table: "EvaluationXQuestions",
                column: "IdQuestion");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAlternatives_IdQuestion",
                table: "QuestionAlternatives",
                column: "IdQuestion");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_IdStudent",
                table: "Reviews",
                column: "IdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_IdStudent",
                table: "StudentCourses",
                column: "IdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_IdTeacherCourse",
                table: "StudentCourses",
                column: "IdTeacherCourse");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourses_IdCourse",
                table: "TeacherCourses",
                column: "IdCourse");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourses_IdSemester",
                table: "TeacherCourses",
                column: "IdSemester");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourses_IdTeacher",
                table: "TeacherCourses",
                column: "IdTeacher");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "EvaluationXQuestions");

            migrationBuilder.DropTable(
                name: "QuestionAlternatives");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "EvaluationAssignments");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "TeacherCourses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "ProfessionalSchools");
        }
    }
}
