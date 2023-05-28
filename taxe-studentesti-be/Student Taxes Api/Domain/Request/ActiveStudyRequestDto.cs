﻿namespace taxe_studentesti_be.student_taxes_api.domain.request
{
    public class ActiveStudyRequestDto
    {
        public string? Faculty { get; set; }
        public string? Cycle { get; set; }
        public string? Department { get; set; }
        public string? StudyProgram { get; set; }
        public string? Form { get; set; }
        public int Year { get; set; }
        public string? Abbreviation { get; set; }
        public bool Budget { get; set; }
        public string? Accommodated { get; set; }
    }
}
