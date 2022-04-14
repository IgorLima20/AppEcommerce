using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppEcommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppEcommerce.Data
{
    public class Contexto : IdentityDbContext<User>
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        // public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }

        // public DbSet<Cart> Tab_Cart { get; set; }
        // public DbSet<Order> Tab_Order { get; set; }
        // public DbSet<OrderDetail> Tab_OrderDetail { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Identity Name Definition
            // Renomeia a Tabela de Usuários
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable(name: "User");
            });
            // Renomeia a Tabela de Perfis
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            // Renomeia a Tabela de Perfis do Usuários
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable(name: "UserRoles");
            });
            // Renomeia a Tabela de Regras dos Usuários
            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable(name: "UserClaims");
            });
            // Renomeia a Tabela de Logins do Usuários
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable(name: "UserLogins");
            });
            // Renomeia a Tabela de Tokens do Usuários
            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable(name: "UserTokens");
            });
            // Renomeia a Tabela de Regras do Perfil
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable(name: "RoleClaims");
            });
            #endregion

            #region ItemPedidos Concat Primary Key and Relationship Many to Many
            // modelBuilder.Entity<ItemPedido>().HasKey(
            //     s => new { s.IdPedido, s.IdProduto }
            // );
            // modelBuilder.Entity<ItemPedido>()
            //     .HasOne(s => s.Pedido)
            //     .WithMany(u => u.ItensPedido)
            //     .HasForeignKey(s => s.IdPedido);

            // modelBuilder.Entity<ItemPedido>()
            //     .HasOne(s => s.Produto)
            //     .WithMany(c => c.ProdutosItens)
            //     .HasForeignKey(s => s.IdProduto);
            #endregion

            #region Populate Identity
            string ADMIN_ID = Guid.NewGuid().ToString();
            string MODERADOR_ID = Guid.NewGuid().ToString();
            string USUARIO_ID = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ADMIN_ID,
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },
                new IdentityRole
                {
                    Id = MODERADOR_ID,
                    Name = "Moderador",
                    NormalizedName = "MODERADOR"
                },
                new IdentityRole
                {
                    Id = USUARIO_ID,
                    Name = "Usuario",
                    NormalizedName = "USUARIO"
                }
            );
            var hash = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = ADMIN_ID,
                    NomeCompleto = "Igor Oliveira de Lima",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@ecommerce.com.br",
                    NormalizedEmail = "ADMIN@ECOMMERCE.COM.BR",
                    EmailConfirmed = true,
                    PasswordHash = hash.HashPassword(null, "123456"),
                    SecurityStamp = hash.GetHashCode().ToString()
                }
            );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ADMIN_ID,
                    UserId = ADMIN_ID
                }
            );
            #endregion

            #region Populate Categoria
            Guid[] guid = new Guid[6];
            for (int i = 0; i < 6; i++) guid[i] = Guid.NewGuid();
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria()
                {
                    Id = guid[0],
                    Nome = "Hardware",
                    Imagem = "~/img/Produtos/001.png"
                },
                new Categoria()
                {
                    Id = guid[1],
                    Nome = "Celulares",
                    Imagem = "~/img/Produtos/002.png"
                },
                new Categoria()
                {
                    Id = guid[2],
                    Nome = "Periféricos",
                    Imagem = "~/img/Produtos/003.png"
                },
                new Categoria()
                {
                    Id = guid[3],
                    Nome = "Games",
                    Imagem = "~/img/Produtos/004.png"
                },
                new Categoria()
                {
                    Id = guid[4],
                    Nome = "Cadeiras",
                    Imagem = "~/img/Produtos/005.png"
                },
                new Categoria()
                {
                    Id = guid[5],
                    Nome = "Conectividade",
                    Imagem = "~/img/Produtos/006.png"
                }

            );
            #endregion

            #region Populate Marca
            Guid[] gui = new Guid[4];
            for (int i = 0; i < 4; i++) gui[i] = Guid.NewGuid();
            modelBuilder.Entity<Marca>().HasData(
                new Marca()
                {
                    Id = gui[0],
                    Nome = "Nvidia"
                },
                 new Marca()
                 {
                     Id = gui[1],
                     Nome = "Logitech"
                 },
                 new Marca()
                 {
                     Id = gui[2],
                     Nome = "Motorola"
                 },
                 new Marca()
                 {
                     Id = gui[3],
                     Nome = "D-Link"
                 }
            );
            #endregion

            #region Populate Produtos
            var produtos = new List<Produto>(){
                new Produto(){
                    Id = 1,
                    Nome = "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb",
                    Valor = 1223,
                    Estoque = 8,
                    IdMarca = gui[0],
                    Descricao = "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.",
                    Imagem = "~/img/Produtos/1.jpg",
                    IdCategoria = guid[0]
                },
                new Produto(){
                    Id = 2,
                    Nome = "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG",
                    Valor = 7936,
                    Estoque = 10,
                    IdMarca = gui[0],
                    Descricao = "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.",
                    Imagem = "~/img/Produtos/2.jpg",
                    IdCategoria = guid[0]
                },
                new Produto(){
                    Id = 3,
                    Nome = "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631",
                    Valor = 209,
                    Estoque = 16,
                    IdMarca = gui[1],
                    Descricao = "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.",
                    Imagem = "~/img/Produtos/3.jpg",
                    IdCategoria = guid[2]
                },
                new Produto(){
                    Id = 4,
                    Nome = "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014",
                    Valor = 179,
                    Estoque = 20,
                    IdMarca = gui[1],
                    Descricao = "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.",
                    Imagem = "~/img/Produtos/4.jpg",
                    IdCategoria = guid[2]
                },
                new Produto(){
                    Id = 5,
                    Nome = "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290",
                    Valor = 349,
                    Estoque = 1,
                    IdMarca = gui[1],
                    Descricao = "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.",
                    Imagem = "~/img/Produtos/5.jpg",
                    IdCategoria = guid[2]
                },
                new Produto(){
                    Id = 6,
                    Nome = "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp",
                    Valor = 2743,
                    Estoque = 0,
                    IdMarca = gui[0],
                    Descricao = "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.",
                    Imagem = "~/img/Produtos/6.jpg",
                    IdCategoria = guid[0]
                },
                new Produto(){
                    Id = 7,
                    Nome = "Smartphone Motorola Moto E7, 64GB, RAM 4GB, Octa-Core, Câmera 48MP, 4000mAh, Cinza Metálico - PALV0031BR",
                    Valor = 892,
                    Estoque = 20,
                    IdMarca = gui[2],
                    Descricao = "O Smartphone Moto E7 conta com sensor de câmera de 48MP que deixam as fotos sempre claras e nítidas, em qualquer iluminação. A tecnologia que o acompanha, Quad Pixel, proporciona 4 vezes mais sensibilidade a luz, para que os resultados fiquem ótimos em qualquer ambiente.",
                    Imagem = "~/img/Produtos/7.jpg",
                    IdCategoria = guid[1]
                },
                new Produto(){
                    Id = 8,
                    Nome = "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps, Dual Band, 4 Antenas - DIR-842",
                    Valor = 164,
                    Estoque = 10,
                    IdMarca = gui[3],
                    Descricao = "Com recursos de ponta como TR-069 e interface web amigável que possibilita a criação de uma firmware personalizável, o DIR-842 é perfeito para provedores de internet que desejam implementar uma solução Wi-Fi de alta qualidade com a possibilidade de personalizar diversos dispositivos ao mesmo tempo. ",
                    Imagem = "~/img/Produtos/8.jpg",
                    IdCategoria = guid[5]
                },
            };
            modelBuilder.Entity<Produto>().HasData(produtos);
            #endregion

        }

    }
}