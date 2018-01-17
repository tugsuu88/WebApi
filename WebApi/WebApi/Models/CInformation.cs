using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("Information")]
    public class CInformation : CBase
    {
        //InformationID
        [Key]
        public string InformationID
        {
            get { return _InformationID; }
            set { _InformationID = value; }
        }
        public string _InformationID;
        //Descr
        public string Descr
        {
            get { return _Descr; }
            set { _Descr = value; }
        }
        public string _Descr;
        //ContentID
        [ForeignKey("Content")]
        public string ContentID
        {
            get { return _ContentID; }
            set { _ContentID = value; }
        }
        public string _ContentID;

        public virtual CContent Content
        {
            get { return _Content; }
            set { _Content = value; }
        }
        public CContent _Content;
    }
}