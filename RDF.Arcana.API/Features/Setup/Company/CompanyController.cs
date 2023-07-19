﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Tls.Crypto.Impl;
using RDF.Arcana.API.Common;
using RDF.Arcana.API.Common.Extension;
using RDF.Arcana.API.Common.Pagination;


namespace RDF.Arcana.API.Features.Setup.Company;

[Route("api/[controller]")]
[ApiController]

public class CompanyController : ControllerBase
{
    private readonly IMediator _mediator;
    public CompanyController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Route("AddNewCompany")]
    public async Task<IActionResult> AddNewCompany(AddNewCompany.AddNewCompanyCommand command)
    {
        try
        {
            await _mediator.Send(command);
            return Ok("Successfully added!");
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpGet]
    [Route("GetAllCompaniesAsync")]
    public async Task<IActionResult> GetAllCompanies()
    {
        var response = new QueryOrCommandResult<IEnumerable<GetAllCompaniesAsync.GetAllCompaniesResult>>();
        try
        {
            var query = new GetAllCompaniesAsync.GetAllCompaniesQuery();
            var result = await _mediator.Send(query);
            response.Success = true;
            response.Data = result;
            response.Messages.Add("Collection successfully fetch");
            return Ok(response);

        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpGet("GetAllCompaniesByStatus")]
    public async Task<IActionResult> GetAllCompaniesByStatus([FromQuery]GetCompaniesByStatusAsync.GetCompaniesByStatusQuery request)
    {
      
        try
        {
            var companies = await _mediator.Send(request);
            Response.AddPaginationHeader(
                companies.CurrentPage,
                companies.PageSize,
                companies.TotalCount,
                companies.TotalPages,
                companies.HasPreviousPage,
                companies.HasNextPage
                );
            var results = new QueryOrCommandResult<object>
            {
                Success = true,
                Data = new
                {
                    companies,
                    companies.CurrentPage,
                    companies.PageSize,
                    companies.TotalCount,
                    companies.TotalPages,
                    companies.HasPreviousPage,
                    companies.HasNextPage
                }
            };
            results.Messages.Add("Successfully Fetch");
            return Ok(results);
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpPut]
    [Route("UpdateCompany")]
    public async Task<IActionResult> UpdateCompany(UpdateCompany.UpdateCompanyCommand command)
    {
        var response = new QueryOrCommandResult<object>();
        try
        {
            var result = await _mediator.Send(command);
            response.Success = true;
            response.Messages.Add("Company successfully updated");
            return Ok(response);
        }
        catch (Exception e)
        {
            response.Success = false;
            response.Messages.Add(e.Message);
            return Ok(response);
        }
    }

    [HttpPatch("UpdateCompanyStatus")]
    public async Task<IActionResult> UpdateCompanyStatus(UpdateCompanyStatus.UpdateCompanyStatusCommand command)
    {
        var response = new QueryOrCommandResult<object>();
        try
        {
            await _mediator.Send(command);
            response.Success = true;
            response.Messages.Add("Successfully updated the status");
            return Ok(response);
        }
        catch (Exception e)
        {
            response.Success = false;
            response.Messages.Add(e.Message);
            return Conflict(response);
        }
    }
    
    
}