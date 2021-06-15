using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace APICatalogoJogosDIO.Controllers.V1
{

    public interface IExemploTransient : IExemploGeral
    { }

    public class ExemploCicloDeVida : IExemploSingleton, IExemploScoped, IExemploTransient
    {
        private readonly Guid _guid;

        public ExemploCicloDeVida()
        {
            _guid = Guid.NewGuid();
        }

        public Guid Id => _guid;
    }
}