using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Models
{
    [Table("Content")]
    public class CContent : CBase
    {
        //ContentID
        [Key]
        public string ContentID
        {
            get { return _ContentID; }
            set { _ContentID = value; }
        }
        public string _ContentID;
        //Descr
        public string Descr
        {
            get { return _Descr; }
            set { _Descr = value; }
        }
        public string _Descr;
        //RegDate
        public string RegDate
        {
            get { return _RegDate; }
            set { _RegDate = value; }
        }
        public string _RegDate;
        //ActBegDate
        public string ActBegDate
        {
            get { return _ActBegDate; }
            set { _ActBegDate = value; }
        }
        public string _ActBegDate;
        //ActEndDate
        public string ActEndDate
        {
            get { return _ActEndDate; }
            set { _ActEndDate = value; }
        }
        public string _ActEndDate;
        //CpnyID
        public string CpnyID
        {
            get { return _CpnyID; }
            set { _CpnyID = value; }
        }
        public string _CpnyID;
        //TerminalIDs
        public string TerminalIDs
        {
            get { return _TerminalIDs; }
            set { _TerminalIDs = value; }
        }
        public string _TerminalIDs;

        // BackgroundImages
        public List<CBackgroundImage> BackGroundImages
        {
            get { return _backGroundImages; }
            set { _backGroundImages = value; }
        }
        private List<CBackgroundImage> _backGroundImages;

        // Videos
        public List<CVideo> Videos
        {
            get { return _Videos; }
            set { _Videos = value; }
        }
        private List<CVideo> _Videos;

        // Informations
        public ICollection<CInformation> Informations
        {
            get { return _Informations; }
            set { _Informations = value; }
        }
        private ICollection<CInformation> _Informations;
    }
}