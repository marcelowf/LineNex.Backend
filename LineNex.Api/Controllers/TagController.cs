
using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class TagController : BaseController<TagDto, TagPostModel, TagPutModel, ITagApplicationService, TagGetModel>
    {
        /// <summary>
        /// Inicializa uma nova instância de <see cref="TagController"/>.
        /// </summary>
        /// <param name="tagApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public TagController(ITagApplicationService tagApplicationService)
            : base(tagApplicationService)
        {
        }
    }
}
