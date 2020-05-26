using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using System.Collections.Generic;
using Luque.Fernando;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        
        
        [TestMethod]
        [ExpectedException(typeof(SumaAlumnoException))]

        public void TestSumaAlumnoAAula()
        {
            Alumno alumno = new Alumno("Pepe", "Peposo", 30000000, false, 500);
            alumno.ColorSala = EColores.Amarillo;
            Docente docente = new Docente("Carlos", "Rodriguez", 21000000,true, DateTime.Parse("13:00"), DateTime.Parse("17:00"),250);
            Aula aula = new Aula(EColores.Rojo, Eturno.mañana, docente);

            _ = aula + alumno;
        }

        

        [TestMethod]
        [ExpectedException(typeof(AulaVaciaException))]

        public void TestAulaVacia()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            Docente docente = new Docente("Carlos", "Rodriguez", 21000000, true, DateTime.Parse("13:00"), DateTime.Parse("17:00"), 250);
            Aula aula = new Aula(EColores.Rojo, Eturno.mañana, docente);

            aula.Alumnos = listaAlumnos;

        }


       

        [TestMethod]
        [ExpectedException(typeof(AlumnoIgualException))]

        public void TestAlumnoIgual()
        {

            FrmPrincipal principal = new FrmPrincipal();
            FrmAltaAlumno altaAlumno = new FrmAltaAlumno();

           

           

            List<Alumno> listaAlumnos2 = new List<Alumno>();
            Alumno alumno1 = new Alumno("Pepe", "Peposo", 30000000, false, 500);         
            Alumno alumno2 = new Alumno("Pepe", "Peposo", 30000000, false, 500);

            Responsable responsable1 = new Responsable("Juan", "Martinez", 50000000, false, EParentesco.Padre, "15265423");
            Responsable responsable2 = new Responsable("Juan", "Martinez", 50000000, false, EParentesco.Padre, "15265423");

            alumno1.Legajo = 5;
            alumno2.Legajo = 5;
            alumno1.Responsable = responsable1;
            alumno2.Responsable = responsable2;

            altaAlumno.Alumno = alumno2;
            listaAlumnos2.Add(alumno1);
            principal.ListaAlumnos = listaAlumnos2;

            principal.ValidarAlumnoIgual(alumno2);

            //listaAlumnos2.Add(alumno1);
            //listaAlumnos.Add(alumno2);

            // principal.listaAlumnos.Add(alumno2);



            //_ = alumno1 == alumno2;//
            

          

        }


        [TestMethod]
        [ExpectedException(typeof(AlumnoIgualException))]

        public void ValidarCasteoResponsable()
        {

        }


    }
}
