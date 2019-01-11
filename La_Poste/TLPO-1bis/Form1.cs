using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;


namespace TLPO_1bis
{
    public partial class Form1 : Form
    {
        protected string origine;
        protected string etape_1;
        protected string etape_2;
        protected string etape_3;
        protected string etape_4;
        protected string etape_5;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public Form1()
        {
            InitializeComponent();
            AllocConsole();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.erreur_origine.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e) //a l'action du clique récupère le texte du champs
        {
            this.origine = this.textBox_origin.Text;
            if(origine == "")
            {
                this.erreur_origine.Visible = true;
            }
            else
            { 
            this.ActionAffichageCarte();
            }

            this.etape_1 = this.textbox_etape1.Text;
            this.etape_2 = this.textbox_etape2.Text;
            this.etape_3 = this.textbox_etape3.Text;
            this.etape_4 = this.textbox_etape4.Text;
            this.etape_5 = this.textbox_etape5.Text;
        }

        private void OptimisationEtape()
        {
            string origin = this.origine;
            string destination = this.origine;
            string waypoints = etape_1 + "|" + etape_2 + "|" + etape_3 + "|" + etape_4 + "|" + etape_5;

            WebRequest request = WebRequest.Create("https://maps.googleapis.com/maps/api/directions/json?origin="+origin+"&destination="+origin+"&waypoints=optimize:true|"+waypoints);
            WebResponse reponse = request.GetResponse(); //accéder au contenu de la webresponse !!! et vérifier la chaîne de caractère, regarder ds les fonctions de webreponse, essayer un cast
                                                         //getrequeststream a lire tant qu'il y a quelque chose à lire
                                                         //Parsing des chemins de googleText pour préparer une recherche JSONPath

            Stream stream = reponse.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string reponseF = reader.ReadToEnd();
       
            Console.WriteLine(reponseF);

            JObject googleSearch = JObject.Parse(reponseF);

            //Récupèration de tous les objets "routes" dans une liste
            IList<JToken> routes = googleSearch["routes"].Children().ToList();

            //création d'un tableau récupérateur des waypoints
            int[] tabWaypoint = new int[5];

            foreach (JToken route in routes)
            {
                //désérialisation de l'objet route
                GoogleObject trajet = JsonConvert.DeserializeObject<GoogleObject>(route.ToString());
                int i = 0;
                foreach (string wayPoint in trajet.waypoint_order)
                {
                    Console.WriteLine("WayPoint n°" + i + " => " + Convert.ToInt32(wayPoint));
                    tabWaypoint[i] = Convert.ToInt32(wayPoint);
                    i++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Le tableau des waypoints :");
            for (int i=0;i<5;i++)
            {
                Console.Write(tabWaypoint[i] + " | ");
            }
            Console.ReadKey();
            //Stream dataStream = reponse.GetResponseStream();

            //  DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GoogleObject));
            // GoogleObject yourObject = (GoogleObject)serializer.ReadObject(dataStream);


            //créer une classe avec ce qui est récupérer en JSON
        }


        private void ActionAffichageCarte()
        {
            string origin = this.origine;
            string destination = this.origine;
            string waypoints = etape_1 + "|" + etape_2 + "|" + etape_3 + "|" + etape_4 + "|" + etape_5;

            string destinationURL = "https://www.google.com/maps/embed/v1/directions?key=AIzaSyBslB0ba-_L7dVOpvcDgjcneJlrAYs-pMM&origin=" + origin + "&destination=" + destination + "&avoid=tolls|highways&waypoints=" + waypoints;

            string escapeUri = Uri.EscapeUriString(destinationURL);
            System.Console.WriteLine(escapeUri);
            this.webBrowser1.Navigate(@"file://C:\Users\Olivier Dupain\Documents\visual studio 2015\Projects\TLPO-1bis\TLPO-1bis\bin\Debug\index.html?url=" + Uri.EscapeUriString(destinationURL));
        }

       

        private void etape1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void etape2_TextChanged(object sender, EventArgs e)
        {

        }

        private void etape3_TextChanged(object sender, EventArgs e)
        {

        }

        private void etape4_TextChanged(object sender, EventArgs e)
        {

        }

        private void etape5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            Console.WriteLine("voila la console :) ");
            OptimisationEtape();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
