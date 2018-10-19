using CeoMasterDetail.Services;
using CeoWebServices.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CeoMasterDetail.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<Proyectos> _proyectosList;
        private Proyectos _selectedProyecto = new Proyectos();
        private List<Proyectos> _searchedProyectos;
        private string _searchKeyWord;
        private bool _isBusy = false;
        private string _statusMessage;
        private bool _requestSucceed;

        public string SearchKeyWord
        {
            get
            {
                return _searchKeyWord;
            }
            set
            {
                _searchKeyWord = value;
                OnPropertyChanged();
            }
        }

        public List<Proyectos> ProyectosList
        {
            get { return _proyectosList; }
            set
            {
                _proyectosList = value;
                OnPropertyChanged();
            }
        }

        public List<Proyectos> SearchedEmployees
        {
            get { return _searchedProyectos; }
            set
            {
                _searchedProyectos = value;
                OnPropertyChanged();
            }
        }

        public Proyectos SelectedProyecto
        {
            get { return _selectedProyecto; }
            set
            {
                _selectedProyecto = value;
                OnPropertyChanged();
            }
        }

        public bool RequestSucceed
        {
            get { return _requestSucceed; }
            set
            {
                _requestSucceed = value;
                OnPropertyChanged();
            }
        }

        //property to notify if the app is doing an operation.

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        //Status message to bind to the operation success/failure

        public string StatusMessage
        {
            get { return _statusMessage; }
            set
            {
                _statusMessage = value;
                OnPropertyChanged();
            }
        }

        //properties for commands used in the buttons.

        //public Command RefreshCommand
        //{
        //    get
        //    {
        //        return new Command(async () => await InitializeDataAsync());
        //    }
        //}

        //public Command PostCommand
        //{
        //    get
        //    {
        //        return new Command(async () =>
        //        {
        //            IsBusy = true;

        //            var employeesServices = new EmployeesServices();
        //            RequestSucceed = await employeesServices.PostEmployeeAsync(_selectedEmployee);

        //            IsBusy = false;

        //            if (RequestSucceed)
        //            {
        //                StatusMessage = "Employee Added Successfully !";
        //            }
        //            else
        //            {
        //                StatusMessage = "Operation Post Failed!";
        //            }

        //        });
        //    }
        //}

        //public Command PutCommand
        //{
        //    get
        //    {
        //        return new Command(async () =>
        //        {
        //            IsBusy = true;

        //            var employeesServices = new EmployeesServices();
        //            RequestSucceed = await employeesServices.PutEmployeeAsync(_selectedEmployee.Id, _selectedEmployee);

        //            IsBusy = false;

        //            if (RequestSucceed == true)
        //            {
        //                StatusMessage = "Employee Updated Successfully !";
        //            }
        //            else
        //            {
        //                StatusMessage = "Operation Put Failed!";
        //            }

        //        });
        //    }
        //}

        //public Command DeleteCommand
        //{
        //    get
        //    {
        //        return new Command(async () =>
        //        {
        //            IsBusy = true;

        //            var employeesServices = new EmployeesServices();
        //            RequestSucceed = await employeesServices.DeleteEmployeeAsync(_selectedEmployee.Id);

        //            IsBusy = false;

        //            if (RequestSucceed == true)
        //            {
        //                StatusMessage = "Employee Deleted Successfully !";
        //            }
        //            else
        //            {
        //                StatusMessage = "Operation Delete Failed!";
        //            }
        //        });
        //    }
        //}

        //public Command SearchCommand
        //{
        //    get
        //    {
        //        return new Command(async () =>
        //        {
        //            IsBusy = true;

        //            var employeesServices = new EmployeesServices();
        //            SearchedEmployees = await employeesServices.GetEmployeesByKeywordAsync(_searchKeyWord);

        //            IsBusy = false;
        //        });
        //    }
        //}


        public MainViewModel()
        {
            InitializeDataAsync();
        }

        private async Task InitializeDataAsync()
        {
            IsBusy = true;

            var proyectosServices = new ProyectosServices();
            ProyectosList = await proyectosServices.GetProyectosAsync();

            IsBusy = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
