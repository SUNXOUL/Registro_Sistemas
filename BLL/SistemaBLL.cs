using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroSistemas.DAL;
using RegistroSistemas.Models;
namespace RegistroSistemas.BLL
{
    public class SistemaBLL
    {
        private Contexto _contexto;
        public SistemaBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Guardar(Sistemas Sistema) // busca si el registro existe, si existe lo modifica y si no lo inserta
        {
            if (!Existe(Sistema.SistemaId))
                return Insertar(Sistema);
            else
                return Modificar(Sistema);
        }

        public bool Existe(int SistemaId)
        {
            return _contexto.Sistemas.Any(o => o.SistemaId == SistemaId); // busca si Existe algun registro con ese Id y retorna la respuesta bool
        }

        private bool Insertar(Sistemas Sistema)
        {
            _contexto.Sistemas.Add(Sistema);
            int cantidad = _contexto.SaveChanges();
            _contexto.Entry(Sistema).State = EntityState.Detached;//indica que la entidad ya no sera rastreada por el framework
            return cantidad > 0;
        }

        public bool Modificar(Sistemas Sistema)
        {
            _contexto.Update(Sistema);
            int cantidad = _contexto.SaveChanges();
            _contexto.Entry(Sistema).State = EntityState.Detached;
            return cantidad > 0;
        }

        public bool Eliminar(Sistemas Sistema)
        {
            _contexto.Sistemas.Remove(Sistema);
            int cantidad = _contexto.SaveChanges();
            _contexto.Entry(Sistema).State = EntityState.Detached;
            return cantidad > 0;
        }

        public Sistemas? Buscar(int SistemaId)
        {
            return _contexto.Sistemas.AsNoTracking().SingleOrDefault(o => o.SistemaId == SistemaId);
        }

        public List<Sistemas> GetList()
        {
            return _contexto.Sistemas.AsNoTracking().ToList();
        }
    }
}