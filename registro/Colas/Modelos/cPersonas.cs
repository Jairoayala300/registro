using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas.Modelos
{
    class cPersonas
    {
        private string Nombre;

        public string pNombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private DateTime fechaNac;

        public DateTime pFechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        
        private string Sexo;

        public string pSexo
        {
            get { return Sexo; }
            set { Sexo = value; }
        }
        
        private string NivelAcademico;

        public string pNivelAcademico
        {
            get { return NivelAcademico; }
            set { NivelAcademico = value; }
        }

        public cPersonas(){
        }

        public int Edad()
        {
            int e = 0;
            try
            {
                e = DateTime.Now.Year - fechaNac.Year;
            }
            catch (Exception ex) { }
            return e;
        }

    }
}
