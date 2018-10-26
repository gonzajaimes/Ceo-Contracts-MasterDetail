using CeoMasterDetail.RestClient;
using CeoMasterDetail.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CeoMasterDetail.Services
{
    public class ProyectosServices
    {
        public async Task<List<MenuEmpresa>> GetMenuItemsAsync()
        {
            RestClient<MenuEmpresa> restClient = new RestClient<MenuEmpresa>();

            var MenuEmpresasList = await restClient.GetMenuItemsAsync();

            return MenuEmpresasList;
        }

        //public async Task<bool> PostEmployeeAsync(Employee employee)
        //{
        //    RestClient<Employee> restClient = new RestClient<Employee>();

        //    var isSuccessStatusCode = await restClient.PostAsync(employee);

        //    return isSuccessStatusCode;

        //}

        //public async Task<bool> PutEmployeeAsync(int employeeId, Employee employee)
        //{
        //    RestClient<Employee> restClient = new RestClient<Employee>();

        //    var isSuccessStatusCode = await restClient.PutAsync(employeeId, employee);

        //    return isSuccessStatusCode;

        //}

        //public async Task<bool> DeleteEmployeeAsync(int employeeId)
        //{
        //    RestClient<Employee> restClient = new RestClient<Employee>();

        //    var isSuccessStatusCode = await restClient.DeleteAsync(employeeId);

        //    return isSuccessStatusCode;
        //}

        //public async Task<List<Employee>> GetEmployeesByKeywordAsync(string keyword)
        //{
        //    RestClient<Employee> restClient = new RestClient<Employee>();

        //    var employeeList = await restClient.GetByKeywordAsync(keyword);
        //    return employeeList;
        //}



    }
}
