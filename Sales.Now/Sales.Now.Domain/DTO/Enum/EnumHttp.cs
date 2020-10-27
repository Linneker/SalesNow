using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Now.Domain.DTO.Enum
{
    public enum EnumHttp
    {
        Sucesso = 200,
        ErroServidor = 500,
        SemPermissao = 403,
        InformacoesErradas = 402
    }
}
