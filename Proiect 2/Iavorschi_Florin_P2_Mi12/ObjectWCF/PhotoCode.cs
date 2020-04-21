using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laborator7;

namespace ObjectWCF
{
    public class PhotoCode : InterfacePhoto
    {
        API PhotoAPI = new API();
        int InterfacePhoto.PhotoExist(string caleGUI)
        {
            return PhotoAPI.PhotoExist(caleGUI);
        }
        
        void InterfacePhoto.AddPhoto(string caleGUI, DateTime dataCrearii, string eveniment, string loc, string persoane)
        {
            PhotoAPI.AddPhoto(caleGUI, dataCrearii, eveniment,  loc, persoane);
        }
        string InterfacePhoto.GetNume(string caleGUI)
        {
            return PhotoAPI.GetNume(caleGUI);
        }
        string InterfacePhoto.GetEveniment(string caleGUI)
        {
            return PhotoAPI.GetEveniment(caleGUI);
        }
        string InterfacePhoto.GetLoc(string caleGUI)
        {
            return PhotoAPI.GetLoc(caleGUI);
        }
        DateTime InterfacePhoto.GetDataCrearii(string caleGUI)
        {
            return PhotoAPI.GetDataCrearii(caleGUI);
        }
        List<String> InterfacePhoto.GetNames()
        {
            return PhotoAPI.GetNames();
        }
        string InterfacePhoto.GetPersoane(string caleGUI)
        {
            return PhotoAPI.GetPersoane(caleGUI);
        }
        List<string> InterfacePhoto.GetEvenimentList(string cautare)
        {
            return PhotoAPI.GetEvenimentList(cautare);
        }
        List<string> InterfacePhoto.GetLocList(string cautare)
        {
            return PhotoAPI.GetLocList(cautare);
        }
        List<string> InterfacePhoto.GetPersoanaList(string cautare)
        {
            return PhotoAPI.GetPersoanaList(cautare);
        }
        List<string> InterfacePhoto.GetDataCreariiList(string cautare)
        {
            return PhotoAPI.GetDataCreariiList(cautare);
        }
        void InterfacePhoto.DeletePhoto(string caleGUI)
        {
            PhotoAPI.DeletePhoto(caleGUI);
        }
        void InterfacePhoto.SchimbareCale(string caleGUI, string caleNouaGUI)
        {
            PhotoAPI.SchimbareCale(caleGUI, caleNouaGUI);
        }
    }
}
