using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laborator7;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfacePhoto
    {
        [OperationContract]
        int PhotoExist(string caleGUI);
        [OperationContract]
        void AddPhoto(string caleGUI, DateTime dataCrearii, string eveniment, string loc, string persoane);
        [OperationContract]
        string GetNume(string caleGUI);
        [OperationContract]
        string GetEveniment(string caleGUI);
        [OperationContract]
        string GetLoc(string caleGUI);
        [OperationContract]
        DateTime GetDataCrearii(string caleGUI);
        [OperationContract]
        List<String> GetNames();
        [OperationContract]
        string GetPersoane(string caleGUI);
        [OperationContract]
        List<string> GetEvenimentList(string cautare);
        [OperationContract]
        List<string> GetLocList(string cautare);
        [OperationContract]
        List<string> GetPersoanaList(string cautare);
        [OperationContract]
        List<string> GetDataCreariiList(string cautare);
        [OperationContract]
        void DeletePhoto(string caleGUI);
        [OperationContract]
        void SchimbareCale(string caleGUI, string caleNouaGUI);
    }
}
