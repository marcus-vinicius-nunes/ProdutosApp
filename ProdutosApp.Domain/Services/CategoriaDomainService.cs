using AutoMapper;
using ProdutosApp.Domain.Dtos;
using ProdutosApp.Domain.Interfaces.Repositories;
using ProdutosApp.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Services
{
    public class CategoriaDomainService : ICategoriaDomainService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaDomainService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        public List<CategoriasResponseDto> GetAll()
        {
            return _mapper.Map<List<CategoriasResponseDto>>(_categoriaRepository.GetAll());
        }

        public void Dispose()
        {
            _categoriaRepository.Dispose();
        }
    }
}
