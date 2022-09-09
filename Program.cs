public class portatil{
    //atributos de la clase portatil
    string marca="", color="";
    int velocidad;
    //consultas
    public string consultarmarca(){

        return(this.marca);
    }
    public string consultarcolor(){
        return(this.color);
    }
    public int consultarvelocidad(){
        return(this.velocidad);
    }
    
    //metodos de accesos
    public void setmarca(string marca ){
        this.marca=marca;

    }
    public void setcolor(string color){
        this.color=color;
    }

    public void setvelocidad(int velocidad){
        this.velocidad=velocidad;
    }
   
    public void tostring(){
        Console.WriteLine("El portatil de la marca "+this.marca+" su color "+this.color+" tiene una velocidad de "+velocidad);
    }
    }   
    
    public class usuaro{
    public static void Main(string[] args){
        //define una sintacsis portatil y lo inicializa como nuebo
    portatil HP=new portatil();
    //confuguracion de marca
    HP.setmarca("HP");
    //configura el autor
    HP.setcolor("blanco");
    //configura el procesador
    HP.setvelocidad(2);
    
    //lee unos valores, los combierte y los muestra en pantalla
    HP.tostring();
    //lee unos valores, los combierte y los muestra en pantalla 

    //define una sintacsis de portatil y lo inicializa como nuebo
    portatil samsung=new portatil();
    //confIguracion de marca
    samsung.setmarca("samsung");
    //configura el color
    samsung.setcolor("negro");
    //configura el numero de paginas
    samsung.setvelocidad(3);
    samsung.tostring();

    if(HP.consultarvelocidad()>samsung.consultarvelocidad()){
        Console.WriteLine("el primer portatil tiene menos capacidad");
    }else{
        Console.WriteLine("el segundo portatil tiene mas capacidad ");

    }

}

    }