using System;


namespace APICatalogoJogosDIO.Exceptions
{
    public class JogoCadastradoException : Exception
    {
        public JogoCadastradoException()
            : base("Este já jogo está cadastrado")
        { }
    }
}
