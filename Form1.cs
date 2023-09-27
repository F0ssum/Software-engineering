using MyUnits;
using System.Windows.Forms;
using System.Drawing;

namespace WAAGH
{
    public partial class Form1 : Form
    {
        private ComboBox comboBox1;
        private Button button2;

        
        private List<Unit> units = new List<Unit>();

        public Form1()
        {
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();

            button1.Text = "Create Unit";
            button1.Click += new EventHandler(button1_Click);

            button2.Text = "View Units";
            button2.Click += new EventHandler(button2_Click);

            comboBox1.Items.AddRange(new string[] { "Infantry", "Vehicle" });
            comboBox1.SelectedIndex = 0;

            label1.Text = "Select unit type:";

            label1.Location = new Point(30, 30);
            comboBox1.Location = new Point(30, 60);
            button1.Location = new Point(30, 90);
            button2.Location = new Point(30, 120);

            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(button2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string unitType = comboBox1.SelectedItem.ToString();

           
            Unit newUnit = Creation.CreateUnit(100, 10, 5, 50, 100, null, null, unitType);

            
            units.Add(newUnit);

            MessageBox.Show($"Created a {unitType} unit!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Units:\n";

            foreach (var unit in units)
            {
                message += $"Health: {unit.Health}, Damage: {unit.Damage}, Speed: {unit.Speed}, Firing Range: {unit.FiringRange}, Detection Range: {unit.DetectionRange}, Main Weapon: {unit.MainWeapon}, Secondary Weapon: {unit.SecondaryWeapon}\n";
            
            }

            MessageBox.Show(message);
        }
    }
}
