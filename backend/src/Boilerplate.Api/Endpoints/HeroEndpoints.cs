using Ardalis.Result.AspNetCore;
using Boilerplate.Application.Features.Heroes.CreateHero;
using Boilerplate.Application.Features.Heroes.DeleteHero;
using Boilerplate.Application.Features.Heroes.GetAllHeroes;
using Boilerplate.Application.Features.Heroes.GetHeroById;
using Boilerplate.Application.Features.Heroes.UpdateHero;
using Boilerplate.Domain.Entities.Common;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Text.Json;

namespace Boilerplate.Api.Endpoints;

public static class HeroEndpoints
{
    public static void MapHeroEndpoints(this IEndpointRouteBuilder builder)
    {
        var group = builder.MapGroup("api/")
            .WithTags("Hero");

        group.MapGet("/user", async (HttpContext httpContext, IMediator mediator, [AsParameters] GetAllHeroesRequest request) =>
        {
            var result = new { Name = "ANANTHA", Email = "anantha@chisquare.ai" };
            var json = JsonSerializer.Serialize(result);
            httpContext.Response.ContentType = "application/json";
            await httpContext.Response.WriteAsync(json);
        });
        
        group.MapGet("/allbranch", async (HttpContext httpContext, IMediator mediator, [AsParameters] GetAllHeroesRequest request) =>
        {
            var result = new { branches = new[] { "RETOFF", "BAS", "AZH", "FCM", "SMJ", "MOQ", "MOE", "SJGS", "MOH", "MCC", "NGS", "RAK", "LMAD", "ALM", "DHFC", "KEMP", "ACC", "DM", "NKM", "SOFITL" } };
            var json = JsonSerializer.Serialize(result);
            httpContext.Response.ContentType = "application/json";
            await httpContext.Response.WriteAsync(json);
        });

        group.MapGet("/customers", async (HttpContext httpContext, IMediator mediator, [AsParameters] GetAllHeroesRequest request) =>
        {
            var result = new Dictionary<string, Dictionary<string, int>>
            {
                ["RETOFF"] = new Dictionary<string, int>
                {
                    ["CY"] = 1000,
                    ["PY"] = 500
                },
                ["BAS"] = new Dictionary<string, int>
                {
                    ["CY"] = 1500,
                    ["PY"] = 2500
                }
            };
            var json = JsonSerializer.Serialize(result);
            httpContext.Response.ContentType = "application/json";
            await httpContext.Response.WriteAsync(json);
        });

        group.MapPost("/charts", async (HttpContext httpContext,  GetAllHeroesRequest request) =>
        {
            var revenueData = new 
            {
                Type = "Revenue",
                Overall = new Dictionary<string, Dictionary<string, dynamic>>
                {
                    ["CY"] = new Dictionary<string, dynamic> { ["value"] = 4500000, ["unit"] = "USD" },
                    ["PY"] = new Dictionary<string, dynamic> { ["value"] = 4100000, ["unit"] = "USD" }
                },
                Monthly = new Dictionary<string, Dictionary<string, dynamic>>
                {
                    ["Jan"] = new Dictionary<string, dynamic> { ["CY"] = 89000, ["PY"] = 99000 },
                    ["Feb"] = new Dictionary<string, dynamic> { ["CY"] = 89000, ["PY"] = 19000 },
                }
            };

            var stockTurnoverData = new 
            {
                Type = "Stock Turnover Ratio",
                Overall = new Dictionary<string, Dictionary<string, dynamic>>
                {
                    ["CY"] = new Dictionary<string, dynamic> { ["value"] = 0.45, ["unit"] = "%" },
                    ["PY"] = new Dictionary<string, dynamic> { ["value"] = 0.41, ["unit"] = "%" }
                },
                Monthly = new Dictionary<string, Dictionary<string, dynamic>>
                {
                    ["Jan"] = new Dictionary<string, dynamic> { ["CY"] = 0.032, ["PY"] = 0.021 },
                    ["Feb"] = new Dictionary<string, dynamic> { ["CY"] = 0.042, ["PY"] = 0.011 },
                }
            };

            if (request.Type == "Revenue")
            {
                var json = JsonSerializer.Serialize(revenueData);
                httpContext.Response.ContentType = "application/json";
                await httpContext.Response.WriteAsync(json);
            }
            else if (request.Type == "Stock Turnover Ratio")
            {
                var json = JsonSerializer.Serialize(stockTurnoverData);
                httpContext.Response.ContentType = "application/json";
                await httpContext.Response.WriteAsync(json);
            }
            else
            {
                httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                await httpContext.Response.WriteAsync("Invalid chart type");
            }
        });
    }
}