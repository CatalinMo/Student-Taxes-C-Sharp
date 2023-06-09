﻿using AutoMapper;
using taxe_studentesti_be.student_taxes_api.domain.request;
using taxe_studentesti_be.student_taxes_api.domain.response;
using taxe_studentesti_be.student_taxes_impl.model;

namespace taxe_studentesti_be.Student_Taxes_Impl.Config
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<StudyFeeEntity, StudyFeeResponseDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Study, opt => opt.MapFrom(src => src.Study));
            CreateMap<StudyFeeResponseDto, StudyFeeEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Study, opt => opt.MapFrom(src => src.Study));

            CreateMap<StudyFeeEntity, StudyFeeRequestDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type));
            CreateMap<StudyFeeRequestDto, StudyFeeEntity>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type));

            CreateMap<StudyEntity, StudyResponseDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Faculty, opt => opt.MapFrom(src => src.Faculty))
                .ForMember(dest => dest.Cycle, opt => opt.MapFrom(src => src.Cycle))
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
                .ForMember(dest => dest.StudyProgram, opt => opt.MapFrom(src => src.StudyProgram))
                .ForMember(dest => dest.Form, opt => opt.MapFrom(src => src.Form))
                .ForMember(dest => dest.StudyFees, opt => opt.MapFrom(src => src.StudyFees))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.Abbreviation, opt => opt.MapFrom(src => src.Abbreviation));
            CreateMap<StudyResponseDto, StudyEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Faculty, opt => opt.MapFrom(src => src.Faculty))
                .ForMember(dest => dest.Cycle, opt => opt.MapFrom(src => src.Cycle))
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
                .ForMember(dest => dest.StudyProgram, opt => opt.MapFrom(src => src.StudyProgram))
                .ForMember(dest => dest.Form, opt => opt.MapFrom(src => src.Form))
                .ForMember(dest => dest.StudyFees, opt => opt.MapFrom(src => src.StudyFees))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.Abbreviation, opt => opt.MapFrom(src => src.Abbreviation));

            CreateMap<StudyEntity, StudyRequestDto>()
                .ForMember(dest => dest.Faculty, opt => opt.MapFrom(src => src.Faculty))
                .ForMember(dest => dest.Cycle, opt => opt.MapFrom(src => src.Cycle))
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
                .ForMember(dest => dest.StudyProgram, opt => opt.MapFrom(src => src.StudyProgram))
                .ForMember(dest => dest.Form, opt => opt.MapFrom(src => src.Form))
                .ForMember(dest => dest.StudyFees, opt => opt.MapFrom(src => src.StudyFees))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.Abbreviation, opt => opt.MapFrom(src => src.Abbreviation));
            CreateMap<StudyRequestDto, StudyEntity>()
                .ForMember(dest => dest.Faculty, opt => opt.MapFrom(src => src.Faculty))
                .ForMember(dest => dest.Cycle, opt => opt.MapFrom(src => src.Cycle))
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
                .ForMember(dest => dest.StudyProgram, opt => opt.MapFrom(src => src.StudyProgram))
                .ForMember(dest => dest.Form, opt => opt.MapFrom(src => src.Form))
                .ForMember(dest => dest.StudyFees, opt => opt.MapFrom(src => src.StudyFees))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.Abbreviation, opt => opt.MapFrom(src => src.Abbreviation));

            CreateMap<OtherFeeEntity, OtherFeeResponseDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type));
            CreateMap<OtherFeeResponseDto, OtherFeeEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type));

            CreateMap<OtherFeeEntity, OtherFeeRequestDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type));

            CreateMap<OtherFeeRequestDto, OtherFeeEntity>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type));

            CreateMap<HostelFeeEntity, HostelFeeResponseDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.HostelName, opt => opt.MapFrom(src => src.HostelName))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Budget, opt => opt.MapFrom(src => src.Budget))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type));
            CreateMap<HostelFeeResponseDto, HostelFeeEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.HostelName, opt => opt.MapFrom(src => src.HostelName))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Budget, opt => opt.MapFrom(src => src.Budget))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type));

            CreateMap<HostelFeeEntity, HostelFeeRequestDto>()
                .ForMember(dest => dest.HostelName, opt => opt.MapFrom(src => src.HostelName))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Budget, opt => opt.MapFrom(src => src.Budget))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type));
            CreateMap<HostelFeeRequestDto, HostelFeeEntity>()
                .ForMember(dest => dest.HostelName, opt => opt.MapFrom(src => src.HostelName))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Budget, opt => opt.MapFrom(src => src.Budget))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type));

            CreateMap<AccountEntity, UserIdentityResponseDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Cnp, opt => opt.MapFrom(src => src.Cnp))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role));
            CreateMap<UserIdentityResponseDto, AccountEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Cnp, opt => opt.MapFrom(src => src.Cnp))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role));

            CreateMap<AccountEntity, AccountResponseDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Cnp, opt => opt.MapFrom(src => src.Cnp))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.ActiveStudies, opt => opt.MapFrom(src => src.ActiveStudies))
                .ForMember(dest => dest.ActiveFees, opt => opt.MapFrom(src => src.ActiveFees))
                .ForMember(dest => dest.PaidFees, opt => opt.MapFrom(src => src.PaidFees));
            CreateMap<AccountResponseDto, AccountEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Cnp, opt => opt.MapFrom(src => src.Cnp))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.ActiveStudies, opt => opt.MapFrom(src => src.ActiveStudies))
                .ForMember(dest => dest.ActiveFees, opt => opt.MapFrom(src => src.ActiveFees))
                .ForMember(dest => dest.PaidFees, opt => opt.MapFrom(src => src.PaidFees));

            CreateMap<AccountEntity, AccountRequestDto>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Cnp, opt => opt.MapFrom(src => src.Cnp))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.ActiveStudies, opt => opt.MapFrom(src => src.ActiveStudies))
                .ForMember(dest => dest.ActiveFees, opt => opt.MapFrom(src => src.ActiveFees))
                .ForMember(dest => dest.PaidFees, opt => opt.MapFrom(src => src.PaidFees));
            CreateMap<AccountRequestDto, AccountEntity>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Cnp, opt => opt.MapFrom(src => src.Cnp))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.ActiveStudies, opt => opt.MapFrom((src, dest, _, ctx) =>
                {
                    HashSet<ActiveStudyEntity> combinedList = new HashSet<ActiveStudyEntity>(dest.ActiveStudies);
                    var mappedItems = src.ActiveStudies.Select(item => ctx.Mapper.Map<ActiveStudyRequestDto, ActiveStudyEntity>(item));
                    foreach (var newItem in mappedItems)
                    {
                        if (!combinedList.Any(existingItem => ArePropertiesEqual(existingItem, newItem, "Id", "Account")))
                        {
                            combinedList.Add(newItem);
                        }
                    }
                    return combinedList;
                }))
                .ForMember(dest => dest.ActiveFees, opt => opt.MapFrom((src, dest, _, ctx) =>
                {
                    HashSet<ActiveFeeEntity> combinedList = new HashSet<ActiveFeeEntity>(dest.ActiveFees);
                    var mappedItems = src.ActiveFees.Select(item => ctx.Mapper.Map<ActiveFeeRequestDto, ActiveFeeEntity>(item));
                    foreach (var newItem in mappedItems)
                    {
                        if (!combinedList.Any(existingItem => ArePropertiesEqual(existingItem, newItem, "Id", "Account")))
                        {
                            combinedList.Add(newItem);
                        }
                    }
                    return combinedList;
                }))
                .ForMember(dest => dest.PaidFees, opt => opt.MapFrom((src, dest, _, ctx) =>
                {
                    HashSet<PaidFeeEntity> combinedList = new HashSet<PaidFeeEntity>(dest.PaidFees);
                    var mappedItems = src.PaidFees.Select(item => ctx.Mapper.Map<PaidFeeRequestDto, PaidFeeEntity>(item));
                    foreach (var newItem in mappedItems)
                    {
                        if (!combinedList.Any(existingItem => ArePropertiesEqual(existingItem, newItem, "Id", "Account")))
                        {
                            combinedList.Add(newItem);
                        }
                    }
                    return combinedList;
                }));

            CreateMap<ActiveStudyEntity, ActiveStudyResponseDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Faculty, opt => opt.MapFrom(src => src.Faculty))
                .ForMember(dest => dest.Cycle, opt => opt.MapFrom(src => src.Cycle))
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
                .ForMember(dest => dest.StudyProgram, opt => opt.MapFrom(src => src.StudyProgram))
                .ForMember(dest => dest.Form, opt => opt.MapFrom(src => src.Form))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.Abbreviation, opt => opt.MapFrom(src => src.Abbreviation))
                .ForMember(dest => dest.Budget, opt => opt.MapFrom(src => src.Budget))
                .ForMember(dest => dest.Accommodated, opt => opt.MapFrom(src => src.Accommodated));
            CreateMap<ActiveStudyResponseDto, ActiveStudyEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Faculty, opt => opt.MapFrom(src => src.Faculty))
                .ForMember(dest => dest.Cycle, opt => opt.MapFrom(src => src.Cycle))
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
                .ForMember(dest => dest.StudyProgram, opt => opt.MapFrom(src => src.StudyProgram))
                .ForMember(dest => dest.Form, opt => opt.MapFrom(src => src.Form))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.Abbreviation, opt => opt.MapFrom(src => src.Abbreviation))
                .ForMember(dest => dest.Budget, opt => opt.MapFrom(src => src.Budget))
                .ForMember(dest => dest.Accommodated, opt => opt.MapFrom(src => src.Accommodated));

            CreateMap<ActiveStudyEntity, ActiveStudyRequestDto>()
                .ForMember(dest => dest.Faculty, opt => opt.MapFrom(src => src.Faculty))
                .ForMember(dest => dest.Cycle, opt => opt.MapFrom(src => src.Cycle))
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
                .ForMember(dest => dest.StudyProgram, opt => opt.MapFrom(src => src.StudyProgram))
                .ForMember(dest => dest.Form, opt => opt.MapFrom(src => src.Form))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.Abbreviation, opt => opt.MapFrom(src => src.Abbreviation))
                .ForMember(dest => dest.Budget, opt => opt.MapFrom(src => src.Budget))
                .ForMember(dest => dest.Accommodated, opt => opt.MapFrom(src => src.Accommodated));
            CreateMap<ActiveStudyRequestDto, ActiveStudyEntity>()
                .ForMember(dest => dest.Faculty, opt => opt.MapFrom(src => src.Faculty))
                .ForMember(dest => dest.Cycle, opt => opt.MapFrom(src => src.Cycle))
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
                .ForMember(dest => dest.StudyProgram, opt => opt.MapFrom(src => src.StudyProgram))
                .ForMember(dest => dest.Form, opt => opt.MapFrom(src => src.Form))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.Abbreviation, opt => opt.MapFrom(src => src.Abbreviation))
                .ForMember(dest => dest.Budget, opt => opt.MapFrom(src => src.Budget))
                .ForMember(dest => dest.Accommodated, opt => opt.MapFrom(src => src.Accommodated));

            CreateMap<ActiveFeeEntity, ActiveFeeResponseDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Details, opt => opt.MapFrom(src => src.Details))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.LimitDate, opt => opt.MapFrom(src => new DateTimeOffset(src.LimitDate).ToUnixTimeMilliseconds()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Account, opt => opt.MapFrom(src => src.Account));
            CreateMap<ActiveFeeResponseDto, ActiveFeeEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Details, opt => opt.MapFrom(src => src.Details))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.LimitDate, opt => opt.MapFrom(src => DateTimeOffset.FromUnixTimeMilliseconds(src.LimitDate).DateTime))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.Account, opt => opt.MapFrom(src => src.Account));


            CreateMap<ActiveFeeEntity, ActiveFeeRequestDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Details, opt => opt.MapFrom(src => src.Details))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.LimitDate, opt => opt.MapFrom(src => new DateTimeOffset(src.LimitDate).ToUnixTimeMilliseconds()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
            CreateMap<ActiveFeeRequestDto, ActiveFeeEntity>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Details, opt => opt.MapFrom(src => src.Details))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.LimitDate, opt => opt.MapFrom(src => DateTimeOffset.FromUnixTimeMilliseconds(src.LimitDate).DateTime))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));

            CreateMap<PaidFeeEntity, PaidFeeResponseDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Details, opt => opt.MapFrom(src => src.Details))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.DateOfPayment, opt => opt.MapFrom(src => new DateTimeOffset(src.DateOfPayment).ToUnixTimeMilliseconds()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
            CreateMap<PaidFeeResponseDto, PaidFeeEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Details, opt => opt.MapFrom(src => src.Details))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.DateOfPayment, opt => opt.MapFrom(src => DateTimeOffset.FromUnixTimeMilliseconds(src.DateOfPayment).DateTime))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));

            CreateMap<PaidFeeEntity, PaidFeeRequestDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Details, opt => opt.MapFrom(src => src.Details))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.DateOfPayment, opt => opt.MapFrom(src => new DateTimeOffset(src.DateOfPayment).ToUnixTimeMilliseconds()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
            CreateMap<PaidFeeRequestDto, PaidFeeEntity>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Details, opt => opt.MapFrom(src => src.Details))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.DateOfPayment, opt => opt.MapFrom(src => DateTimeOffset.FromUnixTimeMilliseconds(src.DateOfPayment).DateTime))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value));
        }

        private bool ArePropertiesEqual<T>(T obj1, T obj2, params string[] excludedProperties)
        {
            var properties = typeof(T).GetProperties()
                .Where(p => !excludedProperties.Contains(p.Name));

            foreach (var property in properties)
            {
                var value1 = property.GetValue(obj1);
                var value2 = property.GetValue(obj2);

                if (value1 is DateTime && value2 is DateTime)
                {
                    var date1 = ((DateTime)value1).ToString("yyyy-MM-dd");
                    var date2 = ((DateTime)value2).ToString("yyyy-MM-dd");

                    if (!string.Equals(date1, date2))
                    {
                        return false;
                    }
                } else
                {
                    if (!Equals(value1, value2))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
