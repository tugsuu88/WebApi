using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class CBase
    {
        // CreatedProgID
        public string CreatedProgID
        {
            get { return _CreatedProgID; }
            set { _CreatedProgID = value; }
        }
        public string _CreatedProgID;
        // CreatedDate
        public string CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }
        public string _CreatedDate;

        // CreatedUserName
        public string CreatedUserName
        {
            get { return _CreatedUserName; }
            set { _CreatedUserName = value; }
        }
        public string _CreatedUserName;
        // LastUpdate
        public string LastUpdate
        {
            get { return _LastUpdate; }
            set { _LastUpdate = value; }
        }
        public string _LastUpdate;
        // LastUserName
        public string LastUserName
        {
            get { return _LastUserName; }
            set { _LastUserName = value; }
        }
        public string _LastUserName;
        // IPAddress
        public string IPAddress
        {
            get { return _IPAddress; }
            set { _IPAddress = value; }
        }
        public string _IPAddress;
        // MACAddress
        public string MACAddress
        {
            get { return _MACAddress; }
            set { _MACAddress = value; }
        }
        public string _MACAddress;
    }
}