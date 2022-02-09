using SpreadsheetLight;
using System;
using System.Collections.Generic;

namespace prueba_dossier
{
    class Program
    {
        public List<string> Listadocentes = new List<string>();
        
        
        static void Main(string[] args)
        {
            Program mProgram = new Program();
            string[] hojas = { "ISC", "TICS", "IA", "IGE", "IEM", "CP", "IIA","CP_S1","CPS_2","IA_S1","IA_S2","EaD_IA_S1","EaD_IA_S2","EaD_CP_S1","EaD_CP_S2","EaD_ISC_S1","EaD_ISC_S2" };
            for (int i = 0; i < hojas.Length; i++)
            {
                mProgram.llenarLista(hojas[i]);
                
            }

            

        }
        public void llenarLista(string hoja)
        {
            string path = @"C:\Users\darka\Downloads\Carga_Acad_v1.0.xlsx";
            SLDocument libro = new SLDocument(path);
            //libro.SelectWorksheet("ISC");//hoja


            int fila = 2;
            int columna = 1;
            //while(!string.IsNullOrEmpty(libro.GetCellValueAsString(fila,columna)))
            while (true)
            {
                string nombredocente = libro.GetCellValueAsString(1, 2);


                if (!string.IsNullOrEmpty(libro.GetCellValueAsString(fila, columna)))
                {
                    Listadocentes.Add(libro.GetCellValueAsString(fila, columna));
                }
                fila++;


                if (libro.GetCellValueAsString(fila, columna) == "" &&
                    libro.GetCellValueAsString(fila + 1, columna) == "" &&
                    libro.GetCellValueAsString(fila - 1, columna) == "")
                {
                    break;
                }


            }
            foreach (string docentes in Listadocentes)
            {
                Console.WriteLine(docentes);
            }   
        }

        
    }
}
