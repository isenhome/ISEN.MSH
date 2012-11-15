using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Service.Base.Service;
using ISEN.MSH.Nhibernate.Model.Users;

namespace ISEN.MSH.APP.Service.Base.User.Service
{
    public class UserManager : GenericManagerBase<UserModel>, IUserManager
    {
        public IList<UserModel> LoadAllByPage(out long total, int page, int rows, string order, string sort)
        {
            return ((Dao.IUserRepository)(this.CurrentRepository))
                .LoadAllByPage(out total, page, rows, order, sort).ToList();
        }

        /// <summary>
        /// 获取MD5值
        /// </summary>
        /// <param name="key">加密的字符串</param>
        /// <returns>返回MD5值</returns>
        private string HashCode(string key)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(key, "MD5");
        }

        public override object Save(UserModel entity)
        {
            entity.Password = this.HashCode(entity.Account.ToUpper() + "123456" + entity.CreateTime.ToLongDateString());
            return base.Save(entity);
        }

        public UserModel Get(string account)
        {
            return ((Dao.IUserRepository)(this.CurrentRepository)).Get(account);
        }

        public UserModel Get(string account, string password)
        {
            var entity = ((Dao.IUserRepository)(this.CurrentRepository)).Get(account);

            if (entity != null)
            {
                if (entity.Password !=
                        this.HashCode(entity.Account.ToUpper() + password 
                            + entity.CreateTime.ToLongDateString()))
                {
                    return null;
                }
            }

            return entity;
        }

        public void Update(UserModel entity, string password)
        {
            entity.Password = this.HashCode(entity.Account.ToUpper() + password + entity.CreateTime.ToLongDateString());
            base.Update(entity);
        }
    }
}
