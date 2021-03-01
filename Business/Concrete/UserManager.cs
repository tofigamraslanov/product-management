using System.Collections.Generic;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        //IDataResult<List<OperationClaim>> GetClaims(User user)
        //{
        //    return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        //}

        //IResult Add(User user)
        //{
        //    _userDal.Add(user);
        //    return new SuccessResult();
        //}

        //IDataResult<User> GetByMail(string email)
        //{
        //    return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        //}
    }
}