class Estudiante
{
    public string nombre;
    public string carnet;
    public Curso[] curso;
    public Estudiante(string nombre, string carnet)
    {
        this.nombre = nombre;
        this.carnet = carnet;
        this.curso = new Curso[2];
    }
}
