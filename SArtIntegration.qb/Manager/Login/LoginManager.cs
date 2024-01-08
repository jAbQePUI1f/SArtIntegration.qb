using SArtIntegration.qb.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SArtIntegration.qb.Manager.Login
{
    #region Entity
    public class LoginResultModel : CommonResultModel
    {
        public string Token { get; set; }
    }

    #endregion
    public class LoginManager
    {
        public static  LoginResultModel Login(string userName, string password)
        {
            LoginResultModel model = new LoginResultModel();

            #region Parameter Control
            if (string.IsNullOrEmpty(userName)
                || string.IsNullOrEmpty(password))
            {
                model.State = false;
                model.Messages.Add("Kullanıcı adı veya şifre boş olamaz!");

                return model;
            }

            userName = userName.Trim();
            password = password.Trim();

            if (string.IsNullOrEmpty(userName)
                || string.IsNullOrEmpty(password))
            {
                model.State = false;
                model.Messages.Add("Kullanıcı adı veya şifre boş olamaz!");

                return model;
            }
            #endregion

            var tokenResult = GetToken(userName, password);

            if (tokenResult == null)
            {
                model.State = false;
                model.Messages.Add("Kullanıcı bilgisi alınamadı");
                return model;
            }

            if (string.IsNullOrEmpty(tokenResult.Token))
            {
                model.State = false;
                model.Messages.Add("Kullanıcı bilgisi alınamadı");
                return model;
            }


            model.State = true;
            model.Token = tokenResult.Token;

            return model;
        }
       
        private static LoginResultModel GetToken(string userName, string password)
        {
            LoginResultModel result = new LoginResultModel();


            //var tokenResult =GetToken(userName, password);

            //if (tokenResult.Key)
            //{

            //    result.Token = tokenResult.Value;

            //    return result;
            //}

            return result;
        }

    }
}
