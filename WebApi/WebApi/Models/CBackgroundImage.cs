using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("BackgroundImage")]
    public class CBackgroundImage : CBase
    {
        //ImageID
        [Key]
        public string ImageID
        {
            get { return _ImageID; }
            set { _ImageID = value; }
        }
        public string _ImageID;
        //Width
        public int Width
        {
            get { return _Width; }
            set { _Width = value; }
        }
        public int _Width;

        //Height
        public int Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        public int _Height;
        //FileSize
        public double FileSize
        {
            get { return _FileSize; }
            set { _FileSize = value; }
        }
        public double _FileSize;
        //FileType
        public string FileType
        {
            get { return _FileType; }
            set { _FileType = value; }
        }
        public string _FileType;
        //FileName
        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }
        public string _FileName;
        //Path
        public string Path
        {
            get { return _Path; }
            set { _Path = value; }
        }
        public string _Path;
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