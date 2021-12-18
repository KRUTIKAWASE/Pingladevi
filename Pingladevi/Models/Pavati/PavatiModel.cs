using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pingladevi.Data;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Pingladevi.Models
{
    public class PavatiModel
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public string Name { get; set; }
        public string Mobileno { get; set; }
        public string PaymentInWord { get; set; }
        public string PaymentInNo { get; set; }

        public string SavePavati(PavatiModel model)
        {
            string msg = "";
            PingladeviEntities1 Db = new PingladeviEntities1();
            {
                var savePavati = new Tbl_Pavati()
                {
                    Id = model.Id,
                    Date = model.Date,
                    Name = model.Name,
                    Mobileno = model.Mobileno,
                    PaymentInWord = model.PaymentInWord,
                    PaymentInNo = model.PaymentInNo,
                };
                Db.Tbl_Pavati.Add(savePavati);
                Db.SaveChanges();
                msg = savePavati.Id.ToString();
                return msg;

            }
        }

        //public List<PavatiModel> GetPavatiList()
        //{
        //    PingladeviEntities1 Db = new PingladeviEntities1();
        //    List<PavatiModel> lstPavati = new List<PavatiModel>();
        //    var AddPavatiList = Db.Tbl_Pavati.ToList();
        //    if (AddPavatiList != null)
        //    {
        //        foreach (var Pavati in AddPavatiList)
        //        {
        //            lstPavati.Add(new PavatiModel()
        //            {
        //                Id = Pavati.Id,
        //                Date = Pavati.Date,
        //                Name = Pavati.Name,
        //                Mobileno = Pavati.Mobileno,
        //                PaymentInWord = Pavati.PaymentInWord,
        //                PaymentInNo = Pavati.PaymentInNo,
        //            });
        //        }
        //    }
        //    return lstPavati;
        //}

        public PavatiModel DetailData(int Id)
        {
            string msg = "";
            PavatiModel model = new PavatiModel();
            PingladeviEntities1 Db = new PingladeviEntities1();
            var editData = Db.Tbl_Pavati.Where(p => p.Id == Id).FirstOrDefault();
            if (editData != null)
            {
                model.Id = editData.Id;
                model.Date = editData.Date;
                model.Name = editData.Name;
                model.Mobileno = editData.Mobileno;
                model.PaymentInWord = editData.PaymentInWord;
                model.PaymentInNo = editData.PaymentInNo;
            }
            msg = "";
            return model;
        }
    }
}
