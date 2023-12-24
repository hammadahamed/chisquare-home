using Boilerplate.Application.Common.Responses;
using Boilerplate.Domain.Entities.Enums;
using MediatR;

namespace Boilerplate.Application.Features.Heroes.GetAllHeroes;

public record GetAllHeroesRequest
    (string? Name = null, string? Nickname = null, int? Age = null, string? Individuality = null, HeroType? HeroType = null, string? Type = null, int CurrentPage = 1, int PageSize = 1 ) : IRequest<PaginatedList<GetHeroResponse>>;