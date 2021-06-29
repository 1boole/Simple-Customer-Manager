using Bussines.Abstract;
using Bussines.Constans;
using Bussines.ValidationRules.FluentValidation;
using Core.CrossCuttingCorncerns.Validation.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            ValidationTool.Validate(new UserValidator(),user);
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);
        }

        public IResult Update(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IDataResult<List<User>> GetByCode(string code)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(c => c.Code == code), Messages.UserListed);
        }


        public IResult CheckUserLogin(string code, string pass)
        {
            var userCodeResult = _userDal.GetAll(c => c.Code == code);
            if (userCodeResult != null)
            {
                foreach (var user in userCodeResult)
                {
                    if (user.Pass == pass)
                    {
                        return new SuccessResult(Messages.UserSuccess);
                    }
                    else
                    {
                        return new ErrorResult(Messages.UserPassError);
                    }
                }
            }
            return new ErrorResult(Messages.UserNon);
        }
    }
}
