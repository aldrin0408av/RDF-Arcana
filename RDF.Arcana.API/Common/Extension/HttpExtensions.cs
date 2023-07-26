﻿using System.Text.Json;
using RDF.Arcana.API.Common.Pagination;

namespace RDF.Arcana.API.Common.Extension
{
    public static class HttpExtensions
    {

        public static void AddPaginationHeader(
            this HttpResponse response,
            int currentPage,
            int itemsPerPage, 
            int totalItems,
            int totalPage,    
            bool hasPreviousPage,
            bool hasNextPage)
        {

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPage, hasPreviousPage, hasNextPage);
            response.Headers.Add("Pagination", JsonSerializer.Serialize(paginationHeader, options));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }

    }
}
