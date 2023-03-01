using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dfet_fnm
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC310-15\SQLEXPRESS;Initial Catalog=netu;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }
        class Weapon
        {

            public static object textBox8 { get; private set; }
            public static object textBox9 { get; private set; }
            public static object textBox10 { get; private set; }
            public static object comboBox3 { get; private set; }

            public Weapon(string nameW, double lvlW, double damageW, string typeWeaponW)
            {
                textBox8 = nameW; textBox9 = lvlW; textBox10 = damageW; comboBox3 = typeWeaponW;
            }
            public static Weapon NewCreate()
            {
                return new Weapon(textBox9.ToString(), Convert.ToInt32(textBox10.ToString()), Convert.ToInt32(textBox8.ToString()), comboBox3.ToString());
            }
            public override string ToString()
            {
                return $"Имя: {Name}\r\nФамилия: {Last_name}\r\nОтчество: {Patronymic}\r\nФункция: {Function}";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
