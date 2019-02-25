using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace General_Lib
{
    public static class MsgBox
    {
        public static void Atencao(string texto)
        {
            System.Windows.Forms.MessageBox.Show(texto, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Sucesso(string texto)
        {
            System.Windows.Forms.MessageBox.Show(texto, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Erro(string texto)
        {
            System.Windows.Forms.MessageBox.Show(texto, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Pergunta(string texto)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show(texto, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }
    }
}
