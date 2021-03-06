using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Net;
using System.IO;
using System;

namespace Fake_Id
{
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();

            string[] FristNamesArray = { "Mohamed", "Ahmed", "Abdelkader", "Abdelhak", "Abderrahmane", "Amine", "Ilyes", "Khaled", "Mourad", "Ismail", "Abdel Kader", "Salim", "Brahim", "Walid", "Sofiane", "Wissem", "Yahya", "Aziz", "Samir", "Fateh", "Mounir", "Kacem", "Salah", "Aymen", "Nadir", "Nabil", "Hamid", "Farid", "Saif", "Houcine", "Yacine", "Madjid", "Yanis", "Mehdi", "Sofiane", "Younes", "Amir", "Hamza", "Badredine", "Khalil", "Ayoub", "Djamel", "Sami", "Samy", "Mustapha", "Nizar", "Rabah", "Abbas", "Chakib", "Hichem", "Wassim", "Fares", "Rachid", "Farouk", "Najib", "Anis", "Karim", "Amin", "Chahid", "Youcef", "Bachir", "Nazim", "Faycal", "Malik", "Chouaib", "Nassim", "Kamel", "Yassar", "Akram", "Zakaria", "Islem" };
            string[] LastNamesArray = { "Mansouri", "Haddad", "Saidi", "Karour", "Zitouni", "Bouzid", "Boumaza", "Mebarki", "Amara", "Merabet", "Benyahia", "Yousfi", "Rahmani", "Salhi", "Touati", "Bouzidi", "Hamlaoui", "Benaissa", "Slimani", "Hatab", "Yahiaoui", "Zaidi", "Kadri", "Meziani", "Dib", "Soltani", "Benamara", "Bekkouche", "Gasmi", "Madi", "Bencheikh", "Messaoudi", "Sahraoui", "Ayadi", "Bouras", "Aissaoui", "Rouabah", "Laouar", "Filali", "Bouraoui", "Mecheri", "Hadji", "Daoudi", "Mebarkia", "Labed", "Benlabed", "Zouaoui", "Brahimi", "Boudraa", "Bouhmila", "Zarda", "Kanouni", "Hamou", "Boudief", "Ghouzlan", "Bentaleb", "Chwabi", "Najar", "Taif", "Lamouchi", "Benjdid", "Far", "Mhamdi", "Benaziz", "Itim", "Lafifi"};
            string[] BloodsArray = { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
            string[] WorksArray = { "Air Algerie", "Air Express Algeria", "Algerian Petroleum Institute", "Algerie Ferries", "Asmidal", "Cevital", "Djezzy", "ENRS", "Hamoud Boualem", "Naftal", "SNTF", "Saidal", "SNVI", "Sonatrach", "Sonelgaz", "Star Aviation", "Tassili Airlines", "Sidar sarl", "Psg eurl", "Catering chef express sarl", "Aslan construction et commerce", "Sag essalem sarl", "El kendi industries du medicam", "Shaps sarl", "Saida eurl", "Al amine gard sarl", "Sgs centre sarl", "Secur sarl", "Sss algerie sarl", "Elit spa", "Securite 2000 sarl", "Universal transit sarl", "Idoine eurl", "Transmex spa", "Dywidag international gmbh", "Somabe", "Toyota algerie spa", "Hyundai motor algerie spa", "Batimetal spa", "Snc lavalin algerie eurl", "Peugeot algerie spa", "Sarens algerie sarl", "Michelin algerie spa", "Ardis spa", "Kia motors corporation sarl", "El kendi industries du medicam", "Toyota algerie spa" };
            string[] EmailsArray = { "@gmail.com", "@hotmail.com", "@yahoo.com", "@outlook.com" ,"@outlook.fr"};
            int[] PhonesArray = { Rand.Next(0660, 0670), Rand.Next(0770, 0780), Rand.Next(0540, 0560) };
            Dictionary<int, string> States = new Dictionary<int, string>()
            {
                { 10000, "Bouira"},
                { 11000, "Tamanrasset"},
                { 12000, "Tbessa"},
                { 13000, "Tlemcen"},
                { 14000, "Tiaret"},
                { 15000, "Tizi Ouzou"},
                { 16000, "Alger"},
                { 17000, "Djelfa"},
                { 18000, "Jijel"},
                { 19000, "Setif"},
                { 20000, "Saida"},
                { 21000, "Skikda"},
                { 22000, "Sidi Bel Abbes"},
                { 23000, "Annaba"},
                { 24000, "Guelma"}
            };

            string FristName = FristNamesArray[Rand.Next(0, FristNamesArray.Length)];
            string LastName = LastNamesArray[Rand.Next(0, LastNamesArray.Length)];
            string BirthDay = Rand.Next(1, 26) + "/" + Rand.Next(1, 12) + "/" + Rand.Next(1982, 1996);
            string Blood = BloodsArray[Rand.Next(0, BloodsArray.Length)];
            var GetDict = States.ElementAt(Rand.Next(0, States.Count));
            string State = GetDict.Value;
            string PostCode = GetDict.Key.ToString();
            string Work = WorksArray[Rand.Next(0, WorksArray.Length)];
            string Email = (FristName + LastName + Rand.Next(10, 99) + EmailsArray[Rand.Next(0, EmailsArray.Length)]).ToLower();
            string Phone = "+213" + PhonesArray[Rand.Next(0, PhonesArray.Length)] + Rand.Next(222222, 999999);
            string Nin = Rand.Next(1090000000, 1091000000).ToString() + Rand.Next(1000, 9000).ToString() + "000" + Rand.Next(1,9).ToString();
            int PassportNumber = Rand.Next(200000000 , 204000000);

            string Id =
                "Frist Name: " + FristName + "\n" +
                "Last Name: " + LastName + "\n" +
                "Gender: Male" + "\n" +
                "Birthday: " + BirthDay + "\n" +
                "Blood: " + Blood + "\n" +
                "State: " + State + "\n" +
                "Postal Code: " + PostCode + "\n" +
                "Company: " + Work + "\n" +
                "Email: " + Email + "\n" +
                "Number Phone: " + Phone + "\n" +
                "National Id Number: " + Nin + "\n" +
                "Passport Number: " + PassportNumber + "\n";

            string CurrentPath = AppDomain.CurrentDomain.BaseDirectory;

            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile("https://randomuser.me/api/portraits/men/" + Rand.Next(1, 99) + ".jpg", CurrentPath + "Id.jpg");
            }

            StreamWriter Save = new StreamWriter(CurrentPath + "Id.txt");
            Save.Write(Id);
            Save.Close();

            Width = 257;
            Height = 370;

            pictureBox1.ImageLocation = "Id.jpg";
            pictureBox1.Refresh();

            label1.Text = Id + "[+] Saved";
            label1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
        private void Gui_Load(object sender, EventArgs e){}
    }
}