﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luque.Fernando
{
    public partial class FrmReportes : Form
    {
        static List<Docente> listaDocentesMañana;
        static List<Docente> listaDocentesTarde;
        static List<Administrativo> listaNoDocente;

        string cargo;
        
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

            if(cargo=="Docente")
            {
                cargarDocentes();
            }
            else
            {
                cargarNoDocentes();
            }

            
            


        }


        public void cargarDocentes()
        {
            foreach (Docente docente in listaDocentesTarde)
            {
                ListViewItem lista = new ListViewItem(docente.Nombre);
                lista.SubItems.Add(docente.Apellido);
                lista.SubItems.Add(docente.Salario.ToString());
                lista.SubItems.Add("Docente");

                listView1.Items.Add(lista);

            }
            foreach (Docente docente in listaDocentesMañana)
            {
                ListViewItem lista = new ListViewItem(docente.Nombre);
                lista.SubItems.Add(docente.Apellido);
                lista.SubItems.Add(docente.Salario.ToString());
                lista.SubItems.Add("Docente");
                

                listView1.Items.Add(lista);

            }
        }

        public void cargarNoDocentes()
        {
            foreach (Administrativo empleado in listaNoDocente)
            {

                ListViewItem lista = new ListViewItem(empleado.Nombre);
                lista.SubItems.Add(empleado.Apellido);
                lista.SubItems.Add(empleado.Salario.ToString());
                lista.SubItems.Add(empleado.Cargo.ToString());

                

                listView1.Items.Add(lista);
            }
        }


        public List<Docente> ListaDocentesTarde
        {
            get
            {
                return listaDocentesTarde;
            }
            set
            {
                listaDocentesTarde= value;
            }
        }

        public List<Docente> ListaDocentesMañana
        {
            get
            {
                return listaDocentesMañana;
            }
            set
            {
                listaDocentesMañana = value;
            }
        }

        public List<Administrativo> ListaNoDocentes 
        {
            set
            {
                listaNoDocente = value;
            }
        }

        public string Cargo
        {
            set
            {
                cargo = value;
            }
        }


    }


    

   






}
