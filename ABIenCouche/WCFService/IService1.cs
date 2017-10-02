using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassesDAO;
using ABIenCouche;

namespace WCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate="Collaborateurs/{numColab}")]
        Collaborateur GetCollaborateur(string numColab);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Collaborateurs/", RequestFormat =WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Collaborateur AjoutCollaborateur(Collaborateurs leColab);

        [OperationContract]
        IList<Collaborateur> GetAllCollaborateurs(bool Archive);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Collaborateurs/", RequestFormat =WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string AddCollaborateur(Collaborateurs unCollaborateur);

        [OperationContract]
        [WebInvoke(Method ="PUT",UriTemplate ="Collaborateurs/")]
        string UpdateCollaborateur(Collaborateur unCollaborateur);

        [OperationContract]
        [WebInvoke(Method ="DELETE",UriTemplate ="Collaborateurs/{unMatricule}")]
        string DeleteCollaborateur(int unMatricule);

        [OperationContract]
        Contrat GetContrat(Collaborateur unCollaborateur,int unNum);

        [OperationContract]
        IList<Contrat> getAllContrats();
    }


   
}
