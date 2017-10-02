using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassesDAO;

namespace WCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Collaborateurs GetCollaborateurs(int numColab);

        [OperationContract]
        Collaborateurs AjoutCollaborateur(Collaborateurs leColab);

        [OperationContract]
        IList<Collaborateurs> GetAllCollaborateurs(bool Archive);

        [OperationContract]
        string AddCollaborateur(Collaborateurs unCollaborateur);

        [OperationContract]
        string UpdateCollaborateur(Collaborateurs unCollaborateur);

        [OperationContract]
        bool DeleteCollaborateur(Collaborateurs unCollaborateur);
    }


   
}
