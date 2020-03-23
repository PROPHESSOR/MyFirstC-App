using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ПервыйБлинКомом
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            cmb_curVer.Items.AddRange(versions);
            cmb_nextVer.Items.AddRange(versions);
        }

        private string[] versions = { "1.0", "2.0", "3.0", "4.0", "5.0" };

        private bool validateVersion(string version) {
            foreach (string ver in versions) {
                if (version == ver) return true;
            }

            return false;
        }

        private int getVersionNumber(string version) {
            for (int i = 0; i < versions.Length; i++) {
                if (versions[i] == version) return i + 1;
            }

            throw new Exception("Разработчик забыл провалидировать версию!");
        }

        private void btn_ver1_Click(object sender, EventArgs e) {
            cmb_curVer.Text = "1.0";
        }

        private void btn_ver3_Click(object sender, EventArgs e) {
            cmb_curVer.Text = "3.0";
        }

        private void btn_ver5_Click(object sender, EventArgs e) {
            cmb_curVer.Text = "5.0";
        }

        private void btn_update_Click(object sender, EventArgs e) {
            string cur = cmb_curVer.Text;
            string next = cmb_nextVer.Text;

            if (!validateVersion(cur)) {
                MessageBox.Show("Неверная текущая версия!");
                return;
            }

            if (!validateVersion(next)) {
                MessageBox.Show("Неверная желаемая версия!");
                return;
            }

            if (cur == next) {
                MessageBox.Show("И в очередной раз я встречаю человека, который просто не желает развиваться :/");
                return;
            }

            int curNu = getVersionNumber(cur);
            int nextNu = getVersionNumber(next);

            if (curNu > nextNu) {
                MessageBox.Show("В наше время люди всё чаще выбирают путь деградации... Очень жаль, что Вы не исключение...");
                return;
            }

            if (nextNu - curNu > 1) {
                MessageBox.Show("Люди недоверчевые создания... Ясно же было сказано, что человеческий мозг не способен осилить обновление более чем на одну версию за раз... Вы ведь понимаете, что, если бы не эта строка кода, Вы валялись бы сейчас с инсультом?!");
                MessageBox.Show("В любом случае, это запрещено.");
                return;
            }

            MessageBox.Show("Ожидайте в следующей версии ;)");
        }
    }
}
