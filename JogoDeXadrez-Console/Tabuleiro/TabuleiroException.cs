using System;

namespace TabuleiroSpace
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string mensagemErro) : base(mensagemErro)
        {

        }
    }
}
