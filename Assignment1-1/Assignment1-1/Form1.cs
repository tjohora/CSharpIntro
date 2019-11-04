using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //list_patientDetails.Items.Add("Name\t\t| Mon\t| Tue\t| Wed\t| Thur\t| Fri\t| Average\t| Comment");
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            double[] days = new double[5];
            days[0] = Double.Parse(txt_mon.Text);
            days[1] = Double.Parse(txt_tue.Text);
            days[2] = Double.Parse(txt_wed.Text);
            days[3] = Double.Parse(txt_thur.Text);
            days[4] = Double.Parse(txt_fri.Text);

            Patient p = new Patient(txt_name.Text,days);
            list_patientDetails.Items.Add(p.ToString());

            //MessageBox.Show("Test");
        }

        private void list_patientDetails_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            list_patientDetails.Items.Add("Name\t\t| Mon\t| Tue\t| Wed\t| Thur\t| Fri\t| Average\t| Comment");
        }

        private void list_lottoView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_generateNumbers_Click(object sender, EventArgs e)
        {
            list_lottoView.Items.Clear();

            int noOfLines = int.Parse(txt_noOfLines.Text);
            double linePrice = 3.00;
            int noOfLinesFilled = 0;
            ArrayList lottoLine = new ArrayList();
            Random rand = new Random();

            do
            {
                int lineFilled = 0;
                do
                {
                    int randNum = rand.Next(1, 50);
                    if (!lottoLine.Contains(rand))
                    {
                        lottoLine.Add(randNum);
                        lineFilled++;
                    }
                } while (lineFilled != 6);
                lottoLine.Sort();

                String displayLine = lottoLine[0].ToString();
                for (int i = 1; i < lottoLine.Count; i++)
                {
                    displayLine += ", " + lottoLine[i].ToString();
                }
                list_lottoView.Items.Add(displayLine);
                lottoLine.Clear();
                noOfLinesFilled++;
            } while (noOfLinesFilled != noOfLines);
            double totalPrice = noOfLines * linePrice;
            list_lottoView.Items.Add("Price: €" + totalPrice.ToString());
        }

        private void txt_noOfLines_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        Random rand = new Random();
        private void btn_createEmployee_Click(object sender, EventArgs e)
        {
            
            if (txt_empName.Text == "")
            {
                hseEmployee employee1 = new hseEmployee();
                printDetails(employee1);
            }
            else
            {
                hseEmployee employee2 = new hseEmployee(txt_empName.Text, txt_empType.Text, int.Parse(txt_empYrsOfService.Text), Double.Parse(txt_empSalary.Text));
                printDetails(employee2);
            }
            Doctor MyDoctor = new Doctor("Mario", "Doctor", 2, 110000);
            printDetails(MyDoctor);
        }

        private void list_empList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_generateEmployees_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                String[] nameArray = { "Carl", "Jenny", "Sean", "Smith", "Mary" };
                String randName = nameArray[rand.Next(0, 5)];
                String[] jobArray = { "Standard", "Porter", "Doctor" };
                String randJob = jobArray[rand.Next(0, 3)];
                int randYrsOfService = rand.Next(1, 10);
                double randSalary = rand.Next(30000, 150000);
                if (String.Equals(randJob, "Doctor"))
                {
                    Doctor ADoctor = new Doctor(randName, randJob, randYrsOfService, randSalary);
                    printDetails(ADoctor);
                }
                else
                {
                    hseEmployee AnEmployee = new hseEmployee(randName, randJob, randYrsOfService, randSalary);
                    printDetails(AnEmployee);
                }

            }

        }
        void printDetails(hseEmployee emp)
        {
            list_empList.Items.Add(emp.EmpName);
            list_empDetails.Items.Add("Emp Name: " + emp.EmpName);
            list_empDetails.Items.Add("Emp Number: " + emp.EmpNumber);
            list_empDetails.Items.Add("Emp Type: " + emp.EmpType);
            list_empDetails.Items.Add("Emp Yrs Service: " + emp.EmpYrsService);
            list_empDetails.Items.Add("Emp Salary: €" + emp.EmpSalary);

            if (emp is Doctor)
            {
                list_empDetails.Items.Add("I can prescribe medicine!");
            }
            list_empDetails.Items.Add("\n");
        }
    }
}
