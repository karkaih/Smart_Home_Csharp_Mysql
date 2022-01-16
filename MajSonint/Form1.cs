using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MajSonint
{
    public partial class Form1 : Form
    {
        string myConnectionString = "server=localhost;database=departement;uid=root;pwd=;";

        String status  = "";
        String status1 = "";
        int id;
        String zone="";

public Form1()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (!status.Equals(""))
            {
                if (zone.Equals("z4"))
                {
                    connectZ4(status, zone, sender, e);
                }

                if (zone.Equals("z1"))
                {
                    connectZ1(status, zone, sender, e);
                }
                if (zone.Equals("z2"))
                {
                    connectZ2(status, zone, sender, e);
                }
                if (zone.Equals("z3"))
                {
                    connectZ3(status, zone, sender, e);
                }

            }

            else
            {
                MessageBox.Show("chose zone item");

            }




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "Z1":
                    AddZ1();
                    break;
                case "Z2":
                    AddZ2();
                    break;
                case "Z3":
                    AddZ3();
                    break;
                case "Z4":
                    AddZ4();
                    break;

                default: MessageBox.Show("choisi la zone ! ");
                    break;

            }
          
          

        }
        private void donothing(object sender, EventArgs e)
        {

           

        }
//Ajouter  a Z1 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        void AddZ1()
        {

            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            if(textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("something went wrong ! ");
            }
            else
            {
                String zone1 = "z1";
                cnn.Open();
                string cmdText = "INSERT INTO Z1(Description, Nom, status1,status2,Zone) VALUES (@Desc, @Nom, '" + 0 + "','" + 0 + "','" + zone1+ "')";
                MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
                cmd.Parameters.AddWithValue("@Desc", textBox2.Text);
                cmd.Parameters.AddWithValue("@Nom", textBox1.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Z1 a ete ajouter ! ");

                Button button = new Button();
                button.Click += new EventHandler(btn_ClickZ1);
                button.Text = textBox1.Text;
                button.Name = textBox1.Text;
                button.BackColor = Color.Red;
                button.Height = 30;
               // button.Enabled = false;
                button.Dock = DockStyle.Top;
                panel1.Controls.Add(button);
                panel1.Controls.SetChildIndex(button, 0);
               
                cnn.Close();
            }
           
        }


        //Ajouter  a Z2 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        void AddZ2()
        {

            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("something went wrong ! ");
            }
            else
            {
                String zone2 = "z2";
                cnn.Open();
                string cmdText = "INSERT INTO Z2(Description, Nom, status1,status2,Zone) VALUES (@Desc, @Nom, '" + 0 + "','" + 0 + "','" + zone2+ "')";
              
                MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
                cmd.Parameters.AddWithValue("@Desc", textBox2.Text);
                cmd.Parameters.AddWithValue("@Nom", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Z2 a ete ajouter ! ");

                Button button = new Button();

                button.Click += new EventHandler(btn_ClickZ2);
                button.Text = textBox1.Text;
                button.Name = textBox1.Text;
                button.BackColor = Color.Red;
                button.Height = 30;
              //  button.Enabled = false;
                button.Dock = DockStyle.Top;
                panel3.Controls.Add(button);
                panel3.Controls.SetChildIndex(button, 0);

                cnn.Close();
            }

        }

        //Ajouter  a Z3 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        void AddZ3()
        {

            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("something went wrong ! ");
            }
            else
            {
                String zone3 = "z3";
                cnn.Open();
                string cmdText = "INSERT INTO Z3(Description, Nom, status1,status2,Zone) VALUES (@Desc, @Nom, '" + 0 + "','" + 0 + "','" + zone3+ "')";
                MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
                cmd.Parameters.AddWithValue("@Desc", textBox2.Text);
                cmd.Parameters.AddWithValue("@Nom", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Z3 a ete ajouter ! ");

                Button button = new Button();

                button.Click += new EventHandler(btn_ClickZ3);
                button.Text = textBox1.Text;
                button.Name = textBox1.Text;
                button.BackColor = Color.Red;
                button.Height = 30;
               // button.Enabled = false;
                button.Dock = DockStyle.Top;
                panel4.Controls.Add(button);
                panel4.Controls.SetChildIndex(button, 0);


                cnn.Close();
            }

        }

        //Ajouter  a Z4 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        void AddZ4()
        {

            MySqlConnection cnn = new MySqlConnection(myConnectionString);
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("something went wrong ! ");
            }
            else
            { String zone4 = "z4";
                cnn.Open();
                string cmdText = "INSERT INTO Z4(Description, Nom, status1,status2,Zone) VALUES (@Desc, @Nom, '" + 0 + "','" + 0 + "','" + zone4 + "')";
                MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
                cmd.Parameters.AddWithValue("@Desc", textBox2.Text);
                cmd.Parameters.AddWithValue("@Nom", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Z4 a ete ajouter ! ");

    /*
                Label lbl = new Label();
                lbl.Name = textBox1.Text;
                lbl.Parent = panel5;
                lbl.Text = textBox1.Text;
                lbl.SetBounds(10, 10, 75, 21);

                Button btn = new Button();
                btn.Name = textBox1.Text;
                btn.Parent = panel5;
                btn.Text = "On/Off";
                btn.SetBounds(10, 50, 75, 21);
                btn.Click += btn_Click;
 */
              
            
                Button button = new Button();

                button.Click += new EventHandler(btn_ClickZ4);
           

                button.Text = textBox1.Text;
                button.Name = textBox1.Text;
                button.BackColor = Color.Red;
                button.Height = 30;
                // button.Enabled = false;
             
                button.Dock = DockStyle.Top;
                panel5.Controls.Add(button);
                panel5.Controls.SetChildIndex(button, 0);
               
                cnn.Close();

            }



        }

        //Mouse hover z4 
        
        //Update a Z4 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        void btn_ClickZ4(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                MySqlConnection con = new MySqlConnection(myConnectionString);
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT status1 FROM z4 where Nom = '" + ((Button)sender).Name + "' ", con);
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                reader2.Read();
               

                if (reader2["status1"].ToString().Equals("0"))
                {
                    MySqlConnection con1 = new MySqlConnection(myConnectionString);
                    con1.Open();

                    MySqlCommand cmd = new MySqlCommand("update z4 set status1 = '" + 1 + "' where Nom = '" + ((Button)sender).Name + "'  ", con1);
                    cmd.ExecuteReader();
                   ((Button)sender).BackColor = Color.Green;
                    MessageBox.Show(((Button)sender).Name + " ON");

                    con1.Close();

                    System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                    ToolTip1.SetToolTip(((Button)sender),((Button)sender).Text);

                }
                if (reader2["status1"].ToString().Equals("1") )
                {
                    MySqlConnection con1 = new MySqlConnection(myConnectionString);
                    con1.Open();

                    MySqlCommand cmd = new MySqlCommand("update z4 set status1 = '" + 0 + "' where Nom = '" + ((Button)sender).Name + "'  ", con1);
                    cmd.ExecuteReader();
                    ((Button)sender).BackColor = Color.Red;
                    MessageBox.Show(((Button)sender).Name + " OFF");
                    con1.Close();
           
                }

                con.Close();
              
            }
        }




        //Update a Z2 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        void btn_ClickZ2(object sender, EventArgs e)
        {
            if (sender is Button)
            {

                MySqlConnection con = new MySqlConnection(myConnectionString);
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT status1 FROM z2 where Nom = '" + ((Button)sender).Name + "' ", con);
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                reader2.Read();


                if (reader2["status1"].ToString().Equals("0"))
                {
                    MySqlConnection con1 = new MySqlConnection(myConnectionString);
                    con1.Open();

                    MySqlCommand cmd = new MySqlCommand("update z2 set status1 = '" + 1 + "' where Nom = '" + ((Button)sender).Name + "'  ", con1);
                    cmd.ExecuteReader();
                    ((Button)sender).BackColor = Color.Green;
                    MessageBox.Show(((Button)sender).Name + " ON");

                    con1.Close();

                }
                if (reader2["status1"].ToString().Equals("1"))
                {
                    MySqlConnection con1 = new MySqlConnection(myConnectionString);
                    con1.Open();

                    MySqlCommand cmd = new MySqlCommand("update z2 set status1 = '" + 0 + "' where Nom = '" + ((Button)sender).Name + "'  ", con1);
                    cmd.ExecuteReader();
                    ((Button)sender).BackColor = Color.Red;
                    MessageBox.Show(((Button)sender).Name + " OFF");
                    con1.Close();
                }

                con.Close();


            }
        }

        //Update a Z3 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        void btn_ClickZ3(object sender, EventArgs e)
        {
            if (sender is Button)
            {

                MySqlConnection con = new MySqlConnection(myConnectionString);
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT status1 FROM z3 where Nom = '" + ((Button)sender).Name + "' ", con);
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                reader2.Read();


                if (reader2["status1"].ToString().Equals("0"))
                {
                    MySqlConnection con1 = new MySqlConnection(myConnectionString);
                    con1.Open();

                    MySqlCommand cmd = new MySqlCommand("update z3 set status1 = '" + 1 + "' where Nom = '" + ((Button)sender).Name + "'  ", con1);
                    cmd.ExecuteReader();
                    ((Button)sender).BackColor = Color.Green;
                    MessageBox.Show(((Button)sender).Name + " ON");

                    con1.Close();

                }
                if (reader2["status1"].ToString().Equals("1"))
                {
                    MySqlConnection con1 = new MySqlConnection(myConnectionString);
                    con1.Open();

                    MySqlCommand cmd = new MySqlCommand("update z3 set status1 = '" + 0 + "' where Nom = '" + ((Button)sender).Name + "'  ", con1);
                    cmd.ExecuteReader();
                    ((Button)sender).BackColor = Color.Red;
                    MessageBox.Show(((Button)sender).Name + " OFF");
                    con1.Close();
                }

                con.Close();



            }
        }


        //Update a Z1 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        void btn_ClickZ1(object sender, EventArgs e)
        {
            if (sender is Button)
            {

                MySqlConnection con = new MySqlConnection(myConnectionString);
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT status1 FROM z1 where Nom = '" + ((Button)sender).Name + "' ", con);
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                reader2.Read();


                if (reader2["status1"].ToString().Equals("0"))
                {
                    MySqlConnection con1 = new MySqlConnection(myConnectionString);
                    con1.Open();

                    MySqlCommand cmd = new MySqlCommand("update z1 set status1 = '" + 1 + "' where Nom = '" + ((Button)sender).Name + "'  ", con1);
                    cmd.ExecuteReader();
                    ((Button)sender).BackColor = Color.Green;
                    MessageBox.Show(((Button)sender).Name + " ON");

                    con1.Close();

                }
                if (reader2["status1"].ToString().Equals("1"))
                {
                    MySqlConnection con1 = new MySqlConnection(myConnectionString);
                    con1.Open();

                    MySqlCommand cmd = new MySqlCommand("update z1 set status1 = '" + 0 + "' where Nom = '" + ((Button)sender).Name + "'  ", con1);
                    cmd.ExecuteReader();
                    ((Button)sender).BackColor = Color.Red;
                    MessageBox.Show(((Button)sender).Name + " OFF");
                    con1.Close();
                }

                con.Close();


            }
        }






        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //       LoadData +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void Form1_Load(object sender, EventArgs e)
        {

            //Z4 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            MySqlConnection con = new MySqlConnection(myConnectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM z4", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {


                Button button = new Button();

                button.Click += new EventHandler(btn_ClickZ4);
                button.Text = reader["Nom"].ToString();
                button.Name = reader["Nom"].ToString();
                if (reader["status1"].ToString() == "0")
                {
                    button.BackColor = Color.Red;
                }
                if (reader["status1"].ToString() == "1")
                {
                    button.BackColor = Color.Green;
                }
                button.Height = 30;
                // button.Enabled = false;
                button.Dock = DockStyle.Top;
                panel5.Controls.Add(button);
                panel5.Controls.SetChildIndex(button, 0);
            }

            con.Close();


            con.Open();

            //z1 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM z1", con);
            MySqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {


                Button button = new Button();

                button.Click += new EventHandler(btn_ClickZ1);
                button.Text = reader1["Nom"].ToString();
                button.Name = reader1["Nom"].ToString();
                if (reader1["status1"].ToString() == "0")
                {
                    button.BackColor = Color.Red;
                }
                if (reader1["status1"].ToString() == "1")
                {
                    button.BackColor = Color.Green;
                }
                      button.Height = 30;
                // button.Enabled = false;
                button.Dock = DockStyle.Top;
                panel1.Controls.Add(button);
                panel1.Controls.SetChildIndex(button, 0);
            }

            con.Close();



            con.Open();
            //z2+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM z2", con);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {


                Button button = new Button();

                button.Click += new EventHandler(btn_ClickZ2);
                button.Text = reader2["Nom"].ToString();
                button.Name = reader2["Nom"].ToString();
                if (reader2["status1"].ToString() == "0")
                {
                    button.BackColor = Color.Red;
                }
                if (reader2["status1"].ToString() == "1")
                {
                    button.BackColor = Color.Green;
                }
                button.Height = 30;
                // button.Enabled = false;
                button.Dock = DockStyle.Top;
                panel3.Controls.Add(button);
                panel3.Controls.SetChildIndex(button, 0);
            }

            con.Close();





            con.Open();
            //z3+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM z3", con);
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                Button button = new Button();

                button.Click += new EventHandler(btn_ClickZ4);
                button.Text = reader3["Nom"].ToString();
                button.Name = reader3["Nom"].ToString();

                if (reader3["status1"].ToString() == "0")
                {
                    button.BackColor = Color.Red;
                }
                if (reader3["status1"].ToString() == "1")
                {
                    button.BackColor = Color.Green;
                }

                button.Height = 30;
                // button.Enabled = false;
                button.Dock = DockStyle.Top;
                panel4.Controls.Add(button);
                panel4.Controls.SetChildIndex(button, 0);

            }

            con.Close();
        }

        // Data from z1 to dtagrid +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(myConnectionString);

            con.Open();

            String query = "SELECT * FROM z1 ";

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = con;
            cmd.CommandText = query;

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;


            dataGridView1.DataSource = dt;

            int rowc = dataGridView1.Rows.Count - 1;
            for (int i = 0; i <= rowc; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "1")
                {

                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Green;

                }

                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "0")
                {

                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Red;

                }


                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "1")
                {

                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Green;

                }

                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "0")
                {

                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Red;

                }

            }
            con.Close();
        }

       

       

        // Data from z2 to dtagrid +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(myConnectionString);

            con.Open();

            String query = "SELECT * FROM z2 ";

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = con;
            cmd.CommandText = query;

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;


            dataGridView1.DataSource = dt;

            int rowc = dataGridView1.Rows.Count - 1;
            for (int i = 0; i <= rowc; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "1")
                {

                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Green;

                }

                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "0")
                {

                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Red;

                }


                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "1")
                {

                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Green;

                }

                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "0")
                {

                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Red;

                }

            }
            con.Close();
        }
        // Data from z3 to dtagrid +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(myConnectionString);

            con.Open();

            String query = "SELECT * FROM z3 ";

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = con;
            cmd.CommandText = query;

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;


            dataGridView1.DataSource = dt;

            int rowc = dataGridView1.Rows.Count - 1;
            for (int i = 0; i <= rowc; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "1")
                {

                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Green;

                }

                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "0")
                {

                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Red;

                }


                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "1")
                {

                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Green;

                }

                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "0")
                {

                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Red;

                }

            }
            con.Close();
        }

        // Data from z4 to dtagrid +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void button7_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(myConnectionString);

            con.Open();

            String query = "SELECT * FROM z4 ";

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = con;
            cmd.CommandText = query;

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();

            da.Fill(dt);


            dataGridView1.DataSource = dt;

            int rowc = dataGridView1.Rows.Count - 1;
            for (int i = 0; i <= rowc; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "1")
                {

                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Green;

                }

                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "0")
                {

                    dataGridView1.Rows[i].Cells[4].Style.BackColor= Color.Red;

                }


                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "1")
                {

                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Green;

                }

                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "0")
                {
                   
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Red;

                }

            }
            con.Close();
        }


        //Data grid ++++++++++++++++ +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            



            if (dataGridView1.SelectedRows.Count > 0)
            {


                DataGridViewRow row = dataGridView1.SelectedRows[0];
                id                            = int.Parse(row.Cells[0].Value.ToString());
                textBox1.Text                 = row.Cells[2].Value.ToString();
                textBox2.Text                 = row.Cells[1].Value.ToString();
                status                        = row.Cells[3].Value.ToString();
                status1                       = row.Cells[4].Value.ToString();
                comboBox1.Text= zone          = row.Cells[5].Value.ToString();
              


            }
            else
            {  
                //optional    
                MessageBox.Show("Please select a row");

            }
        }



        //Connect z4  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void connectZ4(String state , String zo, object sender, EventArgs e)
        {
            

            if (state.Equals("0"))
            {

                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z4 set status1 = '" + 1 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();

                button7_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);
            }

            if (state.Equals("1"))
            {
                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z4 set status1 = '" + 0 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();
                button7_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);


            }


        }


        //Connect z1  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void connectZ1(String state, String zo, object sender, EventArgs e)
        {


            if (state.Equals("0"))
            {

                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z1 set status1 = '" + 1 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();

                button4_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

          
                panel3.Controls.Clear();
                panel1.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);
            }

            if (state.Equals("1"))
            {
                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z1 set status1 = '" + 0 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();

                button4_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel3.Controls.Clear();

                panel1.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);


            }


        }
        //Connect z2 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void connectZ2(String state, String zo, object sender, EventArgs e)
        {


            if (state.Equals("0"))
            {

                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z2 set status1 = '" + 1 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();

                button5_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);
            }

            if (state.Equals("1"))
            {
                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z2 set status1 = '" + 0 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();
                button5_Click(sender, e);
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";


                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);

            }


        }


        //Connect z3  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void connectZ3(String state, String zo, object sender, EventArgs e)
        {


            if (state.Equals("0"))
            {

                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z3 set status1 = '" + 1 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();

                button6_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);
            }

            if (state.Equals("1"))
            {

                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z3 set status1 = '" + 0 + "' where Nom = '" + textBox1.Text + "'  ", con1);

                cmd.ExecuteReader();
                con1.Close();
                button6_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();

                Form1_Load(sender, e);


            }


        }

        //Delete Button ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void button8_Click(object sender, EventArgs e)
        {
            if (!zone.Equals(""))
            {
                if (zone.Equals("z4"))
                {
                    MySqlConnection con = new MySqlConnection(myConnectionString);
                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand("delete FROM z4 where id = '" + id + "' ", con);

                    cmd2.ExecuteReader();
                    con.Close();
                    button7_Click(sender, e);

                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";



                    panel1.Controls.Clear();
                    panel3.Controls.Clear();
                    panel4.Controls.Clear();
                    panel5.Controls.Clear();

                    Form1_Load(sender, e);


                }

                if (zone.Equals("z1"))
                {
                    MySqlConnection con = new MySqlConnection(myConnectionString);
                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand("delete FROM z1 where id = '" + id + "' ", con);

                    cmd2.ExecuteReader();
                    con.Close();
                    button7_Click(sender, e);

                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";


                    panel1.Controls.Clear();
                    panel3.Controls.Clear();
                    panel4.Controls.Clear();
                    panel5.Controls.Clear();

                    Form1_Load(sender, e);

                }

                if (zone.Equals("z2"))
                {
                    MySqlConnection con = new MySqlConnection(myConnectionString);
                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand("delete FROM z2 where id = '" + id + "' ", con);

                    cmd2.ExecuteReader();
                    con.Close();
                    button7_Click(sender, e);

                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";


                    panel1.Controls.Clear();
                    panel3.Controls.Clear();
                    panel4.Controls.Clear();
                    panel5.Controls.Clear();

                    Form1_Load(sender, e);

                }

                if (zone.Equals("z3"))
                {
                    MySqlConnection con = new MySqlConnection(myConnectionString);
                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand("delete FROM z3 where id = '" + id + "' ", con);

                    cmd2.ExecuteReader();
                    con.Close();
                    button7_Click(sender, e);

                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";



                    panel1.Controls.Clear();
                    panel3.Controls.Clear();
                    panel4.Controls.Clear();
                    panel5.Controls.Clear();

                    Form1_Load(sender, e);

                }
            }
            else
            {
 MessageBox.Show("Nothing to delete");

            }
           

        }


        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }



        //Loadz4++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        void LoadZ4()
        {
            MySqlConnection con = new MySqlConnection(myConnectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM z4", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {


                Button button = new Button();

                button.Click += new EventHandler(btn_ClickZ4);
                button.Text = reader["Nom"].ToString();
                button.Name = reader["Nom"].ToString();
                if (reader["status1"].ToString() == "0")
                {
                    button.BackColor = Color.Red;
                }
                if (reader["status1"].ToString() == "1")
                {
                    button.BackColor = Color.Green;
                }
                button.Height = 30;
                // button.Enabled = false;
                button.Dock = DockStyle.Top;
                panel5.Controls.Add(button);
                panel5.Controls.SetChildIndex(button, 0);
            }

            con.Close();
        }
        //Eteindre Demmarer

        private void button2_Click(object sender, EventArgs e)
        {

            if (!status.Equals(""))
            {
                if (zone.Equals("z4"))
                {
                    DemmarerZ4(status1, zone, sender, e);
                }

                if (zone.Equals("z1"))
                {
                    DemmarerZ1(status1, zone, sender, e);
                }
                if (zone.Equals("z2"))
                {
                    DemmarerZ2(status1, zone, sender, e);
                }
                if (zone.Equals("z3"))
                {
                    DemmarerZ3(status1, zone, sender, e);
                }

            }

            else
            {
                MessageBox.Show("chose zone item");

            }
        }



        //Connect z4  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void DemmarerZ4(String state, String zo, object sender, EventArgs e)
        {


            if (state.Equals("0"))
            {

                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z4 set status2 = '" + 1 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();

                button7_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);
            }

            if (state.Equals("1"))
            {
                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z4 set status2 = '" + 0 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();
                button7_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);


            }


        }


        //Connect z3  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void DemmarerZ3(String state, String zo, object sender, EventArgs e)
        {


            if (state.Equals("0"))
            {

                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z3 set status2 = '" + 1 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();

                button6_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);
            }

            if (state.Equals("1"))
            {
                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z3 set status2 = '" + 0 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();
                button6_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);


            }


        }



        //Connect z2 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void DemmarerZ2(String state, String zo, object sender, EventArgs e)
        {


            if (state.Equals("0"))
            {

                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z2 set status2 = '" + 1 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();

                button5_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);
            }

            if (state.Equals("1"))
            {
                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z2 set status2 = '" + 0 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();
                button5_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);


            }


        }


        //Connect z1  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void DemmarerZ1(String state, String zo, object sender, EventArgs e)
        {


            if (state.Equals("0"))
            {

                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z1 set status2 = '" + 1 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();

                button4_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);
            }

            if (state.Equals("1"))
            {
                MySqlConnection con1 = new MySqlConnection(myConnectionString);
                con1.Open();

                MySqlCommand cmd = new MySqlCommand("update z1 set status2 = '" + 0 + "' where Nom = '" + textBox1.Text + "'  ", con1);
                cmd.ExecuteReader();
                con1.Close();
                button4_Click(sender, e);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

                panel1.Controls.Clear();
                panel3.Controls.Clear();
                panel4.Controls.Clear();
                panel5.Controls.Clear();
                Form1_Load(sender, e);


            }


        }









    }





}


