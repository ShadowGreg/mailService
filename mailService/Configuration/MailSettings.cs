namespace mailService.Configuration; 

public class MailSettings {
    public string? DisplayName { get; set; } = "greg@yandex.ru";
    public string? From { get; set; } = "greg@yandex.ru";
    public string? UserName { get; set; } 
    public string? Password { get; set; }
    public string? Host { get; set; }
    public int Port { get; set; }
    public bool UseSSL { get; set; }
    public bool UseStartTls { get; set; }
    public bool UseOAuth { get; set; }
}