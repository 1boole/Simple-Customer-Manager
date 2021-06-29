using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetByCode(string code);
        IResult Update(User user);
        IResult Delete(User user);
        IResult Add(User user);
        public IResult CheckUserLogin(string code, string pass);

    }
}
