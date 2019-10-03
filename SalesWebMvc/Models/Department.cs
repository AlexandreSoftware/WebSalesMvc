using System.Collections.Generic;
using System.Linq;
using System;

namespace SalesWebMvc.Models{
    public class Department {
        public int id { get; private set; }
        public string name { get; private set; }
        public ICollection<Seller> sellers { get; private set; } = new List<Seller>();

        public Department()
        {

        }
        public Department(int id, string name) {
            this.id = id;
            this.name = name;
        }
   
        public void addSeller(Seller seller) {
            if (seller == null) {
                throw new ArgumentNullException("argumento nulo");
            }
            else if (seller.department != null) {
                throw new ArgumentException("Vendedor já pertence a um departamento, use o metodo de mover");
            }
            else {
                sellers.Add(seller);
            }

        }
        public void moveSeller(Seller seller, Department dep) {
            if (dep == null || seller == null) {
                throw new ArgumentNullException("argumento nulo");
            }
            else if (seller.department != null && dep == seller.department) {
                throw new ArgumentException("Vendedor ja esta nesse Departamento");
            }
            else if (seller.department != null && seller.department== this) {
                sellers.Remove(seller);
                seller.removedepartment();
                dep.addSeller(seller);
            }
            else if (seller.department == null) {
                throw new ArgumentException("Vendedor nao tem um departamento, adicione ele a um departamento");
            }
            else if (seller.department != null && seller.department != this) {
                throw new ArgumentException("Vendedor esta em outro departamento");
            }
        }
        public void removeSeller(Seller seller) {
            if (seller.department != null && seller.department == this) {
                sellers.Remove(seller);
                seller.removedepartment();
            }
            else {
                throw new ArgumentException("Vendedor nao esta nesse departamento");
            }
        }
        public double totalSales(DateTime initial, DateTime final)
        {
            return sellers.ToList().Sum((x) => x.totalSales(initial, final));
        }
    }
}
