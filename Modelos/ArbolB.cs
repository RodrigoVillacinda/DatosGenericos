using system;

//muestra la firmas de los metodos
namespace ArbolB : Icomparable
{
    public class ArbolB
    {
    

        public int Year { get; set; }
        public string Name { get; set }
        public Person Director { get; set; }
        public Person[] Actors { get; set; }


        public int CompareTo(object obj)
        {
            //throw new NotImplementedException();
            return this.Name.CompareTo( ((ArbolB)obj).Name);
        }

        public static Comparison<ArbolB> ComperByName = delagate(Movie m1, Movie m2)
        {
            return this.m1.CompareTo(m2);
        }



        public static Comparison<ArbolB> ComperByYear = delagate(Movie m1, Movie m2)
        {
            int returnValue = 0;

            return m1.Year < m2.Year
            ? -1
            : m1.Year > m2.Year
            ? 1
            : 0;


        }
        public Comparison<ArbolB> ComperByDirector = delagate(Movie m1, Movie m2)
        {
            return m1.Director.CompareTo(m2.Director)
        }

    }
    
}

//api: get, post, get id
// modelo de bebidas
// arbol b: insertar, buscar, recorrer inorden
// retornar el arbol como lista
//