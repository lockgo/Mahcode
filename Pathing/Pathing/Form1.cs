using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Pathing
{
    public partial class Form1 : Form
    {
        Session pathObject = new Session();
        Initiative initiativeObject = new Initiative();

        List<Session> Pathlist = new List<Session>();
        List<Initiative> Rollforinit = new List<Initiative>();
        public Form1()
        {
            pathObject.Cid = 0;
            InitializeComponent();
            textBox1.Text = pathObject.Cid.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//Creates a session
        {//Stores everthing to the list and the Session object list

            comboBox1.Items.Add(textName.Text);
            //listSessions.Items.Add(textName.Text);
            pathObject.Cid = pathObject.Cid + 1;
            pathObject.Name = textName.Text;
            pathObject.Initiative = Convert.ToInt32(textIniative.Text);
            textBox1.Text = pathObject.Cid.ToString();
            Pathlist.Add(making_a_sesstion(pathObject.Cid, textName.Text, textClass.Text, Convert.ToInt32(textHealth.Text), Convert.ToInt32(textAC.Text), Convert.ToInt32(textForitude.Text), Convert.ToInt32(textReflex.Text), Convert.ToInt32(textWill.Text), Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text), Convert.ToInt32(textDex.Text), Convert.ToInt32(textInt.Text), Convert.ToInt32(textWis.Text), Convert.ToInt32(textCha.Text), Convert.ToInt32(textIniative.Text), Convert.ToInt32(textHD.Text)));
            //textCMB.Text = (Convert.ToInt32(textBaseAttack.Text) + ((Convert.ToInt32(textStr.Text)-10)/2)).ToString();
            //textCMD.Text = (Convert.ToInt32(textBaseAttack.Text) + ((Convert.ToInt32(textStr.Text) - 10) / 2) + 10 + ((Convert.ToInt32(textDex.Text) - 10) / 2)).ToString();
            textCMB.Text = calcCMB(Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text)).ToString();
            textCMD.Text = calcCMD(Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text), Convert.ToInt32(textDex.Text)).ToString();

            String sessionName = pathObject.Cid.ToString() + ": Name-" + textName.Text + " AC-" + textClass.Text + " HP-" + textHealth.Text + " AC-" + textAC.Text + " F-" + textForitude.Text + " R-" + textReflex.Text + " W-" + textWill.Text + " Base-" + textBaseAttack.Text + " Str-" + textStr.Text + " Dex-" + textDex.Text + " Con-" + textCon.Text + " Int-" + textInt.Text + " Wis-" + textWis.Text + " Cha-" + textCha.Text + " Ini-" + textIniative.Text + " HD-" + textHD.Text + " CMB-" + textCMB.Text + " CMD-" + textCMD.Text;
            listSessions.Items.Add(sessionName);

            Rollforinit.Add(making_a_Iniative(pathObject.Cid, textName.Text, pathObject.Initiative));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }

        private Initiative making_a_Iniative(int sID, string name, int iniative)
        {
            Initiative new_initiative = new Initiative();

            new_initiative.Iid = sID;
            new_initiative.iName = name;
            new_initiative.InitiativeValue = iniative;

            return new_initiative;
        }

        private Session making_a_sesstion(int cid, string name, string Class, Int32 Health, Int32 ArmorClass, Int32 Foritude, Int32 Reflex, Int32 Will, Int32 BaseAttack, Int32 Str, Int32 Dex, Int32 Int, Int32 Wis, Int32 Cha, Int32 Initiative, Int32 HD)
        {
            Session new_Session = new Session();
            new_Session.Cid = cid;
            new_Session.Name = textName.Text;

            new_Session.Class       =textClass.Text;
            new_Session.Health      =Convert.ToInt32(textHealth.Text);
            new_Session.ArmorClass  =Convert.ToInt32(textAC.Text);
            new_Session.Foritude    =Convert.ToInt32(textForitude.Text);
            new_Session.Reflex      =Convert.ToInt32(textReflex.Text);
            new_Session.Will        =Convert.ToInt32(textWill.Text);
            new_Session.BaseAttack  =Convert.ToInt32(textBaseAttack.Text);

            new_Session.Str         =Convert.ToInt32(textStr.Text);
            new_Session.Dex         =Convert.ToInt32(textDex.Text);
            new_Session.Con         =Convert.ToInt32(textCon.Text);

            new_Session.Int         =Convert.ToInt32(textInt.Text);
            new_Session.Wis         =Convert.ToInt32(textWis.Text);
            new_Session.Cha         =Convert.ToInt32(textCha.Text);
            new_Session.Initiative = Convert.ToInt32(textIniative.Text);
            new_Session.HD          =Convert.ToInt32(textHD.Text);


            return new_Session;

        }

        private void listSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox1.Text = listSessions.SelectedItem.ToString();
            //textBox1.Text = listSessions.SelectedIndex.ToString();

            Session load_Session = Pathlist[listSessions.SelectedIndex];
            textBox1.Text = load_Session.Cid.ToString();

            textName.Text = load_Session.Name; 
            textClass.Text = load_Session.Class;
            textHealth.Text = load_Session.Health.ToString();
            textAC.Text = load_Session.ArmorClass.ToString();
            textForitude.Text = load_Session.Foritude.ToString();
            textReflex.Text = load_Session.Reflex.ToString();
            textWill.Text = load_Session.Will.ToString();
            textBaseAttack.Text = load_Session.BaseAttack.ToString();
            textStr.Text = load_Session.Str.ToString();
            textDex.Text = load_Session.Dex.ToString();
            textCon.Text = load_Session.Con.ToString();

            textInt.Text = load_Session.Int.ToString();
            textWis.Text = load_Session.Wis.ToString();
            textCha.Text = load_Session.Cha.ToString();
            textIniative.Text = load_Session.Initiative.ToString();
            textHD.Text = load_Session.HD.ToString();

            textCMB.Text = calcCMB(load_Session.BaseAttack, load_Session.Str).ToString();
            textCMD.Text = calcCMD(load_Session.BaseAttack, load_Session.Str, load_Session.Dex).ToString();



        }

        private int calcCMB(int BaseAttack, int Str)
        {//Combat Manuver Bonus
            int CMB = 0;
            if (Str < 10)
            {
                CMB = BaseAttack + ((Str / 2) * -1);
            }
            else
            {
                CMB = BaseAttack + ((Str - 10) / 2);
            }
            return CMB;
        }

        private int calcCMD(int BaseAttack, int Str, int Dex)
        {//Combat Manuver Defense
            int CMD;
            if (Str < 10 && Dex < 10)
            {
                CMD = BaseAttack + ((Str / 2) * -1) + 10 + ((Dex / 2) * -1);
            }
            else if(Str >= 10 && Dex < 10)
            {
                CMD = BaseAttack + ((Str - 10) / 2) + 10 + ((Dex / 2) * -1);
            }
            else if(Str < 10 && Dex >= 10)
            {
                CMD = BaseAttack + ((Str / 2) * -1) + 10 + ((Dex - 10) / 2);
            }
            else
            {
                CMD = (BaseAttack + ((Str - 10) / 2) + 10 + ((Dex - 10) / 2));
            }

            return CMD;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openSessions.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                //SetExcelSaga(result.ToString());
            }
            Console.WriteLine(result); // <-- For debugging use.
            textBox1.Text = result.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveSessions.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                //SetExcelSaga(result.ToString());
            }
            Console.WriteLine(result); // <-- For debugging use.
            textBox1.Text = saveSessions.FileName;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@saveSessions.FileName, true))
            {
                Session save_Session = Pathlist[listSessions.SelectedIndex];

                file.WriteLine(pathObject.Cid.ToString() + ": Name-" + textName.Text + " AC-" + textClass.Text + " HP-" + textHealth.Text + " AC-" + textAC.Text + " F-" + textForitude.Text + " R-" + textReflex.Text + " W-" + textWill.Text + " Base-" + textBaseAttack.Text + " Str-" + textStr.Text + " Dex-" + textDex.Text + " Con-" + textCon.Text + " Int-" + textInt.Text + " Wis-" + textWis.Text + " Cha-" + textCha.Text + " Ini-" + textIniative.Text + " HD-" + textHD.Text + " CMB-" + textCMB.Text + " CMD-" + textCMD.Text);
                file.WriteLine(" " + save_Session.Name);
                file.WriteLine(" " + save_Session.Class);
                file.WriteLine(" " + save_Session.Health);
                file.WriteLine(" " + save_Session.ArmorClass);
                file.WriteLine(" " + save_Session.Foritude);
                file.WriteLine(" " + save_Session.Reflex);
                file.WriteLine(" " + save_Session.Will);
                file.WriteLine(" " + save_Session.BaseAttack);
                file.WriteLine(" " + save_Session.Str);
                file.WriteLine(" " + save_Session.Dex);
                file.WriteLine(" " + save_Session.Con);
                file.WriteLine(" " + save_Session.Int);
                file.WriteLine(" " + save_Session.Wis);
                file.WriteLine(" " + save_Session.Cha);
                file.WriteLine(" " + save_Session.Initiative);
                file.WriteLine(" " + save_Session.HD);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 21);
            string RanNumText = randomNumber.ToString();
            textBox2.Text = RanNumText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            textBox3.Text = Globalz.GiveMe5().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Rollforinit.Sort
            //List<Initiative> SortedList = Rollforinit;
            List<Initiative> SortedList = new List<Initiative>();
            //SortedList.AddRange(Rollforinit);

            //SortedList.

            SortedList = Rollforinit;

            HeapSort(SortedList);

            for (int i = 0; i < SortedList.Count; i++)
            {
                listBox1.Items.Add(SortedList[i].Iid.ToString() + " -" + SortedList[i].iName + "- " + SortedList[i].InitiativeValue.ToString());
            }

            
        }

        public static void HeapSort(List<Initiative> input)
        {
            //Build-Max-Heap
            int heapSize = input.Count;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                MaxHeapify(input, heapSize, p);

            for (int i = input.Count - 1; i > 0; i--)
            {
                //Swap
                Initiative temp = new Initiative();
                //temp.Equals(input[i]);
                temp = clone(input[i]);
                

                //input[i].Equals(input[0]);
                //input[0].Equals(temp);

                input[i] = clone(input[0]);
                input[0] = clone(temp);

                heapSize--;
                MaxHeapify(input, heapSize, 0);
            }
        }

        private static void MaxHeapify(List<Initiative> input, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && input[left].InitiativeValue > input[index].InitiativeValue)
                largest = left;
            else
                largest = index;

            if (right < heapSize && input[right].InitiativeValue > input[largest].InitiativeValue)
                largest = right;

            if (largest != index)
            {
                Initiative temp = new Initiative();
                //temp.Equals(input[index]);
                temp = clone(input[index]);

                //input[index].Equals(input[largest]);
                //input[largest].Equals(temp);

                input[index] = clone(input[largest]);
                input[largest] = clone(temp);

                MaxHeapify(input, heapSize, largest);
            }
        }

        private static Initiative clone(Initiative beingCopied)
        {
            Initiative clone = new Initiative();

            int tempIid = beingCopied.Iid;
            string tempString = beingCopied.iName;
            int tempIniative = beingCopied.InitiativeValue;

            clone.Iid = tempIid;
            clone.iName = tempString;
            clone.InitiativeValue = tempIniative;

            

            return clone;
        }



    }
}
