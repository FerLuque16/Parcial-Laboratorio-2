using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luque.Fernando
{
    public partial class FrmPrincipal : Form
    {
        public static List<Alumno> listaAlumnos;
        public static List<Aula> listaAulas;
        public static List<Docente> listaDocentesTarde;
        public static List<Docente> listaDocentesMañana;
        public static List<Administrativo> listaNoDocentes;
       



        public FrmPrincipal()
        {
            InitializeComponent();
           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            listaAlumnos = new List<Alumno>();
            listaAulas = new List<Aula>();
            listaDocentesTarde = new List<Docente>();
            listaDocentesMañana = new List<Docente>();
            listaNoDocentes = new List<Administrativo>();


        }

        private void altaDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatos altaDatos = new FrmDatos();
            FrmAltaAlumno altaAlumno = new FrmAltaAlumno();
            bool repetido=false;
            DialogResult resultado;

            resultado = altaAlumno.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                foreach (Alumno alumno in listaAlumnos)
                {
                    if(alumno==altaAlumno.Alumno)
                    {
                        repetido = true;
                    }
                         
                }

                if (!repetido)
                 {
                    listaAlumnos.Add(altaAlumno.Alumno);
                    MessageBox.Show("Se agregó al alumno correctamente");
                }
                else
                    MessageBox.Show("No se puede agregar alumnos con el mismo legajo y responsable");


            }
            else
            {
                MessageBox.Show("No se agregó al alumno");
            }


        }


        public static void mensajeError()
        {
            MessageBox.Show("Datos invalidos. Revisar.", "ERROR", MessageBoxButtons.OK);
        }

        private void altaDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonal altaDocente = new FrmPersonal();         
            altaDocente.setDropDown = System.Windows.Forms.ComboBoxStyle.DropDown;
            altaDocente.SetDocente = "Docente";
            altaDocente.Habilitar = false;
            

            DialogResult resultado;

            resultado = altaDocente.ShowDialog();

            if (resultado == DialogResult.OK && altaDocente.Docente.HoraEntrada.Hour==8)
            {

                MessageBox.Show("Se agregó al docente");
                listaDocentesMañana.Add(altaDocente.Docente);
            }
            else if(resultado==DialogResult.OK && altaDocente.Docente.HoraEntrada.Hour==13)
            {
                MessageBox.Show("Se agregó al docente");
                listaDocentesTarde.Add(altaDocente.Docente);
            }
            else
            {
                MessageBox.Show("No se agrego al docente");
            }
            /* FrmPersonal altaDocente = new FrmPersonal();
             
             altaDocente.ShowDialog();*/

            /* foreach (Alumno alumno in listaAlumnos)
             {
                 MessageBox.Show(alumno.ToString());
             }
             */
        }

        private void altaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonal altaNoDocente = new FrmPersonal();
            DialogResult resultado;

            resultado=altaNoDocente.ShowDialog();


            if (resultado == DialogResult.OK)
            {

                MessageBox.Show("Se agregó al empleado");
                listaNoDocentes.Add(altaNoDocente.NoDocente);
            }
            else
            {
                MessageBox.Show("No se agrego al empleado");
            }


        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAula altaAula = new FrmAula();
            altaAula.ListaAlumnos = listaAlumnos;
            //altaAula.Li
            DialogResult resultado;
            altaAula.Color = EColores.Rojo;
            altaAula.BackColor = Color.Red;


            resultado = altaAula.ShowDialog();

        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAula altaAula = new FrmAula();
            DialogResult resultado;
            altaAula.Color = EColores.Amarillo;
            altaAula.BackColor = Color.Yellow;

        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAula altaAula = new FrmAula();
            DialogResult resultado;
            altaAula.Color = EColores.Verde;
            altaAula.BackColor = Color.Green;


        }

        private void naranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAula altaAula = new FrmAula();
            DialogResult resultado;
            altaAula.Color = EColores.Naranja;
            altaAula.BackColor = Color.Orange;


        }


        private void informacionDeLosPadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosResponsable datosResponsable = new FrmDatosResponsable();
            datosResponsable.ListaAulas = listaAulas;

            datosResponsable.ShowDialog();
        }

        private void sueldoDeLosDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes reporteDocentes = new FrmReportes();
            reporteDocentes.ListaDocentesMañana = listaDocentesMañana;
            reporteDocentes.ListaDocentesTarde = listaDocentesTarde;
            reporteDocentes.Cargo = "Docente";

            reporteDocentes.ShowDialog();
        }

        private void sueldoDeLosNoDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmReportes reporteNoDocentes = new FrmReportes();
            reporteNoDocentes.ListaNoDocentes = listaNoDocentes;

            reporteNoDocentes.ShowDialog();
        }


        // No pude cambiar el nombre a este metodo
        private void recaudacionDeCadaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecaudacion reporteAulas = new FrmRecaudacion();
            reporteAulas.ListaAulas = listaAulas;


            reporteAulas.ShowDialog();


        }

        /*private void recaudacionTotalDelJardinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecaudacion reporteJardin = new FrmRecaudacion();
            reporteJardin.ListaAulas = listaAulas;

            reporteJardin.ShowDialog();
        }*/

        public static List<Docente> DocentesTarde
        {
            get
            { 
                return listaDocentesTarde;
            }
            
        }

        

        public static List<Docente> DocentesMañana
        {
            get 
            { 
                return listaDocentesMañana; 
            }
            
        }

     

       /* public static List<Aula> Aula
        {
            get
            {
                return au;
            }
        }*/

        private void cargarPruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            #region Hardcode entidades

            Alumno alumno1  = new Alumno("Borden", "Gillson", 45455958, true, 2000);
            Alumno alumno2  = new Alumno("Irita", "Geddis", 58675283, true, 2000);
            Alumno alumno3  = new Alumno("Adina", "Bazelle", 57308185, true, 2000);
            Alumno alumno4  = new Alumno("Teodoro", "Coveney", 41401314, true, 2000);
            Alumno alumno5  = new Alumno("Amargo", "Aucott", 40501238, false, 2000);
            Alumno alumno6  = new Alumno("Bathsheba", "Carrabot", 51710605, false, 2000);
            Alumno alumno7  = new Alumno("Dorothea", "Stell", 47277897, false, 2000);
            Alumno alumno8  = new Alumno("Nicoline", "Copozio", 54941854, true, 2000 );
            Alumno alumno9  = new Alumno("Virgina", "Norville", 58838091, false, 2000);
            Alumno alumno10 = new Alumno("Pancho", "Matitiaho", 48290714, true, 2000      );
            Alumno alumno11 = new Alumno("Joli", "Trumpeter", 46851288, false, 2000     );
            Alumno alumno12 = new Alumno("Alane", "Anstead", 50551826, false, 2000      );
            Alumno alumno13 = new Alumno("Julian", "Zimmer", 45998338, true, 2000    );
            Alumno alumno14 = new Alumno("Jackson", "Mawson", 41697169, false, 2000     );
            Alumno alumno15 = new Alumno("Dalenna", "Seefus", 52770010, false, 2000      );
            Alumno alumno16 = new Alumno("Kendell", "Doche", 59231510, true, 2000         );
            Alumno alumno17 = new Alumno("Terrill", "Blaszkiewicz", 50104314, false, 2000 );
            Alumno alumno18 = new Alumno("Gnni", "Holyard", 44166353, true, 2000         );
            Alumno alumno19 = new Alumno("Robinetta", " Dutton", 46542544, true, 2000      );
            Alumno alumno20 = new Alumno("Faulkner", "Coppin", 56314905, true, 2000      );
            Alumno alumno21 = new Alumno("Nelli", "Dymoke", 40779180, false, 2000         );
            Alumno alumno22 = new Alumno("Renee", "Lensch", 49990603, true, 2000          );
            Alumno alumno23 = new Alumno("Berty", "Gilhool", 45565231, true, 2000         );
            Alumno alumno24 = new Alumno("Meghan", "Knath", 49148017, true, 2000);
            Alumno alumno25 = new Alumno("Adrian", "Aizikowitz", 53025606, true, 2000     );
            Alumno alumno26 = new Alumno("Marsiella", " Rimington", 41058242, false, 2000  );
            Alumno alumno27 = new Alumno("Ada", "Gronav", 43177060, true, 2000            );
            Alumno alumno28 = new Alumno("Isidro", "Reolfi", 43363050, true, 2000          );
            Alumno alumno29 = new Alumno("Susanna", "Storie", 56487174, false, 2000       );
            Alumno alumno30 = new Alumno("Johannav", "Rainon", 56578464, true, 2000       );
            Alumno alumno31 = new Alumno("Ira", "Alves", 49211448, true, 2000             );
            Alumno alumno32 = new Alumno("Bernadina", "McWhin", 53337963, false, 2000     );
            Alumno alumno33 = new Alumno("Geoffry", "Beneyto", 47209785, true, 2000  );
            Alumno alumno34 = new Alumno("Cathie", "Argontt", 55305481, false, 2000      );
            Alumno alumno35 = new Alumno("Claudio", "Everix", 57375906, false, 2000       );
            Alumno alumno36 = new Alumno("Renado", "Prattington", 43950279, false, 2000    );
            Alumno alumno37 = new Alumno("Tyrus", "Gristhwaite", 55845354, false, 2000     );
            Alumno alumno38 = new Alumno("Jerrold", "Sizzey", 52640509, true, 2000       );
            Alumno alumno39 = new Alumno("Keely", "Janecki", 54257424, true, 2000        );
            Alumno alumno40 = new Alumno("Cristobal", "Yeates", 48250672, false, 2000   );
            Alumno alumno41 = new Alumno("Dionysus", "Tredger", 55572715, false, 2000   );
            Alumno alumno42 = new Alumno("Matteo", "Kings", 48472065, false, 2000     );
            Alumno alumno43 = new Alumno("Ermengarde", "Janca", 47819612, false, 2000     );
            Alumno alumno44 = new Alumno("Richie", "Zeplin", 53942733, false, 2000     );
            Alumno alumno45= new Alumno("Juliana", "Simonnot", 56912492, true, 2000      );
            Alumno alumno46 = new Alumno("Vannie", "Dirand", 50816229, false, 2000     );
            Alumno alumno47 = new Alumno("Janis", "Emanuele", 40418631,true,2000    );
            Alumno alumno48 = new Alumno("Erv", "Logesdale", 45276939, true, 2000      );
            Alumno alumno49 = new Alumno("Rolph", " Anthiftle", 55675101, true, 2000       );
            Alumno alumno50 = new Alumno("Rudolfo", " Simonnot", 40241909, false, 2000);


            alumno1. Legajo=1;
            alumno2. Legajo=2;
            alumno3. Legajo=3;
            alumno4. Legajo=4;
            alumno5. Legajo=5;
            alumno6. Legajo=6;
            alumno7. Legajo=7;
            alumno8. Legajo=8;
            alumno9. Legajo=9;
            alumno10.Legajo=10;
            alumno11.Legajo=11;
            alumno12.Legajo=12;
            alumno13.Legajo=13;
            alumno14.Legajo=14;
            alumno15.Legajo=15;
            alumno16.Legajo=16;
            alumno17.Legajo=17;
            alumno18.Legajo=18;
            alumno19.Legajo=19;
            alumno20.Legajo=20;
            alumno21.Legajo=21;
            alumno22.Legajo=22;
            alumno23.Legajo=23;
            alumno24.Legajo=24;
            alumno25.Legajo=25;
            alumno26.Legajo=26;
            alumno27.Legajo=27;
            alumno28.Legajo=28;
            alumno29.Legajo=29;
            alumno30.Legajo=30;
            alumno31.Legajo=31;
            alumno32.Legajo=32;
            alumno33.Legajo=33;
            alumno34.Legajo=34;
            alumno35.Legajo=35;
            alumno36.Legajo=36;
            alumno37.Legajo=37;
            alumno38.Legajo=38;
            alumno39.Legajo=39;
            alumno40.Legajo=40;
            alumno41.Legajo=41;
            alumno42.Legajo=42;
            alumno43.Legajo=43;
            alumno44.Legajo=44;
            alumno45.Legajo=45;
            alumno46.Legajo=46;
            alumno47.Legajo=47;
            alumno48.Legajo=48;
            alumno49.Legajo=49;
            alumno50.Legajo =50;

            alumno1.ColorSala=EColores.Rojo;
            alumno2.ColorSala=EColores.Rojo;
            alumno3.ColorSala=EColores.Rojo;
            alumno4.ColorSala=EColores.Rojo;
            alumno5.ColorSala=EColores.Rojo;
            alumno6.ColorSala=EColores.Rojo;
            alumno7.ColorSala=EColores.Rojo;
            alumno8.ColorSala=EColores.Rojo;
            alumno9.ColorSala=EColores.Rojo;
            alumno10.ColorSala = EColores.Rojo;
            alumno11.ColorSala=EColores.Rojo;
            alumno12.ColorSala=EColores.Rojo;
            alumno13.ColorSala=EColores.Rojo;
            alumno14.ColorSala=EColores.Rojo;
            alumno15.ColorSala=EColores.Rojo;
            alumno16.ColorSala=EColores.Rojo;
            alumno17.ColorSala=EColores.Rojo;
            alumno18.ColorSala=EColores.Rojo;
            alumno19.ColorSala=EColores.Rojo;
            alumno20.ColorSala=EColores.Rojo;
            alumno21.ColorSala=EColores.Rojo;
            alumno22.ColorSala=EColores.Rojo;
            alumno23.ColorSala=EColores.Rojo;
            alumno24.ColorSala=EColores.Rojo;
            alumno25.ColorSala=EColores.Rojo;
            alumno26.ColorSala=EColores.Rojo;
            alumno27.ColorSala=EColores.Rojo;
            alumno28.ColorSala=EColores.Rojo;
            alumno29.ColorSala = EColores.Rojo;
            alumno30.ColorSala=EColores.Rojo;
            alumno31.ColorSala=EColores.Rojo;
            alumno32.ColorSala=EColores.Rojo;
            alumno33.ColorSala=EColores.Rojo;
            alumno34.ColorSala=EColores.Rojo;
            alumno35.ColorSala=EColores.Rojo;
            alumno36.ColorSala=EColores.Rojo;
            alumno37.ColorSala=EColores.Rojo;
            alumno38.ColorSala=EColores.Rojo;
            alumno39.ColorSala=EColores.Rojo;
            alumno40.ColorSala=EColores.Rojo;
            alumno41.ColorSala = EColores.Verde;
            alumno42.ColorSala=EColores.Amarillo;
            alumno43.ColorSala=EColores.Amarillo;
            alumno44.ColorSala=EColores.Amarillo;
            alumno45.ColorSala=EColores.Amarillo;
            alumno46.ColorSala=EColores.Amarillo;
            alumno47.ColorSala=EColores.Amarillo;
            alumno48.ColorSala=EColores.Amarillo;
            alumno49.ColorSala=EColores.Amarillo;
            alumno50.ColorSala = EColores.Amarillo;



         Responsable responsable1   =new Responsable(  "Panchito","Spawton",46397333,false,   EParentesco.Otro,"1173846465"); 
         Responsable responsable2   =new Responsable(  "Ives","Sircomb",42893164,false,       EParentesco.Otro,"1191250253");
         Responsable responsable3   =new Responsable(  "Lucia","McCleary",48569253,false ,    EParentesco.Otro,"1183629125");
         Responsable responsable4   =new Responsable(  "Johny","Shirrell",42232266,false,     EParentesco.Otro,"1118759464");
         Responsable responsable5   =new Responsable(  "Teirtza","Lubeck",48399746,false,     EParentesco.Otro,"1166803037");
         Responsable responsable6   =new Responsable(  "Thorn","Juckes",55971925,false,       EParentesco.Otro,"1120500254");
         Responsable responsable7   =new Responsable(  "Darcy","Maccraw",55685197,false,      EParentesco.Otro,"1184264593");
         Responsable responsable8   =new Responsable(  "Morly","Windrum",48579129,true,       EParentesco.Otro,"1152134468");
         Responsable responsable9   =new Responsable(  "Michaeline","Jenicke",51656807,true,  EParentesco.Otro,"1152847010");
         Responsable responsable10  =new Responsable(  "Corry","Gisburne",41957957,false,     EParentesco.Otro,"1164441605");
         Responsable responsable11  =new Responsable(  "Kincaid","Quarless",47924328,true,    EParentesco.Otro,"1192867094");
         Responsable responsable12  =new Responsable(  "Benedicto","Buzin",45049619,true,     EParentesco.Otro,"1114031428");
         Responsable responsable13  =new Responsable(  "Wernher","Slatten",45963368,true,     EParentesco.Otro,"1108882008");
         Responsable responsable14  =new Responsable(  "Danica","Elvins",56954842,false,      EParentesco.Otro,"1148770941");
         Responsable responsable15  =new Responsable(  "Carmelita","Bastiman",51839524,true,  EParentesco.Otro,"1103262613");
         Responsable responsable16  =new Responsable(  "Kaila","Grzeskowski",47991000,true,   EParentesco.Otro,"1110948789");
         Responsable responsable17  =new Responsable(  "Price","Brisley",49051649,true,       EParentesco.Otro,"1176114965");
         Responsable responsable18  =new Responsable(  "Darcey","Scraney",54985140,false,     EParentesco.Otro,"1166355770");
         Responsable responsable19  =new Responsable(  "Klarrisa","Grimmert",45526811,false,  EParentesco.Otro,"1147132704");
         Responsable responsable20  =new Responsable(  "Yetty","Sucre",50012287,false,        EParentesco.Otro,"1192204639");
         Responsable responsable21  =new Responsable(  "Wynny","Denyagin",45866913,true,      EParentesco.Otro,"1195615483");
         Responsable responsable22  =new Responsable(  "Elspeth","Banner",46108875,true,      EParentesco.Otro,"1161197236");
         Responsable responsable23  =new Responsable(  "Simon","Jupp",40959254,true,          EParentesco.Otro,"1102120558");
         Responsable responsable24  =new Responsable(  "Leigh","Gunter",56728663,true,        EParentesco.Otro,"1196700952");
         Responsable responsable25  =new Responsable(  "Donni","Taffarello",46517297,false,   EParentesco.Otro,"1185007326");
         Responsable responsable26  =new Responsable(  "Donielle","Theurer",42924345,false,   EParentesco.Otro,"1114185398");
         Responsable responsable27  =new Responsable(  "Jose","Albone",53991755,true,         EParentesco.Otro,"1123280829");
         Responsable responsable28  =new Responsable(  "Shina","Buckthorpe",44420347,false,   EParentesco.Otro,"1100830865");
         Responsable responsable29  =new Responsable(  "Daryle","Keunemann",46561324,true,    EParentesco.Otro,"1152317763");
         Responsable responsable30  =new Responsable(  "Chelsie","Hebard",56385347,true,      EParentesco.Otro,"1105062568");
         Responsable responsable31  =new Responsable(  "Godfrey","Terzo",41354501,true,       EParentesco.Otro,"1130126746");
         Responsable responsable32  =new Responsable(  "Roze","Gibke",53614817,true,          EParentesco.Otro,"1132997504");
         Responsable responsable33  =new Responsable(  "Leupold","Pippin",48936572,false,     EParentesco.Otro,"1146265433");
         Responsable responsable34  =new Responsable(  "Jeni","Morsley",58279807,false,       EParentesco.Otro,"1142289666");
         Responsable responsable35  =new Responsable(  "Waverly","Lampitt",58285840,false,    EParentesco.Otro,"1136682697");
         Responsable responsable36  =new Responsable(  "Martelle","Alsop",43988903,true,      EParentesco.Otro,"1199425579");
         Responsable responsable37  =new Responsable(  "Sophronia","Drezzer",51408382,true,   EParentesco.Otro,"1150304011");
         Responsable responsable38  =new Responsable(  "Karee","Girardengo",50517684,true,    EParentesco.Otro,"1111238907");
         Responsable responsable39  =new Responsable(  "Vikki","Shemmans",56467751,true,      EParentesco.Otro,"1181643448");
         Responsable responsable40  =new Responsable(  "Katusha","Daveran",42317431,false,    EParentesco.Otro,"1115914027");
         Responsable responsable41  =new Responsable(  "Veronike","Cicculini",49521440,false, EParentesco.Otro,"1199090796");
         Responsable responsable42  =new Responsable(  "Mignonne","Jovic",41935063,true,      EParentesco.Otro,"1144230537");
         Responsable responsable43  =new Responsable(  "Colleen","Winkless",56996974,false,   EParentesco.Otro,"1118431445");
         Responsable responsable44  =new Responsable(  "Chev","De la Yglesia",54045873,false, EParentesco.Otro,"1126992049");
         Responsable responsable45  =new Responsable(  "Crissy","Huck",49965620,false,        EParentesco.Otro,"1125673925");
         Responsable responsable46  =new Responsable(  "Jeannette","Yakubowicz",53677007,true,EParentesco.Otro,"1174004220");
         Responsable responsable47  =new Responsable(  "Niki","Danielsson",52158872,false,    EParentesco.Otro,"1121489099");
         Responsable responsable48  =new Responsable(  "Chester","Luckes",47038145,false,     EParentesco.Otro,"1165746956");
         Responsable responsable49  =new Responsable(  "Verne","Haddow",52391037,false,       EParentesco.Otro,"1197660414");
         Responsable responsable50  =new Responsable(  "Angelo","Simcock",58663956,false,     EParentesco.Otro,"1157597598");





            alumno1. Responsable=responsable1 ;
            alumno2. Responsable=responsable2 ;
            alumno3. Responsable=responsable3 ;
            alumno4. Responsable=responsable4 ;
            alumno5. Responsable=responsable5 ;
            alumno6. Responsable=responsable6 ;
            alumno7. Responsable=responsable7 ;
            alumno8. Responsable=responsable8 ;
            alumno9. Responsable=responsable9 ;
            alumno10.Responsable=responsable10;
            alumno11.Responsable=responsable11;
            alumno12.Responsable=responsable12;
            alumno13.Responsable=responsable13;
            alumno14.Responsable=responsable14;
            alumno15.Responsable=responsable15;
            alumno16.Responsable=responsable16;
            alumno17.Responsable=responsable17;
            alumno18.Responsable=responsable18;
            alumno19.Responsable=responsable19;
            alumno20.Responsable=responsable20;
            alumno21.Responsable=responsable21;
            alumno22.Responsable=responsable22;
            alumno23.Responsable=responsable23;
            alumno24.Responsable=responsable24;
            alumno25.Responsable=responsable25;
            alumno26.Responsable=responsable26;
            alumno27.Responsable=responsable27;
            alumno28.Responsable=responsable28;
            alumno29.Responsable=responsable29;
            alumno30.Responsable=responsable30;
            alumno31.Responsable=responsable31;
            alumno32.Responsable=responsable32;
            alumno33.Responsable=responsable33;
            alumno34.Responsable=responsable34;
            alumno35.Responsable=responsable35;
            alumno36.Responsable=responsable36;
            alumno37.Responsable=responsable37;
            alumno38.Responsable=responsable38;
            alumno39.Responsable=responsable39;
            alumno40.Responsable=responsable40;
            alumno41.Responsable=responsable41;
            alumno42.Responsable=responsable42;
            alumno43.Responsable=responsable43;
            alumno44.Responsable=responsable44;
            alumno45.Responsable=responsable45;
            alumno46.Responsable=responsable46;
            alumno47.Responsable=responsable47;
            alumno48.Responsable=responsable48;
            alumno49.Responsable=responsable49;
            alumno50.Responsable = responsable50;

            listaAlumnos.Add(alumno1 );
            listaAlumnos.Add(alumno2 );
            listaAlumnos.Add(alumno3 );
            listaAlumnos.Add(alumno4 );
            listaAlumnos.Add(alumno5 );
            listaAlumnos.Add(alumno6 );
            listaAlumnos.Add(alumno7 );
            listaAlumnos.Add(alumno8 );
            listaAlumnos.Add(alumno9 );
            listaAlumnos.Add(alumno10);
            listaAlumnos.Add(alumno11);
            listaAlumnos.Add(alumno12);
            listaAlumnos.Add(alumno13);
            listaAlumnos.Add(alumno14);
            listaAlumnos.Add(alumno15);
            listaAlumnos.Add(alumno16);
            listaAlumnos.Add(alumno17);
            listaAlumnos.Add(alumno18);
            listaAlumnos.Add(alumno19);
            listaAlumnos.Add(alumno20);
            listaAlumnos.Add(alumno21);
            listaAlumnos.Add(alumno22);
            listaAlumnos.Add(alumno23);
            listaAlumnos.Add(alumno24);
            listaAlumnos.Add(alumno25);
            listaAlumnos.Add(alumno26);
            listaAlumnos.Add(alumno27);
            listaAlumnos.Add(alumno28);
            listaAlumnos.Add(alumno29);
            listaAlumnos.Add(alumno30);
            listaAlumnos.Add(alumno31);
            listaAlumnos.Add(alumno32);
            listaAlumnos.Add(alumno33);
            listaAlumnos.Add(alumno34);
            listaAlumnos.Add(alumno35);
            listaAlumnos.Add(alumno36);
            listaAlumnos.Add(alumno37);
            listaAlumnos.Add(alumno38);
            listaAlumnos.Add(alumno39);
            listaAlumnos.Add(alumno40);
            listaAlumnos.Add(alumno41);
            listaAlumnos.Add(alumno42);
            listaAlumnos.Add(alumno43);
            listaAlumnos.Add(alumno44);
            listaAlumnos.Add(alumno45);
            listaAlumnos.Add(alumno46);
            listaAlumnos.Add(alumno47);
            listaAlumnos.Add(alumno48);
            listaAlumnos.Add(alumno49);
            listaAlumnos.Add(alumno50);




         Docente docente1=new Docente   ("Margalo","Fells",49188601,false,DateTime.Parse("13:00"),DateTime.Parse("17:00"),100);
         Docente docente2=new Docente   ("Gris","Takis",58206613,true,DateTime.Parse("13:00"),DateTime.Parse("17:00"),100);
         Docente docente3=new Docente   ("Sherrie","Checketts",47440718,true,DateTime.Parse("13:00"),DateTime.Parse("17:00"),100);
         Docente docente4=new Docente   ("Gisele","Fosten",51029089,false,DateTime.Parse("08:00"),DateTime.Parse("12:00"),100);
         Docente docente5=new Docente   ("Pearla","Marvel",58750918,false,DateTime.Parse("08:00 "),DateTime.Parse("12:00"),100);
         Docente docente6=new Docente   ("Kipp","Levicount",55502388,false,DateTime.Parse("08:00 "),DateTime.Parse("12:00"),100);





         listaDocentesTarde.Add(docente1);
         listaDocentesTarde.Add(docente2);
         listaDocentesTarde.Add(docente3);
         listaDocentesMañana.Add(docente4);
         listaDocentesMañana.Add(docente5);
         listaDocentesMañana.Add(docente6);


        Administrativo noDocente1=new Administrativo("Margalo", "Fells", 49188601, false, DateTime.Parse("13:00"), DateTime.Parse("17:00"),ECargo.Cocina);
        Administrativo noDocente2=new Administrativo("Gris", "Takis", 58206613, true, DateTime.Parse("13:00"), DateTime.Parse("17:00"),ECargo.Direccion);
        Administrativo noDocente3=new Administrativo("Sherrie", "Checketts", 47440718, true, DateTime.Parse("13:00"), DateTime.Parse("17:00"),ECargo.Porteria);
        Administrativo noDocente4=new Administrativo("Pearla", "Marvel", 58750918, false, DateTime.Parse("08:00 "), DateTime.Parse("12:00"),ECargo.Secretaria);
        Administrativo noDocente5=new Administrativo("Kipp", "Levicount", 55502388, false, DateTime.Parse("08:00 "), DateTime.Parse("12:00"),ECargo.Tesoreria);

        listaNoDocentes.Add(noDocente1);
        listaNoDocentes.Add(noDocente2);
        listaNoDocentes.Add(noDocente3);
        listaNoDocentes.Add(noDocente4);
        listaNoDocentes.Add(noDocente5);

            #endregion Hardcode 

        Aula aula1 = new Aula(EColores.Amarillo, Eturno.mañana, docente4);
        Aula aula2 = new Aula(EColores.Rojo, Eturno.tarde, docente1);
        Aula aula3 = new Aula(EColores.Verde, Eturno.tarde, docente6);



        List<Alumno> listaAlumnos2 = new List<Alumno>();
        List<Alumno> listaAlumnos3 = new List<Alumno>();
        List<Alumno> listaAlumnos4 = new List<Alumno>();
        aula1.Alumnos = listaAlumnos2;
        aula2.Alumnos = listaAlumnos3;
        aula3.Alumnos = listaAlumnos4;

            
            
           // if(aula1+alumno1)
            //{
                if (aula1 + alumno2)
                    if(aula1+alumno16)
                    {

                    }
            //}



            if (aula2 + alumno5)
            {
                if (aula2 + alumno17)
                {

                }
            }
            
            if(aula3+alumno30)
            {
                if(aula3+alumno35)
                {
                    if(aula3+alumno20)
                    {

                    }
                }
            }
            
            

            listaAulas.Add(aula1);
            listaAulas.Add(aula2);
            listaAulas.Add(aula3);







        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
