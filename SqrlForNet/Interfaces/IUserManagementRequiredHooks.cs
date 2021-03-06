﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SqrlForNet.Interfaces
{
    public interface IUserManagementRequiredHooks
    {
        UserLookUpResult UserExists(string userId, HttpContext context);

        void UpdateUserId(string userId, string suk, string vuk, string oldUserId, HttpContext context);

        string GetUserVuk(string userId, HttpContext context);

        string GetUserSuk(string userId, HttpContext context);

        void UnlockUser(string userId, HttpContext context);

        void LockUser(string userId, HttpContext context);

        void RemoveUser(string userId, HttpContext context);
        
    }

    public interface IUserManagementRequiredHooksAsync
    {
        Task<UserLookUpResult> UserExists(string userId, HttpContext context);

        Task UpdateUserId(string userId, string suk, string vuk, string oldUserId, HttpContext context);

        Task<string> GetUserVuk(string userId, HttpContext context);

        Task<string> GetUserSuk(string userId, HttpContext context);

        Task UnlockUser(string userId, HttpContext context);

        Task LockUser(string userId, HttpContext context);

        Task RemoveUser(string userId, HttpContext context);

    }

    public interface IUserManagementOptionalHooks
    {
        void CreateUser(string userId, string suk, string vuk, HttpContext context);

        void SqrlOnlyReceived(string userId, HttpContext context);

        void HardlockReceived(string userId, HttpContext context);

        string GetUsername(string userId, HttpContext context);

    }

    public interface IUserManagementOptionalHooksAsync
    {
        Task CreateUser(string userId, string suk, string vuk, HttpContext context);

        Task SqrlOnlyReceived(string userId, HttpContext context);

        Task HardlockReceived(string userId, HttpContext context);

        Task<string> GetUsername(string userId, HttpContext context);
    }

}