using LineNex.Application.Interfaces;
using LineNex.Application.Dtos;
using LineNex.Core.Models;
using Microsoft.AspNetCore.Mvc;
using LineNex.Api.ExceptionHendler;
using LineNex.Api.ExceptionModel;
using Microsoft.AspNetCore.Identity;
using LineNex.Domain.Entity;
using Microsoft.AspNetCore.Authorization;

namespace LineNex.Api.Controllers
{
    /// <summary>
    /// Controller responsável por gerenciar operações relacionadas.
    /// </summary>
    public class UserController : BaseController<UserDto, UserPostModel, UserPutModel, IUserApplicationService, UserGetModel>
    {
        private readonly IUserApplicationService userApplicationService;
        private readonly IPasswordHasher<User> _hasher;

        /// <summary>
        /// Inicializa uma nova instância de <see cref="UserController"/>.
        /// </summary>
        /// <param name="userApplicationService">Serviço de aplicação para operações relacionadas.</param>
        public UserController(IUserApplicationService userApplicationService, IPasswordHasher<User> hasher)
            : base(userApplicationService)
        {
            this.userApplicationService = userApplicationService;
            _hasher = hasher;
        }

        /// <summary>
        /// Creates a new entity.
        /// </summary>
        /// <param name="userPostModel">The data for creating the entity.</param>
        /// <returns>The created entity.</returns>
        [HttpPost]
        [ValidateAtrributes]
        [Authorize(Policy = "Permission.Create")]
        public override async Task<IActionResult> Create([FromBody] UserPostModel userPostModel)
        {
            var allowedDomains = new[] { "@pucpr.edu.br", "@volvo.com" };

            if (!allowedDomains.Any(domain => userPostModel.Email.EndsWith(domain, StringComparison.OrdinalIgnoreCase)))
            {
                return BadRequest("Only emails from PUCPR or VOLVO are allowed.");
            }

            if (!ModelState.IsValid)
                throw new BadRequestException("Invalid data provided.");

            var fakeUser = new User
            {
                Name = userPostModel.Name,
                Email = userPostModel.Email,
                Password = userPostModel.Password,
                CreatedById = Guid.Empty,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                IsDeleted = false
            };
            userPostModel.Password = _hasher.HashPassword(fakeUser, userPostModel.Password);

            var result = await (service as dynamic).Create(userPostModel);
            return CreatedAtAction(nameof(GetAll), new { id = (result as dynamic).Id }, result);
        }
    }
}
