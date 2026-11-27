using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Cliente> Clientes=new List<Cliente>();
            int opc = 0;
            int opc1 = 0;
            string nom, apP, apM, mot;
            DateTime fec;
            int idcita=0;
            int idbusqueda = 0;
            do
            {
                
                Console.WriteLine("");
                Console.WriteLine("+++++++++++MENU+++++++++++");
                Console.WriteLine("1.Ingresar cita");
                Console.WriteLine("2.Buscar cita");
                Console.WriteLine("3.Eliminar cita");
                Console.WriteLine("4.Modificar cita");
                Console.WriteLine("5.Salir");
                Console.WriteLine("Elija su opcion a realizar");
                opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        {
                            idcita++;
                            Console.WriteLine("INGRESAR USUARIO");
                            Console.WriteLine("Nombre del Paciente: ");
                            nom = Console.ReadLine();
                            Console.WriteLine("Apellido Paterno del Paciente: ");
                            apP = Console.ReadLine();
                            Console.WriteLine("Apellido Materno del Paciente: ");
                            apM = Console.ReadLine();
                            Console.WriteLine("Motivo de cita: ");
                            mot = Console.ReadLine();
                            Console.WriteLine("Ingrese la Fecha de la cita con este format*(Año/Mes/Día)*: ");
                            fec = Convert.ToDateTime(Console.ReadLine());

                            Cliente nuevocliente = new Cliente(idcita,nom, apP, apM, mot, fec);
                            Clientes.Add(nuevocliente);
                            Console.WriteLine("CITA CREADA CON EXITO ID: "+idcita);
                            Console.ReadKey();

                        }
                        break;

                    case 2:
                        {
                            do
                            {
                                Console.WriteLine("BUSCAR CITA");
                                Console.WriteLine("1.Busqueda por Id ");
                                Console.WriteLine("2.Busqueda por Datos del paciente");
                                Console.WriteLine("3.Salir");
                                Console.WriteLine("Ingrese la opcion de busqueda elegida: ");
                                opc1 = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                switch (opc1)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("BUSQUEDA POR ID");
                                            Console.WriteLine("Ingrese Id de cita: ");
                                            idbusqueda=Convert.ToInt32(Console.ReadLine());
                                            foreach(Cliente n in Clientes)
                                            {
                                                if (n.i == idbusqueda)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Nombre: " + n.Nom);
                                                    Console.WriteLine("Apellido Paterno: " + n.ApeP);
                                                    Console.WriteLine("Apellido Materno: " + n.ApeM);
                                                    Console.WriteLine("Motivo: " + n.Moti);
                                                    Console.WriteLine("Fecha: " + n.Fecha);
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                            

                                        }
                                        break;
                                    case 2:
                                        {

                                            Console.WriteLine("BUSQUEDA POR DATOS");
                                            Console.WriteLine("Nombre del Paciente: ");
                                            nom = Console.ReadLine();
                                            Console.WriteLine("Apellido Paterno del Paciente: ");
                                            apP = Console.ReadLine();
                                            Console.WriteLine("Apellido Materno del Paciente: ");
                                            apM = Console.ReadLine();
                                            
                                            foreach (Cliente n in Clientes)
                                            {
                                                if (n.Nom==nom&&n.ApeP==apP&&n.ApeM==apM)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Nombre: " + n.Nom);
                                                    Console.WriteLine("Apellido Paterno: " + n.ApeP);
                                                    Console.WriteLine("Apellido Materno: " + n.ApeM);
                                                    Console.WriteLine("Motivo: " + n.Moti);
                                                    Console.WriteLine("Fecha: " + n.Fecha);
                                                    Console.ReadKey();
                                                    break;
                                                }
                                            }
                                        }
                                        break;
                                    case 3:
                                        {

                                        }
                                        break;
                                    default:
                                        {
                                            Console.WriteLine("Ingrese una opcion valida de busqueda");
                                            Console.ReadKey();
                                        }
                                        break;
                                }
                                Console.Clear();
                            } while (opc1 != 3);

                        }
                        break;

                    case 3:
                        {
                            do
                            {
                                Console.WriteLine("ELIMINAR CITA");
                                Console.WriteLine("1.Eliminar por Id ");
                                Console.WriteLine("2.Eliminar por Datos del paciente");
                                Console.WriteLine("3.Salir");
                                Console.WriteLine("Ingrese la opcion elegida: ");
                                opc1 = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                switch (opc1)
                                {
                                    case 1:
                                        {
                                            Cliente eliminar=null;
                                            Console.WriteLine("ELIMINAR POR ID");
                                            Console.WriteLine("Ingrese Id de cita: ");
                                            idbusqueda = Convert.ToInt32(Console.ReadLine());
                                            foreach (Cliente n in Clientes)
                                            {
                                                if (n.i == idbusqueda)
                                                {
                                                    string eleccion;
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Nombre: " + n.Nom);
                                                    Console.WriteLine("Apellido Paterno: " + n.ApeP);
                                                    Console.WriteLine("Apellido Materno: " + n.ApeM);
                                                    Console.WriteLine("Motivo: " + n.Moti);
                                                    Console.WriteLine("Fecha: " + n.Fecha);
                                                    Console.WriteLine("Esta seguro de eliminar esta cita?(Y/N) ");
                                                    eleccion=Console.ReadLine();
                                                    if (eleccion == "y" || eleccion == "Y")
                                                    {
                                                        eliminar = n;
                                                    }
                                                    break;
                                                }
                                                
                                            }
                                            if (eliminar != null)
                                            {
                                                Clientes.Remove(eliminar);
                                            }


                                        }
                                        break;
                                    case 2:
                                        {
                                            Cliente eliminar = null;
                                            Console.WriteLine("ElIMINAR POR DATOS");
                                            Console.WriteLine("Nombre del Paciente: ");
                                            nom = Console.ReadLine();
                                            Console.WriteLine("Apellido Paterno del Paciente: ");
                                            apP = Console.ReadLine();
                                            Console.WriteLine("Apellido Materno del Paciente: ");
                                            apM = Console.ReadLine();

                                            foreach (Cliente n in Clientes)
                                            {
                                                if (n.Nom == nom && n.ApeP == apP && n.ApeM == apM)
                                                {
                                                    string eleccion = null;
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Nombre: " + n.Nom);
                                                    Console.WriteLine("Apellido Paterno: " + n.ApeP);
                                                    Console.WriteLine("Apellido Materno: " + n.ApeM);
                                                    Console.WriteLine("Motivo: " + n.Moti);
                                                    Console.WriteLine("Fecha: " + n.Fecha);
                                                    Console.WriteLine("Esta seguro de eliminar esta cita?(Y/N) ");
                                                    eleccion = Console.ReadLine();

                                                    if (eleccion == "y" || eleccion == "Y")
                                                    {
                                                        eliminar = n;
                                                        break;
                                                    }
                                                }
                                                

                                            }
                                            

                                            if (eliminar != null)
                                            {
                                                Clientes.Remove(eliminar);
                                            }
                                        }
                                        break;
                                    case 3:
                                        {

                                        }
                                        break;
                                    default:
                                        {
                                            Console.WriteLine("Ingrese una opcion valida de busqueda");
                                        }
                                        break;
                                }
                                Console.Clear();
                            } while (opc1 != 3);
                        }
                        break;

                    case 4:
                        {
                            do
                            {
                                Console.WriteLine("MODIFICAR CITA");
                                Console.WriteLine("1.Modificar por Id ");
                                Console.WriteLine("2.Modificar por Datos del paciente");
                                Console.WriteLine("3.Salir");
                                Console.WriteLine("Ingrese la opcion elegida: ");
                                opc1 = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                switch (opc1)
                                {
                                    case 1:
                                        {
                                            
                                            Console.WriteLine("MODIFICAR POR ID");
                                            Console.WriteLine("Ingrese Id de cita: ");
                                            idbusqueda = Convert.ToInt32(Console.ReadLine());
                                            foreach (Cliente n in Clientes)
                                            {
                                                if (n.i == idbusqueda)
                                                {
                                                    string eleccion;
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Nombre: " + n.Nom);
                                                    Console.WriteLine("Apellido Paterno: " + n.ApeP);
                                                    Console.WriteLine("Apellido Materno: " + n.ApeM);
                                                    Console.WriteLine("Motivo: " + n.Moti);
                                                    Console.WriteLine("Fecha: " + n.Fecha);
                                                    Console.WriteLine("Esta seguro de Modificar esta cita?(Y/N) ");
                                                    eleccion = Console.ReadLine();
                                                    if (eleccion == "y" || eleccion == "Y")
                                                    {
                                                        Console.WriteLine("Ingresa la nueva fecha:");
                                                        fec=Convert.ToDateTime(Console.ReadLine());
                                                        n.Fecha = fec;
                                                        Console.WriteLine("Ingresa el nuevo motivo de la cita: ");
                                                        mot=Console.ReadLine();
                                                        n.Moti = mot;
                                                    }
                                                    break;
                                                }
                                                
                                            }
                                            


                                        }
                                        break;
                                    case 2:
                                        {

                                            Console.WriteLine("MODIFICAR POR DATOS");
                                            Console.WriteLine("Nombre del Paciente: ");
                                            nom = Console.ReadLine();
                                            Console.WriteLine("Apellido Paterno del Paciente: ");
                                            apP = Console.ReadLine();
                                            Console.WriteLine("Apellido Materno del Paciente: ");
                                            apM = Console.ReadLine();

                                            foreach (Cliente n in Clientes)
                                            {
                                                if (n.Nom == nom && n.ApeP == apP && n.ApeM == apM)
                                                {
                                                    string eleccion;
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Nombre: " + n.Nom);
                                                    Console.WriteLine("Apellido Paterno: " + n.ApeP);
                                                    Console.WriteLine("Apellido Materno: " + n.ApeM);
                                                    Console.WriteLine("Motivo: " + n.Moti);
                                                    Console.WriteLine("Fecha: " + n.Fecha);
                                                    Console.WriteLine("Esta seguro de Modificar esta cita?(Y/N) ");
                                                    eleccion = Console.ReadLine();
                                                    if (eleccion == "y" || eleccion == "Y")
                                                    {
                                                        Console.WriteLine("Ingresa la nueva fecha:");
                                                        fec = Convert.ToDateTime(Console.ReadLine());
                                                        n.Fecha = fec;
                                                        Console.WriteLine("Ingresa el nuevo motivo de la cita: ");
                                                        mot = Console.ReadLine();
                                                        n.Moti = mot;
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                        break;
                                    case 3:
                                        {

                                        }
                                        break;
                                    default:
                                        {
                                            Console.WriteLine("Ingrese una opcion valida de busqueda");
                                        }
                                        break;
                                }
                                Console.Clear();
                            } while (opc1 != 3);
                        }
                        break;
                    case 5:
                        {

                        }break;
                    default:
                        {
                            Console.WriteLine("Elija una opcion valida");
                        }
                        break;
                }
                Console.Clear();
            } while (opc != 5);
            
        }
    }
}
