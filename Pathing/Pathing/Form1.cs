﻿using System;
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

        List<Initiative> SortedList = new List<Initiative>();
        public Form1()
        {
            pathObject.Cid = 0;
            InitializeComponent();
            textBox1.Text = pathObject.Cid.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//Creates a session
        {//Stores everthing to the list and the Session object list

            //comboBox1.Items.Add(textName.Text);
            //listSessions.Items.Add(textName.Text);
            pathObject.Cid = pathObject.Cid + 1;
            pathObject.Name = textName.Text;
            pathObject.Initiative = Convert.ToInt32(textIniative.Text);
            //textBox1.Text = pathObject.Cid.ToString();
            textBox1.Text = Pathlist.Capacity.ToString();
            Pathlist.Add(making_a_sesstion(pathObject.Cid, textName.Text, textClass.Text, Convert.ToInt32(textHealth.Text), Convert.ToInt32(textAC.Text), Convert.ToInt32(textForitude.Text), Convert.ToInt32(textReflex.Text), Convert.ToInt32(textWill.Text), Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text), Convert.ToInt32(textDex.Text), Convert.ToInt32(textInt.Text), Convert.ToInt32(textWis.Text), Convert.ToInt32(textCha.Text), Convert.ToInt32(textIniative.Text), Convert.ToInt32(textHD.Text), richFeatBox.Text));
            richConsole.Text = Pathlist.Capacity.ToString();
            //textCMB.Text = (Convert.ToInt32(textBaseAttack.Text) + ((Convert.ToInt32(textStr.Text)-10)/2)).ToString();
            //textCMD.Text = (Convert.ToInt32(textBaseAttack.Text) + ((Convert.ToInt32(textStr.Text) - 10) / 2) + 10 + ((Convert.ToInt32(textDex.Text) - 10) / 2)).ToString();
            textCMB.Text = Globalz.calcCMB(Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text)).ToString();
            textCMD.Text = Globalz.calcCMD(Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text), Convert.ToInt32(textDex.Text)).ToString();

            String sessionName = pathObject.Cid.ToString() + ": Name-" + textName.Text + " AC-" + textClass.Text + " HP-" + textHealth.Text + " AC-" + textAC.Text + " F-" + textForitude.Text + " R-" + textReflex.Text + " W-" + textWill.Text + " Base-" + textBaseAttack.Text + " Str-" + textStr.Text + " Dex-" + textDex.Text + " Con-" + textCon.Text + " Int-" + textInt.Text + " Wis-" + textWis.Text + " Cha-" + textCha.Text + " Ini-" + textIniative.Text + " HD-" + textHD.Text + " CMB-" + textCMB.Text + " CMD-" + textCMD.Text + " Feats-" + richFeatBox.Text;
            listSessions.Items.Add(sessionName);

            Rollforinit.Add(making_a_Iniative(pathObject.Cid, textName.Text, pathObject.Initiative));

        }

        private Initiative making_a_Iniative(int sID, string name, int iniative)
        {//Rcreates iniatives that can be rolled for.
            Initiative new_initiative = new Initiative();

            new_initiative.Iid = sID;
            new_initiative.iName = name;
            new_initiative.InitiativeValue = iniative;

            return new_initiative;
        }

        private Session making_a_sesstion(int cid, string name, string Class, Int32 Health, Int32 ArmorClass, Int32 Foritude, Int32 Reflex, Int32 Will, Int32 BaseAttack, Int32 Str, Int32 Dex, Int32 Int, Int32 Wis, Int32 Cha, Int32 Initiative, Int32 HD, string feats)
        {
            Session new_Session = new Session();
            new_Session.Cid = cid;
            new_Session.Name = textName.Text;

            new_Session.Class = textClass.Text;
            new_Session.Health = Convert.ToInt32(textHealth.Text);
            new_Session.ArmorClass = Convert.ToInt32(textAC.Text);
            new_Session.Foritude = Convert.ToInt32(textForitude.Text);
            new_Session.Reflex = Convert.ToInt32(textReflex.Text);
            new_Session.Will = Convert.ToInt32(textWill.Text);
            new_Session.BaseAttack = Convert.ToInt32(textBaseAttack.Text);

            new_Session.Str = Convert.ToInt32(textStr.Text);
            new_Session.Dex = Convert.ToInt32(textDex.Text);
            new_Session.Con = Convert.ToInt32(textCon.Text);

            new_Session.Int = Convert.ToInt32(textInt.Text);
            new_Session.Wis = Convert.ToInt32(textWis.Text);
            new_Session.Cha = Convert.ToInt32(textCha.Text);
            new_Session.Initiative = Convert.ToInt32(textIniative.Text);
            new_Session.HD = Convert.ToInt32(textHD.Text);
            new_Session.Feats = richFeatBox.Text;


            return new_Session;

        }

        private void listSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox1.Text = listSessions.SelectedItem.ToString();
            //textBox1.Text = listSessions.SelectedIndex.ToString();
            Session load_Session;

            if (listSessions.SelectedIndex >= 0 && listSessions.SelectedIndex <= Pathlist.Capacity)//somehow SelectedIndex could be less then 0.
            {
                load_Session = Pathlist[listSessions.SelectedIndex];
            }
            else
            {
                load_Session = Pathlist[0];
            }

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

            textCMB.Text = Globalz.calcCMB(load_Session.BaseAttack, load_Session.Str).ToString();
            textCMD.Text = Globalz.calcCMD(load_Session.BaseAttack, load_Session.Str, load_Session.Dex).ToString();



        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openSessions.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                //SetExcelSaga(result.ToString());
                using (System.IO.StreamReader file = new System.IO.StreamReader(openSessions.FileName))
                {
                    string line;
                    int counter = 0;
                    while ((line = file.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        counter++;

                        richConsole.Text = line;

                        textName.Text = file.ReadLine();
                        textClass.Text = file.ReadLine();
                        textHealth.Text = file.ReadLine();
                        textAC.Text = file.ReadLine();
                        textForitude.Text = file.ReadLine();
                        textReflex.Text = file.ReadLine();
                        textWill.Text = file.ReadLine();
                        textBaseAttack.Text = file.ReadLine();
                        textStr.Text = file.ReadLine();
                        textDex.Text = file.ReadLine();
                        textCon.Text = file.ReadLine();

                        textInt.Text = file.ReadLine();
                        textWis.Text = file.ReadLine();
                        textCha.Text = file.ReadLine();
                        textIniative.Text = file.ReadLine();
                        textHD.Text = file.ReadLine();

                        richFeatBox.Text = file.ReadLine();

                        //comboBox1.Items.Add(textName.Text);//button1_Click(sender, e);
                        pathObject.Cid = pathObject.Cid + 1;
                        pathObject.Name = textName.Text;
                        pathObject.Initiative = Convert.ToInt32(textIniative.Text);
                        textBox1.Text = pathObject.Cid.ToString();
                        Pathlist.Add(making_a_sesstion(pathObject.Cid, textName.Text, textClass.Text, Convert.ToInt32(textHealth.Text), Convert.ToInt32(textAC.Text), Convert.ToInt32(textForitude.Text), Convert.ToInt32(textReflex.Text), Convert.ToInt32(textWill.Text), Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text), Convert.ToInt32(textDex.Text), Convert.ToInt32(textInt.Text), Convert.ToInt32(textWis.Text), Convert.ToInt32(textCha.Text), Convert.ToInt32(textIniative.Text), Convert.ToInt32(textHD.Text), richFeatBox.Text));


                        textCMB.Text = Globalz.calcCMB(Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text)).ToString();
                        textCMD.Text = Globalz.calcCMD(Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text), Convert.ToInt32(textDex.Text)).ToString();

                        String sessionName = pathObject.Cid.ToString() + ": Name-" + textName.Text + " AC-" + textClass.Text + " HP-" + textHealth.Text + " AC-" + textAC.Text + " F-" + textForitude.Text + " R-" + textReflex.Text + " W-" + textWill.Text + " Base-" + textBaseAttack.Text + " Str-" + textStr.Text + " Dex-" + textDex.Text + " Con-" + textCon.Text + " Int-" + textInt.Text + " Wis-" + textWis.Text + " Cha-" + textCha.Text + " Ini-" + textIniative.Text + " HD-" + textHD.Text + " CMB-" + textCMB.Text + " CMD-" + textCMD.Text;
                        listSessions.Items.Add(sessionName);

                        Rollforinit.Add(making_a_Iniative(pathObject.Cid, textName.Text, pathObject.Initiative));

                        //line = file.ReadLine();
                        if (counter == 100)
                            break;



                    }





                    file.Close();
                }


            }
            else
            {
                Console.WriteLine(result); // <-- For debugging use.
                textBox1.Text = result.ToString();
            }

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
            if (result == DialogResult.OK)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@saveSessions.FileName, true))
                {
                    for (int saveloop = 0; saveloop < pathObject.Cid; saveloop++)
                    {
                        //Session save_Session = Pathlist[listSessions.SelectedIndex];
                        Session save_Session = Pathlist[saveloop];

                        //file.WriteLine(saveloop.ToString() + ": Name-" + textName.Text + " AC-" + textClass.Text + " HP-" + textHealth.Text + " AC-" + textAC.Text + " F-" + textForitude.Text + " R-" + textReflex.Text + " W-" + textWill.Text + " Base-" + textBaseAttack.Text + " Str-" + textStr.Text + " Dex-" + textDex.Text + " Con-" + textCon.Text + " Int-" + textInt.Text + " Wis-" + textWis.Text + " Cha-" + textCha.Text + " Ini-" + textIniative.Text + " HD-" + textHD.Text + " CMB-" + textCMB.Text + " CMD-" + textCMD.Text);
                        file.WriteLine(saveloop.ToString() + ": Name-" + save_Session.Name + "Class-" + save_Session.Class + " HP-" + save_Session.Health + " AC-" + save_Session.ArmorClass + " F-" + save_Session.Foritude + " R-" + save_Session.Reflex + " W-" + save_Session.Will + " Base-" + save_Session.BaseAttack + " Str-" + save_Session.Str + " Dex-" + save_Session.Dex + " Con-" + save_Session.Con + " Int-" + save_Session.Int + " Wis-" + save_Session.Wis + " Cha-" + save_Session.Cha + " Ini-" + save_Session.Initiative + " HD-" + save_Session.HD + " CMB-" + Globalz.calcCMB(save_Session.BaseAttack, save_Session.Str) + " CMD-" + Globalz.calcCMD(save_Session.BaseAttack, save_Session.Str, save_Session.Dex));
                        file.WriteLine(save_Session.Name);
                        file.WriteLine(save_Session.Class);
                        file.WriteLine(save_Session.Health);
                        file.WriteLine(save_Session.ArmorClass);
                        file.WriteLine(save_Session.Foritude);
                        file.WriteLine(save_Session.Reflex);
                        file.WriteLine(save_Session.Will);
                        file.WriteLine(save_Session.BaseAttack);
                        file.WriteLine(save_Session.Str);
                        file.WriteLine(save_Session.Dex);
                        file.WriteLine(save_Session.Con);
                        file.WriteLine(save_Session.Int);
                        file.WriteLine(save_Session.Wis);
                        file.WriteLine(save_Session.Cha);
                        file.WriteLine(save_Session.Initiative);
                        file.WriteLine(save_Session.HD);
                        file.WriteLine(save_Session.Feats);
                    }
                    file.Close();
                }
            }
            else
            {
                textBox1.Text = "file not found";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 21);
            string RanNumText = randomNumber.ToString();
            richConsole.Text += " " +RanNumText;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox3.Text = Globalz.GiveMe5().ToString();
            richConsole.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Rollforinit.Sort
            //List<Initiative> SortedList = Rollforinit;
           
            //SortedList.AddRange(Rollforinit);

            //SortedList.

            SortedList = Rollforinit;

            int[] originalInitiatives;//used to keep the original values
            originalInitiatives = new int[SortedList.Count];
           
            Random random = new Random();
            for (int y = 0; y < SortedList.Count; y++)
            {
                SortedList[y].Iid = y + 1;


                int randomNumber = random.Next(1, 21);
                string RanNumText = randomNumber.ToString();

                originalInitiatives[y] = SortedList[y].InitiativeValue;
                SortedList[y].InitiativeValue += randomNumber;//without the originalInitiatives, this would continue to increase.
            }
            HeapSort(SortedList);

            for (int i = 0; i < SortedList.Count; i++)
            {
                listBox1.Items.Add(SortedList[i].Iid.ToString() + " -" + SortedList[i].iName + "- " + SortedList[i].InitiativeValue.ToString());
                SortedList[i].InitiativeValue = originalInitiatives[i];//sets back the original Initiatives.
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

        private void D12button_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 21);
            string RanNumText = randomNumber.ToString();
            richConsole.Text += " " +RanNumText;
        }

        private void D10button_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 13);
            string RanNumText = randomNumber.ToString();
            richConsole.Text += " " +RanNumText;
        }

        private void D8button_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 9);
            string RanNumText = randomNumber.ToString();
            richConsole.Text += " " +RanNumText;
        }

        private void D6button_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string RanNumText = randomNumber.ToString();
            richConsole.Text += " " +RanNumText;
        }

        private void D4button_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 5);
            string RanNumText = randomNumber.ToString();
            richConsole.Text += " " +RanNumText;
        }

        private void D3button_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            string RanNumText = randomNumber.ToString();
            richConsole.Text += " " +RanNumText;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            //listSessions.SelectedIndex
            //listBox1<listBox1.SelectedIndex>
            //listSessions.SelectedIndex
            listBox1.Items.Add(((listBox1.Items.Count + 1) + " -" + textInitName.Text + "- " + textInitNum.Text));

        }

        private void upbutton_Click(object sender, EventArgs e)
        {
            MoveItem(-1);

        }

        private void downbutton_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        private void Rembutton_Click(object sender, EventArgs e)
        {
            // Checking selected item
            if (listBox1.SelectedItem == null || listBox1.SelectedIndex < 0)
                return; // No selected item - nothing to do
            else
            {
                object selected = listBox1.SelectedItem;
                listBox1.Items.Remove(selected);
            }
        }

        public void MoveItem(int direction)
        {
            // Checking selected item
            if (listBox1.SelectedItem == null || listBox1.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBox1.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox1.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBox1.SelectedItem;

            // Removing removable element
            listBox1.Items.Remove(selected);
            // Insert it in new position
            listBox1.Items.Insert(newIndex, selected);
            // Restore selection
            listBox1.SetSelected(newIndex, true);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            SortedList = new List<Initiative>();
            SortedList.Clear();
            listBox1.Items.Clear();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

            Session edit_Session = new Session();

            edit_Session = making_a_sesstion(pathObject.Cid, textName.Text, textClass.Text, Convert.ToInt32(textHealth.Text), Convert.ToInt32(textAC.Text), Convert.ToInt32(textForitude.Text), Convert.ToInt32(textReflex.Text), Convert.ToInt32(textWill.Text), Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text), Convert.ToInt32(textDex.Text), Convert.ToInt32(textInt.Text), Convert.ToInt32(textWis.Text), Convert.ToInt32(textCha.Text), Convert.ToInt32(textIniative.Text), Convert.ToInt32(textHD.Text), richFeatBox.Text);
            richConsole.Text = Pathlist.Capacity.ToString();

            if (listSessions.SelectedIndex >= 0 && listSessions.SelectedIndex <= Pathlist.Capacity)
            {
                int indextChanging = listSessions.SelectedIndex;
                Pathlist[listSessions.SelectedIndex] = making_a_sesstion(pathObject.Cid, textName.Text, textClass.Text, Convert.ToInt32(textHealth.Text), Convert.ToInt32(textAC.Text), Convert.ToInt32(textForitude.Text), Convert.ToInt32(textReflex.Text), Convert.ToInt32(textWill.Text), Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text), Convert.ToInt32(textDex.Text), Convert.ToInt32(textInt.Text), Convert.ToInt32(textWis.Text), Convert.ToInt32(textCha.Text), Convert.ToInt32(textIniative.Text), Convert.ToInt32(textHD.Text), richFeatBox.Text);
                //listSessions[indextChanging] = (pathObject.Cid, textName.Text, textClass.Text, Convert.ToInt32(textHealth.Text), Convert.ToInt32(textAC.Text), Convert.ToInt32(textForitude.Text), Convert.ToInt32(textReflex.Text), Convert.ToInt32(textWill.Text), Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text), Convert.ToInt32(textDex.Text), Convert.ToInt32(textInt.Text), Convert.ToInt32(textWis.Text), Convert.ToInt32(textCha.Text), Convert.ToInt32(textIniative.Text), Convert.ToInt32(textHD.Text), richFeatBox.Text);
                //listSessions.Items.
                //listSessions.SelectedValue = "lololol";
                //textBox1.Text = listSessions.SelectedItem.ToString();
                //List boxes are not easily edited. I could simply just make a clone of the listbox with the element I wanted edited already edited, and then place that as the new list box, but I am sure there is an easier way.
            }
            else
            {
                MessageBox.Show("You dun goofed");
            }

            textCMB.Text = Globalz.calcCMB(Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text)).ToString();
            textCMD.Text = Globalz.calcCMD(Convert.ToInt32(textBaseAttack.Text), Convert.ToInt32(textStr.Text), Convert.ToInt32(textDex.Text)).ToString();

            String sessionName = pathObject.Cid.ToString() + ": Name-" + textName.Text + " AC-" + textClass.Text + " HP-" + textHealth.Text + " AC-" + textAC.Text + " F-" + textForitude.Text + " R-" + textReflex.Text + " W-" + textWill.Text + " Base-" + textBaseAttack.Text + " Str-" + textStr.Text + " Dex-" + textDex.Text + " Con-" + textCon.Text + " Int-" + textInt.Text + " Wis-" + textWis.Text + " Cha-" + textCha.Text + " Ini-" + textIniative.Text + " HD-" + textHD.Text + " CMB-" + textCMB.Text + " CMD-" + textCMD.Text + " Feats-" + richFeatBox.Text;
            //listSessions.Items.Add(sessionName);
            //listSessions.Items(1) = "whata";
            //ListBox temp = new ListBox();
            //temp.Items.Add(sessionName);

            //temp.Items.Add()

            

            Rollforinit.Add(making_a_Iniative(pathObject.Cid, textName.Text, pathObject.Initiative));

        }



    }
}
