using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFormsEmpresaEstrategiasProfecionales.Models
{
    internal class Access
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string State { get; set; }
        public TypeUser TypeUser { get; set; }
        public User User { get; set; }

        public bool login(string enteredUserName, string enteredPassword)
        {
            // Verificar si el nombre de usuario y la contraseña coinciden con los almacenados en la instancia de Access.
            if (enteredUserName == UserName && enteredPassword == Password)
            {
                // Inicio de sesión exitoso
                return true;
            }
            else
            {
                // Inicio de sesión fallido
                return false;
            }
        }
    }
} 
