    namespace TeatroBack.Models;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SessionPostDto
    {
        [Key]   
        public int ObraId { get; set; }
        public int SalaId {get; set;}

        public DateTime Date{get; set;}

        //Esto se lo he puesto de momento por si acaso para en vue por si tenemos que usarlo
        public SessionPostDto() { }

    }