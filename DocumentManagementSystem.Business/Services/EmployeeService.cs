using AutoMapper;
using DocumentManagementSystem.Business.Interfaces;
using DocumentManagementSystem.DataAccess.UnitOfWork;
using DocumentManagementSystem.Dtos;
using DocumentManagementSystem.Dtos.EmployeeDtos;
using DocumentManagementSystem.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Business.Services
{
    public class EmployeeService : Service<EmployeeCreateDto, EmployeeUpdateDto, EmployeeListDto,Employee>,IEmployeeService
    {
        public EmployeeService(IMapper mapper, IValidator<EmployeeCreateDto> createDtoValidator, IValidator<EmployeeUpdateDto> updateDtoValidator, IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {

        }

    }
}
