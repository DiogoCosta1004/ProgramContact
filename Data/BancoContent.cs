﻿using Microsoft.EntityFrameworkCore;
using ProgramContact.Models;

namespace ProgramContact.Data
{
    public class BancoContent : DbContext
    {
        public BancoContent(DbContextOptions<BancoContent> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
