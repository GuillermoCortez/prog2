public class Libro
{
  public Libro(int id, string titulo, Autor autor, int paginas)
  {
    this.Id = id;
    this.Titulo = titulo;
    this.Autor = autor;
    this.Paginas = paginas;
  }
  public int Id { get; set; }
  public string Titulo { get; set; }

  public Autor Autor { get; set; }

  public int Paginas {get; set;} 
}