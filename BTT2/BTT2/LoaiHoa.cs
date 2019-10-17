using System;
using System.Collections.Generic;
using System.Text;

namespace BTT2
{
    public class LoaiHoa:List<hoa>
    {
        public string TenLoai { get; set; }
        private LoaiHoa(string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<LoaiHoa> ListLoaiHoa { get; set; }

        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
            {
                new LoaiHoa("Loai 1"){
                    new hoa { TenHoa = "Hoa Hồng", Gia = 50000, Hinh = "HoaHong.png", MoTa = "Hoa hồng đỏ, vàng, trắng" },
                    new hoa { TenHoa = "Hoa Hướng Dương", Gia = 70000, Hinh = "HoaHuongDuong.png", MoTa = "Hoa mặt trời." },
                    new hoa { TenHoa = "Hoa Tu Líp", Gia = 100000, Hinh = "HoaTulip.png", MoTa = "Hoa Tu Líp Tím, Vàng." },
                },
                new LoaiHoa("Loai 2")
                {
                    new hoa { TenHoa = "Hoa Anh Đào", Gia =60000, Hinh = "HoaAnhDao.png", MoTa = "Hoa anh đào Nhật" },
                    new hoa { TenHoa = "Hoa Lam", Gia = 40000, Hinh = "HoaLan.png", MoTa = "Hoa lan rừng." },
                    new hoa { TenHoa = "Hoa Lay ơn", Gia = 100000, Hinh = "HoaLayon.png", MoTa = "Hoa Lay ơn vàng, trắng." },
                }

            };
            ListLoaiHoa = l;
        }
    }
    
}
