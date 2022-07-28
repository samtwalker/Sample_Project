using System;
using AutoMapper;
using Sample_Project.Models;
using Sample_Project.DTOs;

namespace Sample_Project.Data
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<TransactionCreateDto, TransactionModel>();
            CreateMap<TransactionModel, TransactionReadDto>(); 
        }
    }
}

