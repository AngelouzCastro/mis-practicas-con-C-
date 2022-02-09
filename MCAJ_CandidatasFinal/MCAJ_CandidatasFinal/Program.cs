using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_CandidatasFinal
{
    class Program
    {
        Interfaz mInterfaz;
        Candidatas mCandidatas;
        Cand1 mCand1;
        Cand2 mCand2;
        Cand3 mCand3;

        public Program()
        {
            mCand1 = new Cand1();
            mCand2 = new Cand2();
            mCand3 = new Cand3();
            mInterfaz = new Interfaz();
           
            mCandidatas = new Candidatas();
        }

        public void Correr()
        {
            int Opcion;
            int Opcion2;
            

            do
            {
                mInterfaz.ImprimirMenu();
                Opcion = mInterfaz.GetOpcion();

                switch (Opcion)
                {
                    case 1:
                        mInterfaz.PedirNombre();
                        mCand1.SetNombre(mInterfaz.GetNombre());
                        mInterfaz.PedirCarrera();
                        mCand1.SetCarrera(mInterfaz.GetCarrera());
                        mInterfaz.PedirTalento();
                        mCand1.SetTalento(mInterfaz.GetTalento());

                        mInterfaz.PedirNombre();
                        mCand2.SetNombre(mInterfaz.GetNombre());
                        mInterfaz.PedirCarrera();
                        mCand2.SetCarrera(mInterfaz.GetCarrera());
                        mInterfaz.PedirTalento();
                        mCand2.SetTalento(mInterfaz.GetTalento());

                        mInterfaz.PedirNombre();
                        mCand3.SetNombre(mInterfaz.GetNombre());
                        mInterfaz.PedirCarrera();
                        mCand3.SetCarrera(mInterfaz.GetCarrera());
                        mInterfaz.PedirTalento();
                        mCand3.SetTalento(mInterfaz.GetTalento());
                        break;

                    case 2:

                        do
                        {
                            mInterfaz.ImprimirMenu2();
                            Opcion2 = mInterfaz.GetOpcion2();

                            switch (Opcion2)
                            {
                                case 1:
                                    mInterfaz.PedirVotos();
                                    mCand1.SetVotos(mInterfaz.GetVotos());
                                    mCand1.CalcularTotalVotos();
                                    break;

                                case 2:
                                    mInterfaz.PedirVotos();
                                    mCand2.SetVotos(mInterfaz.GetVotos());
                                    mCand2.CalcularTotalVotos();
                                    break;

                                case 3:
                                    mInterfaz.PedirVotos();
                                    mCand3.SetVotos(mInterfaz.GetVotos());
                                    mCand3.CalcularTotalVotos();
                                    break;

                            }


                        } while (Opcion2 != 4);

                        break;


                    case 3:



                        mInterfaz.ImprimirResultados(mCand1, mCand2, mCand3);
                        break;




                }
            } while (Opcion != 4);

        }
        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
