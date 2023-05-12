using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SeriesBarros.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        //Atributos
        private string _username;
        private SecureString _password;
        private string _errorMsj;
        private bool _isViewVisible = true;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public SecureString Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ErrorMsj
        {
            get => _errorMsj;
            set
            {
                _errorMsj = value;
                OnPropertyChanged(nameof(ErrorMsj));
            }
        }
        public bool IsViewVisible
        {
            get => _isViewVisible; set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }


        //Comandos
        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoverPasswordCommand = new RelayCommand(p=>ExecuteRecoverPassComand("",""));
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool dataValida;

            if (string.IsNullOrEmpty(Username) || Username.Length < 3 || Password == null || Password.Length < 3)
            {
                dataValida = false;
            }

            else
                dataValida = true;

            return dataValida;
        }

        private void ExecuteLoginCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private void ExecuteRecoverPassComand(string username, string email)
        {
            throw new NotImplementedException();
        }

        //EJEMPLE CONEXTIO A BSE DATOS
        //private string StringConnection()
        //{ 
        //    string stringConnexio = $"server{servidor}; por={port};user={usuari};password{password};database{baseDades}";
        //    return stringConnexio;
        //}

    }
}
