// 
//Creamos nuestra class catalogo revista
class RevistaCatalogo{
    //Agregamos nuestros nombres de los catalogos
    static List <string> catalogo=new List<string>{
        "Catalogo1", "Catalogo2","Catalogo3","Catalogo4", 
        "Catalogo5","Catalogo6","Catalogo7","Catalogo8", 
        "Catalogo9","Catalogo10"     };


//Creamos nuestro metodo principal que muestre los menus
static void Main () 
{ 
    while(true)
    {
        Console.Clear();
        Console.WriteLine("################### Universidad Estatal Amazonica ################### \n");

        Console.WriteLine("################### Agnatura: Estructura de Datos ################### \n");

        Console.WriteLine(" ################### Programado por: Fernanda Gutierres  ###################\n");

        Console.WriteLine(" ################### Universidad Estatal Amazonica ################### \n");

        Console.WriteLine(" ################### Catalogo de Revista  ############# \n");

        Console.WriteLine("1.Busqueda de Titulo Recursiva:  \n");
        Console.WriteLine("2.Busqueda de Titulo Interactiva: \n");

        Console.WriteLine("3.Mostrar todos los titulos : \n");
        Console.WriteLine("4.Salir \n");
         Console.Write("Seleccione una opción:  ");

        //Crer una variable de tipo string

        string opcion = Console.ReadLine();

        if(opcion == "4") break;

        switch(opcion){

            case "1":
            case "2":


               Console.Write("Ingrese el titulo de la revista a buscar:");

              string titulo = Console.ReadLine();


              bool encontrado = opcion == "1" ? BuscarRecursivo(titulo, 0) : BuscarIteractivo(titulo);

              Console .WriteLine(encontrado ? "titulo encontrado": "Titulo no encontrado");
              break;

            case "3":
                 MostrarCatalogo();
                 break;  
            default:
                 Console.WriteLine("opcion no valida, Intente de nuevo.");
                 break;

        }
    Console.WriteLine("\n Presione cualquier tecla para continuar...");
    Console.ReadKey();
}


}
static bool BuscarRecursivo(string titulo, int indice) {

    if(indice>= catalogo.Count) return false;

    if(catalogo[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))return true;
    return BuscarRecursivo (titulo, indice + 1);

}

  
    static bool BuscarIteractivo(string titulo){
    foreach(var revista in catalogo ){
        if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))return true;

    }
    return false;

}
    static void MostrarCatalogo(){
        Console.WriteLine("Lista de revistas disponibles");
        foreach(var revista in catalogo)
        {
            Console.WriteLine("  - " + revista);
        }
    }
}
