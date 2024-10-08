using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Listas.Modelos;


namespace Listas
{
    public partial class Form1 : Form
    {
        List<cPersonas> lista = new List<cPersonas>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cPersonas p = new cPersonas();
            try
            {
                p.pNombre = txtNombres.Text.Trim();
                p.pFechaNac = dtpFechaNac.Value;
                p.pSexo = cmbSexo.Text;
                p.pNivelAcademico = cmbNivelAca.Text;
                if (p.Edad() > 18)
                {
                    lista.Add(p);
                }
                groupBox3.Text = "Registros Agregados: " + lista.Count;
                dgvRegistros.DataSource = lista.ToArray();
                
            }
            catch(Exception ex) { }
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion = dgvRegistros.CurrentRow.Index;
                lista.RemoveAt(posicion);
                dgvRegistros.DataSource = lista.ToArray();   
            }
            catch (Exception ex) { }
        }

    }
}
