using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class ResponeRepository
    {
        private static ResponeRepository objRespon = new ResponeRepository();
        private List<GuesRespone> arrGues = new List<GuesRespone>();

        public static ResponeRepository GetRespon()
        {
            return objRespon;
        }

        public IEnumerable<GuesRespone> GetAllRespone()
        {
            return arrGues;
        }

        public void addRespone(GuesRespone respone)
        {
            arrGues.Add(respone);
        }
    }
}