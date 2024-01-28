using AutoMapper;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Models.Employee;
using EmployeeManagement.Repositories.IRepositories;
using EmployeeManagement.Repositories.unitOfWork;
using EmployeeManagement.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this._employeeRepository = employeeRepository;
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        /// <summary>
        /// CreateEmployee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task<EmployeeCreateResponseModel> CreateEmployee(EmployeeCreateModel employee)
        {
            try
            {
                _employeeRepository.CreateEmployee(_mapper.Map<Employee>(employee));
                await _unitOfWork.SaveChangesAsync();
                return new EmployeeCreateResponseModel
                {
                    Success = true,
                    Message = "Employee created"
                };
            }
            catch (Exception ex)
            {
                return new EmployeeCreateResponseModel
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }


        /// <summary>
        /// DeleteEmployee
        /// </summary>
        /// <param name="employee"></param>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<EmployeeDeleteResponseModel> DeleteEmployee(int id)
        {
            var employeeDeleteResponseModel = new EmployeeDeleteResponseModel();
            try
            {
                var employee = _mapper.Map<EmployeeModel>(await _employeeRepository.GetEmployee(id));
                if (employee != null)
                {
                    _unitOfWork.Clear();
                    _employeeRepository.DeleteEmployee(_mapper.Map<Employee>(employee));
                    await _unitOfWork.SaveChangesAsync();
                    employeeDeleteResponseModel= new EmployeeDeleteResponseModel
                    {
                        Success = true,
                        Message = "Employee deleted"
                    };
                }

            }
            catch (Exception ex)
            {
                employeeDeleteResponseModel= new EmployeeDeleteResponseModel
                {
                    Success = false,
                    Message = ex.Message
                };
            }
            return employeeDeleteResponseModel;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<EmployeeModel> GetEmployee(int id)
        {
            return _mapper.Map<EmployeeModel>(await _employeeRepository.GetEmployee(id));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<EmployeeModel>> GetEmployees()
        {
            return _mapper.Map<List<EmployeeModel>>(await _employeeRepository.GetEmployees());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task<EmployeeUpdateResponseModel> UpdateEmployee(EmployeeUpdateModel employee)
        {
            try
            {
                _employeeRepository.UpdateEmployee(_mapper.Map<Employee>(employee));
                await _unitOfWork.SaveChangesAsync();
                return new EmployeeUpdateResponseModel
                {
                    Success = true,
                    Message = "Employee updated"
                };
            }
            catch (Exception ex)
            {
                return new EmployeeUpdateResponseModel
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}
