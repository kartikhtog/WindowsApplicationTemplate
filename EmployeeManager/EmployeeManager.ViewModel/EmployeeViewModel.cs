using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using System;
using System.ComponentModel;

namespace EmployeeManager.ViewModel
{
    public partial class EmployeeViewModel : ViewModelBase
    {
        private readonly Employee _employee;
        private readonly IEmployeeDataProvider _employeeDataProvider;

        public EmployeeViewModel(Employee employee, IEmployeeDataProvider employeeDataProvider)
        {
            _employee = employee;
            _employeeDataProvider = employeeDataProvider;
        }


        public string FirstName
        {
            get { return _employee.FirstName; }
            set 
            {
                if(value != _employee.FirstName)
                {
                    _employee.FirstName = value; 
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                }
            }
        }
        
        public DateTimeOffset EntryDate
        {
            get { return _employee.EntryDate; }
            set 
            {
                if(value != _employee.EntryDate)
                {
                    _employee.EntryDate = value; 
                    RaisePropertyChanged();
                }
            }
        }
                
        public int JobRoleId
        {
            get { return _employee.JobRoleId; }
            set 
            {
                if(value != _employee.JobRoleId)
                {
                    _employee.JobRoleId = value; 
                    RaisePropertyChanged();
                }
            }
        }                

        public bool IsCoffeeDrinker
        {
            get { return _employee.IsCoffeeDrinker; }
            set 
            {
                if(value != _employee.IsCoffeeDrinker)
                {
                    _employee.IsCoffeeDrinker = value; 
                    RaisePropertyChanged();
                }
            }
        }

        public bool CanSave => !string.IsNullOrEmpty(FirstName);

        public void Save()
        {
            _employeeDataProvider.SaveEmployee(_employee);
        }
    }
}
