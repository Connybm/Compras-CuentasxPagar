﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDisenoCompras.Mantenimientos
{
    public partial class Mant_Sucursal : Form
    {
        string usuario = "";
        public Mant_Sucursal(string usr)
        {
            InitializeComponent();
            //Parametros del Navegador
            usuario = usr;
            string[] alias = { "Cod", "Sucursal", "Direccion", "estado" };
            Nav_Mant_Bodega.asignarAlias(alias);
            Nav_Mant_Bodega.asignarAyuda("1");
            Nav_Mant_Bodega.asignarSalida(this);
            Nav_Mant_Bodega.asignarColorFondo(Color.White);
            Nav_Mant_Bodega.asignarColorFuente(Color.Black);
            Nav_Mant_Bodega.asignarTabla("Tbl_sucursal");
            Nav_Mant_Bodega.asignarNombreForm("SUCURSAL");
            Nav_Mant_Bodega.ObtenerIdAplicacion("1");
        }

        private void Nav_Mant_Bodega_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            Nav_Mant_Bodega.ObtenerIdUsuario(usuario);
            Nav_Mant_Bodega.botonesYPermisosInicial(usuario, aplicacionActiva);
            Nav_Mant_Bodega.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}