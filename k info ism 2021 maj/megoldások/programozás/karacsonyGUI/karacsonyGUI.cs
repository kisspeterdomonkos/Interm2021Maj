/*9. feladat: Készítsen grafikus alkalmazást, amelynek projektjét karacsonyGUI néven mentse el!
    A grafikus alkalmazást a hölgy arra szeretné használni, hogy a későbbiek során ne fájlba
    kelljen írnia az adatokat, hanem helyette egy könnyen kezelhető grafikus felületen tudja
    megadni a napi zárás adatait. A grafikus felületet csak az angyalkák számának kezeléséhez
    kell elkészítenie. Az alkalmazásban megadhatja, hogy melyik napon hány angyalka készült
    el és mennyit sikerült eladni. Ezek alapján az alkalmazásnak a készleten lévő angyalkák
    számát is kell számolnia, és meg kell jelenítenie.*/
namespace karacsonyGUI
{
    public partial class karacsonyGUI : Form
    {
        private int stock = 0;
        public karacsonyGUI()
        {
            InitializeComponent();
            for (int i = 1; i <= 40; i++)
            {
                dayComboBox.Items.Add(i); 
            }
            labelError.Visible = false;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int prepd = int.Parse(preparedTextBox.Text);
            int sld = int.Parse(soldTextBox.Text);

            if (prepd < 0 || sld < 0)
            {
                labelError.Visible = true;
                labelError.Text = "Negatív számot nem adhat meg!";
            }
            if (stock + prepd < sld)
            {
                labelError.Visible = true;
                labelError.Text = "Túl sok az eladott angyalka!";
            }
            stock += prepd;
            stock -= sld;

            string text = string.Format($"{dayComboBox.SelectedItem.ToString()}.nap\t+{preparedTextBox.Text}\t-{soldTextBox.Text}\t=\t{stock}");
            infoListBox.Items.Add(text);
            preparedTextBox.Text = "0";
            soldTextBox.Text = "0";
            dayComboBox.SelectedIndex = -1;
        }
    }
}