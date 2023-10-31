using mailService.Models;

namespace mailService.Services; 

public interface IMailService
{
    Task<bool> SendAsync(MailData mailData);
}