﻿namespace taxe_studentesti_be.student_taxes_api.domain.request
{
    public class HostelFeeRequestDto
    {
        public string? HostelName { get; set; }
        public string? Name { get; set; }
        public float Value { get; set; }
        public bool Budget { get; set; }
        public string? Type { get; set; }
    }
}
