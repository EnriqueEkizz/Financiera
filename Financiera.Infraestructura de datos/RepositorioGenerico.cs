using Financiera.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Infraestructura_de_datos
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        FinancieraContexto io_contexto;
        public IDbSet<T> Entidad { get; set; }
        public RepositorioGenerico(FinancieraContexto ao_contexto)
        {
            this.Entidad = ao_contexto.Set<T>();
        }
        public RepositorioGenerico() : this(new FinancieraContexto());
        {
        }
        public T ObtenerPorCodigo(params object[] ao_llaves)
        {
            return Entidad.Find(ao_llaves);
        }
        public IList<T> ObtenerPorExperesion(Expression<Func<T, bool>> ao_llaves = null, string as_incluir = null, byte aby_limite = 0)
        {
            if (ao_llaves == null)
                return Entidad.ToList();
            else
                return Entidad.Where(ao_llaves).ToList();
        }
        public IQueryable<T> Listar()
        {
            return Entidad;
        }
        public bool Adicionar(T ao_entidad)
        {
            Entidad.Add(ao_entidad);
            return true;
        }
        public bool Actualizar(T ao_entidad)
        {
            throw new NotImplementedException();
        }
        public bool GuardarCambios()
        {
            io_contexto.SaveChanges();
            return false;
        }

        public IList<T> ObtenerPorExperesion(Expression<Func<T, bool>> ao_llaves = null, string as_incluir = null, byte aby_limite = 0)
        {
            throw new NotImplementedException();
        }
    }
}