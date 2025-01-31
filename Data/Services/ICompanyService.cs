using BARAZAIS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARAZAIS.Data.Services;
public interface ICompanyService : IBaseService<CompanyModel>
{
    Task<CompanyModel> GetCompanyDetailed(string Email);
}