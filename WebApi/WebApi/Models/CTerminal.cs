using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    [Table("Terminal")]
    public class CTerminal : CBase
    {
        // TerminalID
        [Key]
        public string TerminalID
        {
            get { return _TerminalID; }
            set { _TerminalID = value; }
        }
        public string _TerminalID;
        // TerminalID
        
        public string CpnyID
        {
            get { return _CpnyID; }
            set { _CpnyID = value; }
        }
        public string _CpnyID;
        //TIpAddress
        
        public string TIpAddress
        {
            get { return _TIpAddress; }
            set { _TIpAddress = value; }
        }
        public string _TIpAddress;
    }
}