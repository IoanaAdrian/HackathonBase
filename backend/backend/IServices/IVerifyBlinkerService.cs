using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Entities;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.IServices
{
    public interface IVerifyBlinkerService
    {
        Task<bool> AddCommand(BlinkerCommandModel model);
        Commands GetAllCommands();
    }
}
