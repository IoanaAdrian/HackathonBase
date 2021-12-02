using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using backend.DbContext;
using backend.Entities;
using backend.IServices;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Services
{
    public class VerifyBlinkerService : IVerifyBlinkerService
    {
        private readonly IMapper _mapper;
        private readonly LedblinkerContext _dbContext;
        private readonly HttpClient _client;
        public VerifyBlinkerService(IMapper mapper, LedblinkerContext dbContext, HttpClient client)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _client = client;
        }

        
        public async Task<bool> AddCommand(BlinkerCommandModel model)
        {
            if (model.key == "pula")
            {
                //Console.WriteLine(_mapper.Map<Commands>(model));
                _dbContext.Add(_mapper.Map<Commands>(model));
                _dbContext.SaveChanges();

                /*var responseString = await _client.GetStringAsync("http://localhost:29949/api/blinker");
                Console.WriteLine(responseString);*/

                return true;
            }

            return false;
        }

        public List<Commands> GetAllCommands()
        {
             return _dbContext.Set<Commands>().OrderBy(a => a.id).ToList();
        }
    }
}