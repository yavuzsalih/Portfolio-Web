﻿namespace İlkProjem.Areas.Writer.Models
{
    public class UserEditViewsModel
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Password { get; set; }
        public string? PasswordConfirm { get; set; }
        public string? PictureUrl { get; set; }
        public IFormFile? Picture { get; set; }
    }
}
