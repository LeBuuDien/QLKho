using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_Kho.DAL;

namespace QL_Kho.BLL
{
    class DONHANG
    {
        QLKhoDataContext ql = new QLKhoDataContext();

        public List<DonHang> loadDH() => ql.DonHangs.Select(t => t).ToList();

        public bool addDH(DonHang dh)
        {
            try
            {
                ql.DonHangs.InsertOnSubmit(dh);
                ql.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
                
            }
        }

        public bool updateDH(DonHang dh)
        {
            try
            {
                DonHang x = ql.DonHangs.Where(s => s.MaVanDon == dh.MaVanDon).FirstOrDefault();
                x.TenNguoiGui = dh.TenNguoiGui;
                x.DiaChiGui = dh.DiaChiGui;
                x.DiaChiNhan = dh.DiaChiNhan;
                x.TrongLuong = dh.TrongLuong;
                x.ChieuDai = dh.ChieuDai;
                x.ChieuRong = dh.ChieuRong;
                x.ChieuCao = dh.ChieuCao;

                ql.SubmitChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool delC(string ID)
        {
            try
            {
                DonHang sach = ql.DonHangs.Where(c => c.MaVanDon == ID).FirstOrDefault();
                ql.DonHangs.DeleteOnSubmit(sach);
                ql.SubmitChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
