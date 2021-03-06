﻿using EmailManager.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmailManager.Service.Contracts
{
    public interface ILoanApplicationService
    {
        Task<LoanApplicationDTO> OpenLoanApplicationAsync(string emailId, string userId);
        Task<LoanApplicationDTO> CreateLoanApplicationAsync(string emailId);
        Task<LoanApplicationDTO> CreateLoanApplicationAsync(string clientId, string emailId, string status, string operatorId, decimal amount);
        Task<LoanApplicationDTO> GetLoanApplicationByIdAsync(string applicationId);
        Task<LoanApplicationDTO> GetLoanApplicationByEmailIdAsync(string emailId);
        Task<bool> RemoveOldApplicationByEmailIdAsync(string emailId, string operatorId);
    }
}
