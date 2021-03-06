﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Dominio
{
    interface IRepositorioGenerico<T>
    {
        T ObtenerPorCodigo(params object[] ao_llaves);
        IQueryable<T> Listar();
        IList<T> ObtenerPorExperesion ( 
            Expression <Func<T,bool>> ao_llaves = null, string as_incluir = null, byte aby_limite = 0);
        bool Adicionar(T ao_entidad);
        bool Actualizar(T ao_entidad);
        bool GuardarCambios();
    }
}
