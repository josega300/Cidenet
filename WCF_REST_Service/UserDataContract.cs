using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_REST_Service
{
    public class UserDataContract
    {
        [DataMember]
        public string UserID { get; set; }

        /********************/
        [DataMember]
        public string PrimerApellido { get; set; }

        [DataMember]
        public string SegundoApellido { get; set; }

        [DataMember]
        public string PrimerNombre { get; set; }

        [DataMember]
        public string OtrosNombres { get; set; }

        [DataMember]
        public string PaisEmpleo { get; set; }

        [DataMember]
        public string TipoIdentificacion { get; set; }

        [DataMember]
        public string NumeroIdentificacion { get; set; }

        [DataMember]
        public string CorreoElectronico { get; set; }

        [DataMember]
        public string FechaIngreso { get; set; }

        [DataMember]
        public string Area { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public DateTime FechaHoraRegistro { get; set; }

        [DataMember]
        public DateTime FechaHoraActualizado { get; set; }

    }
}