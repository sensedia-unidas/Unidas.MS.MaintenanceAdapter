using MaintenanceAdapter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceAdapter.Application.Interfaces.UseCases.MaintenanceIntegration
{
    public interface IMessageIntegrationUseCase
    {
        Task<IMessageIntegrationUseCase> Execute(string queue, MessageIntegration message);
    }
}
