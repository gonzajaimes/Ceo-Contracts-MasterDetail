using CeoMasterDetail.Services;
using CeoMasterDetail.Models;
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
        private List<MenuEmpresa> _menuEmpresasList;
        private MenuEmpresa _selectedMenuEmpresa = new MenuEmpresa();
        private List<Proyectos> _searchedProjects;
        //private string _searchKeyWord;
        private bool _isBusy = false;
        private string _statusMessage;
        private bool _requestSucceed;

        public string SelectedCompany { get; set; }


        //public string SearchKeyWord
        //{
        //    get
        //    {
        //        return _searchKeyWord;
        //    }
        //    set
        //    {
        //        _searchKeyWord = value;
        //        OnPropertyChanged();
        //    }
        //}

        public List<MenuEmpresa> MenuEmpresasList
        {
            get { return _menuEmpresasList; }
            set
            {
                _menuEmpresasList = value;
                OnPropertyChanged();
            }
        }
        public MenuEmpresa SelectedMenuEmpresa
        {
            get { return _selectedMenuEmpresa; }
            set
            {
                _selectedMenuEmpresa = value;
                OnPropertyChanged();
            }
        }

        public List<Proyectos> SearchedProjects
        {
            get { return _searchedProjects; }
            set
            {
                _searchedProjects = value;
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

        public Command SearchProjectsCommand
        {
            get
            {
                return new Command(async () =>
                {
                    //  IsBusy = true;

                    var Empresa = (int)SelectedMenuEmpresa.IdEmpresa;
                    var proyectosServices = new ProyectosServices();
                    SearchedProjects = await proyectosServices.GetProjectsByIdAsync(Empresa);

                 //   IsBusy = false;
                });
            }
        }


        public MainViewModel()
        {
            InitializeDataAsync();
        }

        private async Task InitializeDataAsync()
        {
            IsBusy = true;

            var proyectosServices = new ProyectosServices();
            MenuEmpresasList = await proyectosServices.GetMenuItemsAsync();

            IsBusy = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
