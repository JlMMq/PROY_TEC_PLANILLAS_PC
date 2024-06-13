using ProyBROL_ADO;
using ProyBROL_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBROL_BL
{
    public class LoginBL
    {
        private LoginADO _login = new LoginADO();
        public LoginOuBE ValidarUserSystem(LoginInBE obj)
        {
            return _login.ValidarUserSystem(obj);
        }

        public bool ActualizarCorreo(UpdateMail obj)
        {
            return _login.ActualizarCorreo(obj);
        }

        public bool ActualizarPassword(UpdatePassword obj)
        {
            return _login.ActualizarPassword(obj);
        }

    }
}
