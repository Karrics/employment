using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void vacancies_text(object sender, TreeViewEventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Список вакансий: \r\n"  +
                "Исполнительный директор Yandex (зарплата: 300.000руб) \r\n" +
                "Разработчик Apple (зарплата: 300.000$) \r\n" +
                "Аналитик Sber (зарплата 150.000руб) \r\n" +
                "Инженер Mercedes-Benz (зарплата 100.000$)";
        }

        private void entity_text(object sender, TreeViewEventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Оставленные заявления: \r\n" +
                "Иван Иванович - слесарь \r\n" +
                "Пётр Петрович - машинист \r\n" +
                "Семён Семёнович - официант \r\n" +
                "Людмила Прокофьевна - маркетолог \r\n" +
                "Ольга Петровна - продавец-консультант \r\n" +
                "Лидия Михайловна - учитель младших классов \r\n";
        }

        private void about_text(object sender, TreeViewEventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "Мы команда 'НРБ' предоставляем нашим клиентам в пару кликов найти для себя работу " +
                "мечты с удобным графиком и приятной зарплатой!" +
                "Мы уеним каждого своего клиента и работаем со множеством крупных компаний" +
                "Мы рады каждому за оказанное доверие!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            vacancies.Visible = false;
            entity.Visible = false;
            county.Visible = false;
            button1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entity.Visible = true;
            county.Visible = true;
            vacancies.Visible = true;
            button1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Save File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.Write(textBox1.Text);
                }

                MessageBox.Show("Файл успешно сохранен и отправлен", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            richTextBox1.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "Оставьте свою рюземе:";
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
