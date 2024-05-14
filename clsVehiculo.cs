﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace pryPachecoEtapa6
{
    class clsVehiculo
    {
        public PictureBox pctVehiculo;
        public string tipoVehiculo;

        public void CrearVehiculo(int aleatorio) //Requiere un numero para ser llamado, dependiendo el numero será distinto el vehiculo.
        {
            pctVehiculo = new PictureBox();
            switch (aleatorio)
            {
                case 1:
                    string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "auto.png");
                    pctVehiculo.ImageLocation = ruta;
                    pctVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
                    pctVehiculo.Size = new Size(75, 100);
                    pctVehiculo.BackColor = Color.Transparent;
                    tipoVehiculo = "Auto";

                    break;
                case 2:
                    string ruta2 = Path.Combine(Application.StartupPath, "..", "..", "Resources", "avion.png");
                    pctVehiculo.ImageLocation = ruta2;
                    pctVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
                    pctVehiculo.Size = new Size(100, 100);
                    pctVehiculo.BackColor = Color.Transparent;
                    tipoVehiculo = "Avion";
                    break;
                case 3:
                    string ruta3 = Path.Combine(Application.StartupPath, "..", "..", "Resources", "barco.png");
                    pctVehiculo.ImageLocation = ruta3;
                    pctVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
                    pctVehiculo.Size = new Size(100, 100);
                    pctVehiculo.BackColor = Color.Transparent;
                    tipoVehiculo = "Barco";
                    break;
            }
        }



    }
}
