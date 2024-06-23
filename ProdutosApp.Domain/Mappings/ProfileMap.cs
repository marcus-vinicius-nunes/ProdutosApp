using AutoMapper;
using ProdutosApp.Domain.Dtos;
using ProdutosApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Mappings
{
    public class ProfileMap : Profile
    {
        public ProfileMap()
        {
            CreateMap<Categoria, CategoriasResponseDto>();

            CreateMap<ProdutosRequestDto, Produto>();

            CreateMap<Produto, ProdutosResponseDto>()
                .AfterMap((src, dest) =>
                {
                    dest.Total = src.Preco * src.Quantidade;
                });
        }
    }
}
