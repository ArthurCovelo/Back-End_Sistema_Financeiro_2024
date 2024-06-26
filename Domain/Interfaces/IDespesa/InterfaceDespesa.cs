﻿using Domain.Interfaces.Generics;
using Entities.Entidades;

namespace Domain.Interfaces.IDespesa
{
    public interface InterfaceDespesa : InterfaceGeneric<Despesa>
    {
        Task<IList<Despesa>> ListarDespesaUsuario(string emailUsuario);
        Task<IList<Despesa>> ListarDespesaUsuarioNaoPagasMesesAnterior(string emailUsuario);
    }
}
