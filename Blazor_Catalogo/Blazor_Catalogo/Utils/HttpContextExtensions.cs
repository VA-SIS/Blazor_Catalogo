using Microsoft.EntityFrameworkCore;

namespace Blazor_Catalogo.Utils;

public static class HttpContextExtensions
{
    public async static Task InserirParametroEmPageResponse<T>(this HttpContext context,
       IQueryable<T> queryable, int quantidadeTotalRegistrosAExibir)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }

        double quantidadeRegistrosTotal = await queryable.CountAsync();
        double totalPaginas = Math.Ceiling(quantidadeRegistrosTotal / quantidadeTotalRegistrosAExibir);

        //salvando as informações no header do response
        context.Response.Headers.Append("quantidadeRegistrosTotal", quantidadeRegistrosTotal.ToString());
        context.Response.Headers.Append("totalPaginas", totalPaginas.ToString());
    }
}
