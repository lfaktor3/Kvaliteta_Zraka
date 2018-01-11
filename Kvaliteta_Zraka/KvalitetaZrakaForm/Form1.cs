using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KvalitetaZrakaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dotNetDataSet1.AirQuality_pollutants' table. You can move, or remove it, as needed.
            this.airQuality_pollutantsTableAdapter.Fill(this.dotNetDataSet1.AirQuality_pollutants);
            // TODO: This line of code loads data into the 'dotNetDataSet.AirQuality_measurement_stations' table. You can move, or remove it, as needed.
            this.airQuality_measurement_stationsTableAdapter.Fill(this.dotNetDataSet.AirQuality_measurement_stations);

        }

        private void CalendarStart_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void generate_Click(object sender, EventArgs e)
        {
            var link = ("http://iszz.azo.hr/iskzl/rs/podatak/export/json?postaja=*IDpostaje*&polutant=*IDpolutanta*&tipPodatka=0&vrijemeOd=" + dateTimePicker1.Text + "vrijemeDo=" + dateTimePicker2.Text);
            MessageBox.Show(link);
            Clipboard.Clear();
            Clipboard.SetText(link);
        }
    }
}