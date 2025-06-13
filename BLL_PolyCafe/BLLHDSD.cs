using DAL_PolyCafe;
using DTO_PolyCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_PolyCafe
{
    public class BLLHDSD
    {
        private DALHDSD dal = new DALHDSD();
        public HDSD LayHuongDan()
        {
            return dal.LayHuongDan();
        }
    }
}
