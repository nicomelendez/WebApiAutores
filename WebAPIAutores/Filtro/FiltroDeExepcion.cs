using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAPIAutores.Filtro
{
    public class FiltroDeExepcion: ExceptionFilterAttribute
    {
        private readonly ILogger<FiltroDeExepcion> logger;

        public FiltroDeExepcion(ILogger<FiltroDeExepcion> logger)
        {
            this.logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            logger.LogError(context.Exception, context.Exception.Message);
            base.OnException(context);
        }
    }
}
