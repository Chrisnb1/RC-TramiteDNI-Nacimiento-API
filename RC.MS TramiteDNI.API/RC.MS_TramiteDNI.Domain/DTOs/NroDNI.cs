using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace RC.MS_TramiteDNI.Domain.DTOs
{
    //public class NroDNI
    //{
    //    private static int _nro;
    //    private string ruta = "NroDNI.json"; 
    //    public NroDNI(int nro) {
    //        _nro = nro;
    //    }

    //    public  int incrementar(int nro)
    //    {
    //        int incrementado = Interlocked.Increment(ref nro);
    //        Guardar(incrementado);

    //        return incrementado;

    //    }

    //    public void Guardar(int i)
    //    {

    //        string Nro = JsonConvert.SerializeObject(i);
    //        File.WriteAllText(ruta, Nro);
    //    }


    //    public  int Mostrar()
    //    {
    //        string archivo = File.ReadAllText(ruta);
    //        _nro = JsonConvert.DeserializeObject<int>(archivo);
    //        _nro = incrementar(_nro);

    //        return _nro;
    //    }

    //}

    public class NroDNI
    {
        public List<int> valores = new List<int>();
        private string ruta = "NroDNI.json";
        public NroDNI() {}

        public void Insertar(int nuevo)
        {
            
            valores.Add(nuevo);
            Guardar();
        }
        public void Guardar()
        {
            string Nro = JsonConvert.SerializeObject(valores);
            File.WriteAllText(ruta, Nro);
        }
        public int Incrementar(int nro)
        {
            int incrementado = Interlocked.Increment(ref nro);
            

            return incrementado;

        }
        public List<int> Cargar()
        {
            try
            {
                string archivo = File.ReadAllText(ruta);
                valores = JsonConvert.DeserializeObject<List<int>>(archivo);
                return valores;
            }
            catch (Exception) { return null; }
        }

        public int MostrarDNIN()
        {
            valores = Cargar();
            valores[0] = Incrementar(valores[0]);
            Actualizar(0, valores[0]);
            Guardar();
            return valores[0];
        }

        public int MostrarDNIE()
        {
            valores = Cargar();
            valores[1] = Incrementar(valores[1]);
            Actualizar(1, valores[1]);
            Guardar();
            return valores[1];
        }

        public void Actualizar(int i, int nuevo)
        {
            valores[i] = nuevo;
        }

    }
}
