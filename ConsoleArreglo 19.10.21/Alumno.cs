using System;
using System.Collections.Generic;
using System.Text;

namespace Console_19._10._21
{
    class Alumno
    {
        protected string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        protected string matricula;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        protected string carrera;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public Alumno()
        {
            nombre = "";
            matricula = "";
            carrera = "";
        }

        public Alumno(string matricula, string carrera)
        {
            this.Nombre = nombre;
            this.matricula = matricula;
            this.carrera = carrera;
        }

        public override string ToString()
        {
            return "nombre " + nombre + "\nmatricula " + matricula + "\ncarrera " + carrera;
        }
    }
}
