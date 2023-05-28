﻿using Microsoft.EntityFrameworkCore;
using taxe_studentesti_be.student_taxes_impl.model;
using taxe_studentesti_be.student_taxes_impl.model.Context;

namespace taxe_studentesti_be.Student_Taxes_Impl.Infrastructure
{
    public class StudyFeeRepository
    {
        private readonly StudentTaxesContext _context;

        public StudyFeeRepository(StudentTaxesContext context)
        {
            _context = context;
        }

        public StudyFeeEntity? FindById(long id)
        {
            return _context.StudyFees.Include(studyFee => studyFee.Study)
                .FirstOrDefault(studfyFee => studfyFee.Id == id);
        }

        public void Save(StudyFeeEntity studyFeeEntity)
        {
            _context.StudyFees.Add(studyFeeEntity);
            _context.SaveChanges();
        }

        public void DeleteById(long id)
        {
            var studyFeeEntity = _context.StudyFees.Find(id);
            if (studyFeeEntity != null)
            {
                _context.StudyFees.Remove(studyFeeEntity);
                _context.SaveChanges();
            }
        }

        public List<StudyFeeEntity> FindAll()
        {
            return _context.StudyFees.Include(studyFee => studyFee.Study).ToList();
        }
    }
}
