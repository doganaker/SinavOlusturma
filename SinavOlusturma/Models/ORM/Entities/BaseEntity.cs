using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.Models.ORM.Entities
{
    public class BaseEntity
    {
        public int ID { get; set; }

        private DateTime _date = DateTime.Now;
        public DateTime Date 
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        private bool _isDeleted = false;
        public bool IsDeleted 
        {
            get
            {
                return _isDeleted;
            }
            set
            {
                _isDeleted = value;
            }
        }
    }
}
