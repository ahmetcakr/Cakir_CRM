﻿using Core.Application.Dtos;

namespace CRM.Application.Features.OperationClaims.Queries.GetList;

public class GetListOperationClaimListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    public GetListOperationClaimListItemDto()
    {
        Name = string.Empty;
    }

    public GetListOperationClaimListItemDto(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
