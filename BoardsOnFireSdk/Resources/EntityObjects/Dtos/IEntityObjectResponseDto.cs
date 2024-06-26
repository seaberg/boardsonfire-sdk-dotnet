﻿using BoardsOnFireSdk.Resources.Organizations;
using BoardsOnFireSdk.Resources.Users;

namespace BoardsOnFireSdk.Resources.EntityObjects.Dtos;

/// <summary>
/// Default fields for entity object. Create implementation with your custom fields.
/// </summary>
public interface IEntityObjectResponseDto
{
    public Guid? Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ArchivedAt { get; set; }
    public string? ExternalId { get; set; }
    public OrganizationBaseResponseDto? Organization { get; set; }
    public UserCreatedByDto? BofCreatedBy { get; set; }
}