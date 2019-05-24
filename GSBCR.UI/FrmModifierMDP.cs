using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmModifierMDP : Form
    {
        private VISITEUR v;
        public FrmModifierMDP(VISITEUR v)
        {
            InitializeComponent();
            this.v = v;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            
            string mdpA = txt_mdp_actuel.Text;
            string mdpN = txt_mdp_new.Text;
            string mdpCN = txt_mdp_c_new.Text;
            if (mdpA != "" && mdpN != "" && mdpCN != "")
            {
                if (mdpA == v.vis_mdp)
                {
                    if (mdpA != mdpN && mdpN == mdpCN)
                    {
                        if (mdpN.Length >= 6 && mdpN.Length <= 8)
                        {
                            if (mdpN.Any(char.IsNumber))
                            {
                                if (mdpN.Any(char.IsUpper) && mdpN.Any(char.IsLower))
                                {
                                    v.vis_mdp = txt_mdp_new.Text;
                                    Manager.MajMotDePasse(v);
                                    MessageBox.Show("Le mot de passe a été modifié");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Le mot de passe n'a pas au minimum une majuscule et une miniscule");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Le mot de passe ne possède pas de chiffre");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Le mot de passe au moins 6 caractères et ne peut pas contenir plus de 8 caractères");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le mot de passe actuel est égal au nouveau mot de passe ou les nouveaux mots de passes ne corespondent pas");
                    }
                }
                else
                {
                    MessageBox.Show("Le mot de passe entré est différent du mot de passe actuel");
                }
            }
            else
            {
                MessageBox.Show("Les mots de passes ne sont pas remplis");
            }
        }
    }
}
