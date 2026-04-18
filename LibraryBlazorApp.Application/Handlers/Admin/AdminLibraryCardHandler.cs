using LibraryBlazorApp.Application.Dto;
using LibraryBlazorApp.Application.Interfaces.Admin;
using LibraryBlazorApp.Application.Services.Maps;
using LibraryBlazorApp.Domain.Models.Results;

namespace LibraryBlazorApp.Application.Handlers.Admin;

public class AdminLibraryCardHandler : IAdminLibraryCardHandler
{
    private readonly IAdminLibraryCardQuery _cardQuery;
    private readonly IAdminLoanCommand _loanComannd;
    private readonly IAdminClientCommand _clientCommand;
    private readonly IAdminBookCommand _bookCommand;

    public AdminLibraryCardHandler(IAdminLibraryCardQuery cardQuery, IAdminLoanCommand loanComannd, IAdminClientCommand clientCommand, IAdminBookCommand bookCommand)
    {
        _cardQuery = cardQuery;
        _loanComannd = loanComannd;
        _clientCommand = clientCommand;
        _bookCommand = bookCommand;
    }
    public async Task<Result<List<LibraryCardAdminDto>>> GetLibraryCardAdminDtoAsync()
    {
        var queryResult = await _cardQuery.GetLibraryCardAsync();
        if (!queryResult.IsSuccess) return queryResult.Error!;
        var cardMap = CardMaper.ToLibraryCardAdminDto(queryResult.Value);
        return cardMap;
    }

    public async Task<Result<int>> DeleteLibraryCardByIdsAsync(List<int> clientIds)
    {
        var commandResult = await _clientCommand.DeleteAdminClientByIdsAsync(clientIds);
        if (!commandResult.IsSuccess) return commandResult.Error!;
        return commandResult.Value;
    }

    public async Task<Result<LibraryCardAdminDto>> AddLibraryCardDtoAsync(ClientAddAdminDto clientAdd)
    {
        var clientMap = ClientMaper.ToClient(clientAdd);
        var commandResult = await _clientCommand.AddAdminClientAsync(clientMap);
        if (!commandResult.IsSuccess) return commandResult.Error!;
        var cardDtoMap = CardMaper.ToLibraryCardAdminDto(commandResult.Value.LibraryCard);
        return cardDtoMap;
    }

    public async Task<Result<LibraryCardAdminDto>> AddLoanToCardDtoAsync(LoanAddDto loanAdd)
    {
        var commandResult = await _loanComannd.CreateLoanAsync(loanAdd);
        if (!commandResult.IsSuccess) return commandResult.Error!;
        var bookCommandReslut = await _bookCommand.DecreaseBookQuantityAsync(loanAdd.BookId, 1);
        if (!bookCommandReslut.IsSuccess) return bookCommandReslut.Error!;
        var cardQueryResult = await _cardQuery.GetLibraryCardAsync(loanAdd.LibraryCardId);
        if (!cardQueryResult.IsSuccess) return cardQueryResult.Error!;
        var cardMap = CardMaper.ToLibraryCardAdminDto(cardQueryResult.Value);
        return cardMap;
    }

    public async Task<Result<LibraryCardAdminDto>> UpdateReturnBookAsync(int loanId)
    {
        var commandResult = await _loanComannd.MarkAsAReturn(loanId);
        if (!commandResult.IsSuccess) return commandResult.Error!;

        var cardQueryResult = await _cardQuery.GetLibraryCardAsync(commandResult.Value.LibraryCardId);
        if (!cardQueryResult.IsSuccess) return cardQueryResult.Error!;
        var cardMap = CardMaper.ToLibraryCardAdminDto(cardQueryResult.Value);
        return cardMap;
    }
}
