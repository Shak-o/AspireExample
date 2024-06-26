﻿namespace TaskManager.Infrastructure.RequestModels;

public class CreateAccountRequest
{
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public int RequesterUserId { get; set; }
    public AccountType AccountType { get; set; }
}