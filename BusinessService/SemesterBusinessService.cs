using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasApi.models;
using NotasApi.DataService;

namespace NotasApi.BusinessService
{
    public class SemesterBusinessService
    {
        private SemesterDataService _semesterDataService;
        public SemesterBusinessService(SemesterDataService semesterDataService)
        {
            _semesterDataService = semesterDataService;
        }

        // Get Semesters
        public IEnumerable<Semester> GetSemesters()
        {
            return _semesterDataService.GetSemesters();
        }

        //Get one Semester
        public Semester? GetSemester(long id)
        {
            return _semesterDataService.GetSemester(id);
        }

        //Insert Semester
        public Semester InsertSemester(Semester semester)
        {
            return _semesterDataService.InsertSemester(semester);
        }

        //Update Semester
        public Semester? UpdateSemester(Semester semester)
        {
            return _semesterDataService.UpdateSemester(semester);
        }

        //Delete Semester
        public bool DeleteSemester(long id)
        {
            return _semesterDataService.DeleteSemester(id);
        }
    }
}