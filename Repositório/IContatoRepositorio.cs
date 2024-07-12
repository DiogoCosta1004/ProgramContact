using ProgramContact.Models;
using System.Collections.Generic;

namespace ProgramContact.Repositório
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contado);
        bool Apagar(int id);
    }
}
