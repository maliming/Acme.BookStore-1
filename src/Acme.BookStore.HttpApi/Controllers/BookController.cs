using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Controllers;

[RemoteService(Name = "BookStore")]
[Area("BookStore")]
[Microsoft.AspNetCore.Components.Route("api/books")]
public class BookController : BookStoreController, IBookAppService
{
    private IBookAppService _bookAppService;

    public BookController(IBookAppService bookAppService)
    {
        _bookAppService = bookAppService;
    }

    [HttpGet("{id}")]
    public Task<BookDto> GetAsync(Guid id)
    {
        return _bookAppService.GetAsync(id);
    }

    [HttpGet]
    public Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return _bookAppService.GetListAsync(input);
    }

    [HttpPost]
    public Task<BookDto> CreateAsync(BookDto input)
    {
        return _bookAppService.CreateAsync(input);
    }

    [HttpPut("{id}")]
    public Task<BookDto> UpdateAsync(Guid id, BookDto input)
    {
        return _bookAppService.UpdateAsync(id, input);
    }

    [HttpDelete("{id}")]
    public Task DeleteAsync(Guid id)
    {
        return _bookAppService.DeleteAsync(id);
    }
}
