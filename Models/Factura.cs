using System;
using System.ComponentModel.DataAnnotations;
namespace Sem_4_Programita_1x2.Models{
    public class Factura{
        public int id{get;set;}
        public String cliente{get;set;}
        public String producto{get;set;}
        public int cantidad{get;set;}
        [DataType(DataType.Date)]
        public DateTime fecha{get;set;}
        public int invoice{get;set;}
        public Double total{get;set;}
        public Double subtotal{get;set;}
        public Double precio{get;set;}
    }
}