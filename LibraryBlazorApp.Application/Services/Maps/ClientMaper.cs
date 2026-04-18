using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Domain.Models;

namespace LibraryBlazorApp.Application.Services.Maps;

public static class ClientMaper
{
    public static List<ClientAdminDto> ToClientAdminDto(IEnumerable<Client> clients)
    {
        return clients.Select(c => new ClientAdminDto
        {
            Id = c.Id,
            CreatedAt = c.CreatedAt,
            UpdatedAt = c.UpdatedAt,
            Name = c.Name,
            Surname = c.Surname,
            City = c.Address.City,
            Street = c.Address.Street,
            PostalCode = c.Address.PostalCode,
            Country = c.Address.Country,
        }).ToList();
    }
    public static ClientAdminDto ToClientAdminDto(Client client)
    {
        return new ClientAdminDto()
        {
            Id = client.Id,
            CreatedAt = client.CreatedAt,
            UpdatedAt = client.UpdatedAt,
            Name = client.Name,
            Surname = client.Surname,
            City = client.Address.City,
            Street = client.Address.Street,
            PostalCode = client.Address.PostalCode,
            Country = client.Address.Country,
        };
    }

    public static Client ToClient(ClientAddAdminDto clientAdd)
    {
        return new Client()
        {
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Name = clientAdd.Name,
            Surname = clientAdd.Surname,
            Address = new Address()
            {
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                City = clientAdd.City,
                Street = clientAdd.Street,
                PostalCode = clientAdd.PostalCode,
                Country = clientAdd.Country,
            },
            LibraryCard = new()
        };
    }
    public static Client ToClient(ClientEditAdminDto clientEdit)
    {
        return new Client()
        {
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Name = clientEdit.Name,
            Surname= clientEdit.Surname,
            Address = new()
            {
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                City= clientEdit.City,
                Street = clientEdit.Street,
                PostalCode = clientEdit.PostalCode,
                Country = clientEdit.Country
            },
            LibraryCard = new()
        };
    }

}


