using Domain.Interfaces.InterfaceServicos;
using Domain.Interfaces.IUsuarioSistemaFinanceiro;
using Entities.Entidades;

namespace Domain.Servicos
{
    public class UsuarioSistemaFinanceiroServico : IUsuarioSistemaFinanceiroServico
    {
        private readonly InterfaceUsuarioSistemaFinanceiro _interfaceUsuarioSistemaFinanceiro;
        public UsuarioSistemaFinanceiroServico(InterfaceUsuarioSistemaFinanceiro usuarioSistemaFinanceiro)
        {
            _interfaceUsuarioSistemaFinanceiro = usuarioSistemaFinanceiro;
        }
        public async Task CadastrarUsuarioNoSistema(UsuarioSistemaFinanceiro usuarioSistemaFinanceiro)
        {
            await _interfaceUsuarioSistemaFinanceiro.Add(usuarioSistemaFinanceiro);
        }
    }
}
