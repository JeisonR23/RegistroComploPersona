
public class PersonasBLL
{
    private Contexto _contexto;

    public PersonasBLL(Contexto contexto)
    {
        this._contexto = contexto;
    }

    public bool Guardar(Personas persona)
    {
        if (!Existe(persona.PersonaId))
        {
            return Insertar(persona);
        }
        else
        {
            return Modificar(persona);
        }
    }

    public bool Existe(int personaId)
    {
        return _contexto.Personas.Any(p => p.PersonaId == personaId);
    }

    public bool Insertar(Personas persona)
    {
        _contexto.Personas.Add(persona);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    public bool Modificar(Personas persona)
    {
        _contexto.Entry(persona).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }
       public bool Eliminar(Personas persona)
    {
        _contexto.Entry(persona).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    public Personas Buscar(int personaId)
    {
        var encontrado = _contexto.Personas.Find(personaId);
        return encontrado;

    }

    public List<Personas> GetPersonas()
    {
        return _contexto.Personas.ToList();
    }
}