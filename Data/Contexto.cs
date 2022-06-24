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
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<ImagemSite> ImagensSite { get; set; }
        public DbSet<Contato> Contatos { get; set; }
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
            // modelBuilder.Entity<Produto>()
            //     .OwnsMany(c => c.ImagemPrincipalPrincipal, e => 
            //     {
            //         e.WithOwner().HasForeignKey("Id");
            //         e.HasKey("Id", "IdImagemPrincipal");
            //     });
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
                    Email = "igorsax258@gmail.com",
                    NormalizedEmail = "IGORSAX258@GMAIL.COM",
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
            var categoria = new List<Categoria>(){
                new Categoria(){
                    Id = 1,
                    Nome = "Hardware",
                    Imagem = "\\img\\categorias\\001.png"
                },
                new Categoria(){
                    Id = 2,
                    Nome = "Celulares",
                    Imagem = "\\img\\categorias\\002.png"
                },
                new Categoria()
                {
                    Id = 3,
                    Nome = "Periféricos",
                    Imagem = "\\img\\categorias\\003.png"
                },
                new Categoria()
                {
                    Id = 4,
                    Nome = "Games",
                    Imagem = "\\img\\categorias\\004.png"
                },
                new Categoria()
                {
                    Id = 5,
                    Nome = "Cadeiras",
                    Imagem = "\\img\\categorias\\005.png"
                },
                new Categoria()
                {
                    Id = 6,
                    Nome = "Conectividade",
                    Imagem = "\\img\\categorias\\006.png"
                },
                new Categoria()
                {
                    Id = 7,
                    Nome = "TV",
                    Imagem = "\\img\\categorias\\007.png"
                },
                new Categoria()
                {
                    Id = 8,
                    Nome = "Áudio",
                    Imagem = "\\img\\categorias\\008.png"
                },
                new Categoria()
                {
                    Id = 9,
                    Nome = "Segurança",
                    Imagem = "\\img\\categorias\\009.png"
                },
                new Categoria()
                {
                    Id = 10,
                    Nome = "Câmeras Digitais",
                    Imagem = "\\img\\categorias\\010.png"
                },
                new Categoria()
                {
                    Id = 11,
                    Nome = "Serviços Digitais e Softwares",
                    Imagem = "\\img\\categorias\\011.png"
                },
                new Categoria()
                {
                    Id = 12,
                    Nome = "Automotivo",
                    Imagem = "\\img\\categorias\\012.png"
                },
            };
            modelBuilder.Entity<Categoria>().HasData(categoria);
            #endregion

            #region Populate Marca
            var marca = new List<Marca>(){
               new Marca()
                {
                    Id = 1,
                    Nome = "Nvidia"
                },
                 new Marca()
                 {
                    Id = 2,
                    Nome = "Logitech"
                 },
                 new Marca()
                 {
                    Id = 3,
                    Nome = "Motorola"
                 },
                 new Marca()
                 {
                    Id = 4,
                    Nome = "D-Link"
                 },
                 new Marca()
                 {
                    Id = 5,
                    Nome = "Asus",
                    Imagem = "\\img\\marcas\\asus.png",
                    ExibirHome = true
                 },
                 new Marca()
                 {
                    Id = 6,
                    Nome = "Acer",
                    Imagem = "\\img\\marcas\\acer.png",
                    ExibirHome = true
                 },
                 new Marca()
                 {
                    Id = 7,
                    Nome = "Razer"
                 },
                 new Marca()
                 {
                    Id = 8,
                    Nome = "Apple",
                    Imagem = "\\img\\marcas\\apple.png",
                    ExibirHome = true
                 },
                 new Marca()
                 {
                    Id = 9,
                    Nome = "Dell",
                    Imagem = "\\img\\marcas\\dell.png",
                    ExibirHome = true
                 },
                 new Marca()
                 {
                    Id = 10,
                    Nome = "Hp",
                    Imagem = "\\img\\marcas\\hp.png",
                    ExibirHome = true
                 },
                 new Marca()
                 {
                    Id = 11,
                    Nome = "Multilaser",
                    Imagem = "\\img\\marcas\\multilaser.png",
                    ExibirHome = true
                 },
                 new Marca()
                 {
                    Id = 12,
                    Nome = "Lenovo",
                    Imagem = "\\img\\marcas\\lenovo.png",
                    ExibirHome = true
                 },
                 new Marca()
                 {
                    Id = 13,
                    Nome = "Positivo",
                    Imagem = "\\img\\marcas\\positivo.png",
                    ExibirHome = true
                 },
                 new Marca()
                 {
                    Id = 14,
                    Nome = "Sony",
                    Imagem = "\\img\\marcas\\sony.png",
                    ExibirHome = true
                 },
                 new Marca()
                 {
                    Id = 15,
                    Nome = "K-WHEEL"
                 },
                  new Marca()
                 {
                    Id = 16,
                    Nome = "LG"
                 },
            };
            modelBuilder.Entity<Marca>().HasData(marca);
            #endregion

            #region Populate Produtos
            var produtos = new List<Produto>(){
                new Produto(){
                    Id = 1,
                    Nome = "Placa Gráfica Nvidia Quadro P400",
                    NomeDescricao = "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb",
                    Valor = 1223,
                    Estoque = 8,
                    IdMarca = 1,
                    Descricao = "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.",
                    ImagemPrincipal = "\\img\\produtos\\1.jpg",
                    IdCategoria = 1,
                    ExibirHome = true
                },
                new Produto(){
                    Id = 2,
                    Nome = "Placa De Vídeo Galax GeForce RTX 3070",
                    NomeDescricao = "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG",
                    Valor = 7936,
                    Estoque = 10,
                    IdMarca = 1,
                    Descricao = "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.",
                    ImagemPrincipal = "\\img\\produtos\\2.jpg",
                    IdCategoria = 1,
                    ExibirHome = true
                },
                new Produto(){
                    Id = 3,
                    Nome = "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC",
                    NomeDescricao = "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631",
                    Valor = 209,
                    Estoque = 16,
                    IdMarca = 2,
                    Descricao = "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.",
                    ImagemPrincipal = "\\img\\produtos\\3.jpg",
                    IdCategoria = 3,
                    ExibirHome = true
                },
                new Produto(){
                    Id = 4,
                    Nome = "Headset com fio USB Logitech H390 com Almofadas em Couro",
                    NomeDescricao = "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014",
                    Valor = 179,
                    Estoque = 20,
                    IdMarca = 2,
                    Descricao = "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.",
                    ImagemPrincipal = "\\img\\produtos\\4.jpg",
                    IdCategoria = 3,
                    ExibirHome = true
                },
                new Produto(){
                    Id = 5,
                    Nome = "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI",
                    NomeDescricao = "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290",
                    Valor = 349,
                    Estoque = 1,
                    IdMarca = 2,
                    Descricao = "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.",
                    ImagemPrincipal = "\\img\\produtos\\5.jpg",
                    IdCategoria = 3,
                    ExibirHome = true
                },
                new Produto(){
                    Id = 6,
                    Nome = "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb",
                    NomeDescricao = "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp",
                    Valor = 2743,
                    Estoque = 0,
                    IdMarca = 1,
                    Descricao = "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.",
                    ImagemPrincipal = "\\img\\produtos\\6.jpg",
                    IdCategoria = 1,
                    ExibirHome = true
                },
                new Produto(){
                    Id = 7,
                    Nome = "Smartphone Motorola Moto E7, 64GB, RAM 4GB",
                    NomeDescricao = "Smartphone Motorola Moto E7, 64GB, RAM 4GB, Octa-Core, Câmera 48MP, 4000mAh, Cinza Metálico - PALV0031BR",
                    Valor = 892,
                    Estoque = 20,
                    IdMarca = 3,
                    Descricao = "O Smartphone Moto E7 conta com sensor de câmera de 48MP que deixam as fotos sempre claras e nítidas, em qualquer iluminação. A tecnologia que o acompanha, Quad Pixel, proporciona 4 vezes mais sensibilidade a luz, para que os resultados fiquem ótimos em qualquer ambiente.",
                    ImagemPrincipal = "\\img\\produtos\\7.jpg",
                    IdCategoria = 2,
                    ExibirHome = true
                },
                new Produto(){
                    Id = 8,
                    Nome = "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps",
                    NomeDescricao = "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps, Dual Band, 4 Antenas - DIR-842",
                    Valor = 164,
                    Estoque = 10,
                    IdMarca = 4,
                    Descricao = "Com recursos de ponta como TR-069 e interface web amigável que possibilita a criação de uma firmware personalizável, o DIR-842 é perfeito para provedores de internet que desejam implementar uma solução Wi-Fi de alta qualidade com a possibilidade de personalizar diversos dispositivos ao mesmo tempo. ",
                    ImagemPrincipal = "\\img\\produtos\\8.jpg",
                    IdCategoria = 6,
                    ExibirHome = true
                },
                new Produto(){
                    Id = 9,
                    Nome = "WebCam Asus C3, Full HD 1080p, 30fps",
                    NomeDescricao = "WebCam Asus C3, Full HD 1080p, 30fps, Rotação 360 Graus - 90YH0340-B2UA00",
                    Valor =  229,
                    Estoque = 6,
                    IdMarca = 5,
                    Descricao = "Desfrute de streaming de vídeo mais nítido e suave e áudio cristalino com ASUS Webcam. Fornecendo vídeo FHD (1920 x 1080) nítido e detalhado em um formato widescreen, a ASUS Webcam pode ser conectada via USB e colocada em qualquer lugar em sua mesa ou em cima de seu monitor. Um mecanismo de rotação de 360 ??° garante flexibilidade para qualquer ângulo de câmera, e uma matriz de microfone beamforming integrado garante áudio alto e claro. Desfrute de chamadas de vídeo de alta resolução 1080p e streams em 30 quadros por segundo suaves. A lente grande angular captura mais, tornando a ASUS Webcam perfeita para conferências, teletrabalho ou bate-papos com duas ou mais pessoas sentadas lado a lado.",
                    ImagemPrincipal = "\\img\\produtos\\10.jpg",
                    IdCategoria = 3,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 10,
                    Nome = "Gabinete Gamer Asus GR101, Mini Tower",
                    NomeDescricao = "Gabinete Gamer Asus GR101, Mini Tower, Lateral e Frente em Vidro Temperado, Preto - ROG Z11 CASE/BLK",
                    Valor =  2199,
                    Estoque = 1,
                    IdMarca = 5,
                    Descricao = "Cada recurso foi projetado conscientemente com o usuário em mente para maximizar a utilidade, flexibilidade e conectividade. O design de inclinação de 11 ° patenteado fornece fluxo de ar otimizado e dissipação de calor para criar uma solução inovadora que maximiza o desempenho térmico com hardware exigente - como uma fonte de alimentação ATX ou uma placa de vídeo de 3 slots sem um cabo riser. Para ventiladores de refrigeração a água, o Z11 oferece amplo espaço e a opção de um circuito de refrigeração líquido personalizado.",
                    ImagemPrincipal = "\\img\\produtos\\11.jpg",
                    IdCategoria = 3,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 11,
                    Nome = "Fone de Ouvido Gamer Asus ROG Cetra II Core Compativel com PCs",
                    NomeDescricao = "Fone de Ouvido Gamer Asus ROG Cetra II Core Compativel com PCs, Mobile, PlayStation 5, Xbox Series X/S e Nintendo Switch - 90YH02V0-B2UA00",
                    Valor =  359,
                    Estoque = 8,
                    IdMarca = 5,
                    Descricao = "Fones de ouvido intra-auriculares para jogos ROG Cetra II Core com drivers de borracha de silicone líquido (LSR) e um conector de 3,5 mm compatível com PCs, laptops, telefones celulares, ROG Phone 5, PlayStation 5, Xbox Series X / S e Nintendo Switch. Drivers inovadores de borracha de silicone líquido (LSR) fornecem desempenho de alto-falante estável, graves incrivelmente fortes e áudio de jogo otimizado. O conector de cabo de 90 ° oferece maior conforto para jogos portáteis. A carcaça de metal leve oferece uma aparência marcante e resistência a arranhões, elevando a estética e a durabilidade do exterior. O design ergonômico com pontas e barbatanas LSR ultrasoft proporcionam um ajuste perfeitamente confortável.",
                    ImagemPrincipal = "\\img\\produtos\\12.jpg",
                    IdCategoria = 3,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 12,
                    Nome = "Teclado Gamer Acer Nitro Tkl Rgb Membrana",
                    NomeDescricao = "Teclado Gamer Acer Nitro Tkl Rgb Membrana Abnt2 Usb - Nkw120",
                    Valor =  155,
                    Estoque = 4,
                    IdMarca = 6,
                    Descricao = "O Teclado Nitro TKL te dá espaço suficiente para se movimentar durante os jogos. Bater a mão no teclado nunca mais. MOVIMENTE-SE o Nitro TKL tem menos bordas, o que significa mais espaço na mesa. Faça movimentos bruscos com o mouse sem bater no teclado. E, ainda: aproveite o design compacto para levá-lo para onde quiser. LUZ, CÂMERA, AÇÃO com LED retroiluminado de 3 zonas, quatro níveis de brilho e três modos de iluminação predefinidos, este teclado permite que o player adicione mais luzes e cores para a arena.",
                    ImagemPrincipal = "\\img\\produtos\\13.jpg",
                    IdCategoria = 3,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 13,
                    Nome = "Mousepad Gamer Razer Goliathus Terra",
                    NomeDescricao = "Mousepad Gamer Razer Goliathus Terra, Speed, Médio (355x254mm) - RZ02-01070200-R3M2",
                    Valor =  249,
                    Estoque = 20,
                    IdMarca = 7,
                    Descricao = "O tecido do Razer Goliathus V2 Speed Edition é esticado para criar uma superfície lisa e uniforme, permitindo que o seu mouse de jogo deslize rapidamente e sem dificuldade. O tecido também proporciona uma sensação confortável para o pulso e a mão, minimizando a fadiga durante partidas prolongadas.",
                    ImagemPrincipal = "\\img\\produtos\\14.jpg",
                    IdCategoria = 3,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 14,
                    Nome = "Mouse Gamer Razer Basilisk V2",
                    NomeDescricao = "Mouse Gamer Razer Basilisk V2, Chroma, Optical Switch, 11 Botões, 20000DPI - RZ01-03160100-R3U1",
                    Valor =  399,
                    Estoque = 6,
                    IdMarca = 7,
                    Descricao = "Quem se importa com o que os outros dizem? Defenda seu próprio estilo de jogo com o Razer Basilisk V2. Ajuste, alterne e afine seu desempenho com este mouse gamer altamente personalizável, para criar seu próprio modo de domínio e deixar sua marca no campo de batalha. 11 BOTÕES PROGRAMÁVEIS: Tenha um maior arsenal de comandos na ponta dos seus dedos mapeando suas macros e funções secundárias favoritas com o Razer Synapse 3. Como seu predecessor, o Razer Basilisk V2 inclui a característica palheta multifuncional. RAZER HYPERSHIFT: Extraia o máximo deste mouse programável mapeando seus 11 botões com o Razer Hypershift, um recurso avançado do Razer Synapse 3 que efetivamente duplica os comandos do seu mouse.",
                    ImagemPrincipal = "\\img\\produtos\\15.jpg",
                    IdCategoria = 3,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 15,
                    Nome = "Microfone Razer Seiren Mini",
                    NomeDescricao = "Microfone Razer Seiren Mini, USB, Black - RZ19-03450100-R3U1",
                    Valor =  399,
                    Estoque = 2,
                    IdMarca = 7,
                    Descricao = "Um grande som pode estar contido em uma pequena embalagem. Conheça o Razer Seiren Mini, um microfone condensador ultracompacto perfeito para um áudio de nível profissional com qualquer setup de videochamada ou transmissão. Como este microfone condensador compacto está afinado com um ângulo de captação mais estreito, ele pode focar na sua voz e apresentar uma melhor redução de ruído ambiente, assegurando que os sons de fundo, como o barulho das teclas ou os cliques do mouse, sejam minimizados.",
                    ImagemPrincipal = "\\img\\produtos\\16.jpg",
                    IdCategoria = 3,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 16,
                    Nome = "Fone de Ouvido Bluetooth Razer Hammerhead True Wireless",
                    NomeDescricao = "Fone de Ouvido Bluetooth Razer Hammerhead True Wireless, Recarregável, Resistente a Água - RZ12-02970100-R3U1",
                    Valor =  749,
                    Estoque = 5,
                    IdMarca = 7,
                    Descricao = "Estes fones intra-auriculares sem fio têm uma latência de entrada extremamente baixa de 60 ms, o que significa que o áudio permanece sincronizado com seu dispositivo sem nunca falhar, oferecendo uma vantagem competitiva de jogo e uma experiência mais imersiva para vídeos e música. A verdadeira liberdade sem fio Ouça sem limites e leve os seus lugares de áudio a novos patamares com Razer Hammerhead True Wireless Earbuds e seu desempenho de som perfeito que você pode curtir em qualquer qualidade.",
                    ImagemPrincipal = "\\img\\produtos\\17.jpg",
                    IdCategoria = 3,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 17,
                    Nome = "Mouse Apple Magic 2 Space Gray",
                    NomeDescricao = "Mouse Apple Magic 2 Space Gray -mrme2ll/a",
                    Valor =  1233,
                    Estoque = 1,
                    IdMarca = 8,
                    Descricao = "Agora disponível em cinza-espacial. O Magic Mouse 2 pode ser recarregado e dispensa o uso de pilhas. Ele está mais leve e tem menos peças móveis, graças à bateria interna. A parte inferior com design otimizado e em peça única facilita o controle e os movimentos pela mesa. Além disso, a superfície Multi-Touch permite que você faça movimentos simples como deslizar pelas páginas da web e percorrer documentos. O Magic Mouse 2 já vem pronto para usar e é emparelhado automaticamente com seu Mac.",
                    ImagemPrincipal = "\\img\\produtos\\18.jpg",
                    IdCategoria = 3,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 18,
                    Nome = "Cabo Apple Lightning",
                    NomeDescricao = "Cabo Apple Lightning Para Usb 2m",
                    Valor =  339,
                    Estoque = 10,
                    IdMarca = 8,
                    Descricao = "Cabo Apple Lightning para USB 2M Descrição do Produto: O Cabo Apple Lightning serve para conectar seu iPhone, iPad ou iPod com conector Lightning à porta USB do seu computador. Com ele você sincroniza o dispositivo e carrega a bateria.",
                    ImagemPrincipal = "\\img\\produtos\\19.jpg",
                    IdCategoria = 3,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 19,
                    Nome = "iPhone 11 64GB Preto, 4G, Tela de 6.1",
                    NomeDescricao = "iPhone 11 64GB Preto, 4G, Tela de 6.1, Câmera Dupla 12MP + Selfie 12MP - MHDA3BR/A",
                    Valor =  3989,
                    Estoque = 4,
                    IdMarca = 8,
                    Descricao = "IPhone 11 Apple Tudo na medida certa. Novo sistema de câmera dupla. Bateria que dura o dia todo'. O vidro mais resistente em um smartphone. E o chip mais rápido da Apple. Grave vídeos 4K, faça belos retratos e capture paisagens inteiras com o novo sistema de câmera dupla. Deixe seu dia mais bonito. Impressionante tela Liquid Retina LCD de 6,1 polegadas sem bordas. Bateria para o dia todo. Chip A13 Bionic, o mais rápido em um smartphone. E recarga rápida com carregador de 18W.",
                    ImagemPrincipal = "\\img\\produtos\\20.jpg",
                    IdCategoria = 2,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 20,
                    Nome = "iPhone 13 Pro 128GB Dourado, 5G, Tela de 6.1",
                    NomeDescricao = "iPhone 13 Pro 128GB Dourado, 5G, Tela de 6.1, Câmera Tripla 12MP - MLVC3BZ/A",
                    Valor =  7499,
                    Estoque = 1,
                    IdMarca = 8,
                    Descricao = "O iPhone 13 Pro foi feito para pouca luz. A câmera Wide adiciona uma abertura mais ampla e nosso maior sensor - e aproveita o Scanner LiDAR para retratos no modo Noturno, além da telefoto também capturar imagens com baixa insidencia de luz e contar com zoom ótico 3x ótimo para retratos clássicos ou tirar fotos e vídeos mais nítidos de longe. Ultra Wide obtém uma abertura mais ampla, um sensor mais rápido e um foco automático totalmente novo, ela captura 92% mais luz para melhores fotos e vídeos. .",
                    ImagemPrincipal = "\\img\\produtos\\21.jpg",
                    IdCategoria = 2,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 21,
                    Nome = "Smartphone Positivo Twist 3 Pro S533",
                    NomeDescricao = "Smartphone Positivo Twist 3 Pro S533, 64GB, Grafite, 3G, Quad-Core, 1GB RAM, 5.7?, Câm. 8MP + Selfie 8MP",
                    Valor =   699,
                    Estoque = 12,
                    IdMarca = 13,
                    Descricao = "Tenha um smartphone diferenciado em suas mãos! O Positivo Twist 3 Pro S533 produz fotos com ótima qualidade, pois oferece uma câmera de 8MP na traseira, permitindo que você capte as melhores fotografias. Faça fotos criativas e compartilhe nas redes sociais, através da câmera de selfie de 8MP com flash LED. Sua tela de 5,7 IPS e resolução HD+ oferecem a melhor experiência para você ver seus conteúdos de maneira mais imersiva e com visual impressionante. Com 64GB de armazenamento interno, ele é ideal para guardar suas fotos, músicas ou vídeos!",
                    ImagemPrincipal = "\\img\\produtos\\22.jpg",
                    IdCategoria = 2,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 22,
                    Nome = "Roteador Wireless D-Link WiFi 6 EXO AX1800",
                    NomeDescricao = "Roteador Wireless D-Link WiFi 6 EXO AX1800, 2.4Ghz/5Ghz, Suporte a Google Assistant e Alexa, Preto - DIR-X1860",
                    Valor =   494,
                    Estoque = 6,
                    IdMarca = 4,
                    Descricao = "O Wi-Fi 6 traz a tecnologia Wi-Fi de última geração para sua casa, oferecendo o salto quântico em capacidade, velocidade e alcance necessários para lidar com todas as suas demandas de Wi-Fi. Perfeito para casas inteligentes de alto desempenho e densas para dispositivos. Experimente velocidades de até AX1800, enquanto o 1024-QAM aumenta a taxa de transferência para dispositivos em até 25% e a largura de canal contígua de 80 MHz fornece ainda mais largura de banda. Até 4 fluxos simultâneos permitem que você desfrute de streaming 4K mais rápido e agradável, jogos on-line e muito mais, e se precisar deles - 4 portas LAN Gigabit e 1 porta WAN Gigabit oferecem conectividade com fio mais rápida sempre que desejar.",
                    ImagemPrincipal = "\\img\\produtos\\23.jpg",
                    IdCategoria = 6,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 23,
                    Nome = "Volante de Jogos NOX Krom K-Wheel",
                    NomeDescricao = "Volante de Jogos NOX Krom K-Wheel para PS4, PS3, Xbox One, PC - NXKROMKWHL",
                    Valor =   349,
                    Estoque = 2,
                    IdMarca = 15,
                    Descricao = "K-Wheel é um volante e conjunto de pedais otimizado para todos os tipos de jogos de corrida, que surgiu para oferecer-lhe máxima segurança e controlo, mesmo nas manobras mais extremas. Experimente a adrenalina dos pilotos de corrida a partir do seu ecrã graças a esta configuração de condução completa.",
                    ImagemPrincipal = "\\img\\produtos\\24.jpg",
                    IdCategoria = 4,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 24,
                    Nome = "Câmbio Logitech G Driving Force",
                    NomeDescricao = "Câmbio Logitech G Driving Force, Compatível com Volantes Logitech G923, G29 e G920 para PS5, PS4, Xbox Series X|S, Xbox One, PC - 941-000119",
                    Valor =   389,
                    Estoque = 3,
                    IdMarca = 15,
                    Descricao = "Otimize a sua experiência de corrida com uma ação de mudança de marcha realista. O câmbio Driving Force da Logitech é o melhor câmbio de simulação do mercado, projetado para os volantes de corrida Driving Force G29, G920 e G923. Com sólidos eixos de engrenagem de aço e couro costurado à mão de alta qualidade, o Driving Force foi construído para corridas de precisão e confiabilidade duradoura.",
                    ImagemPrincipal = "\\img\\produtos\\25.jpg",
                    IdCategoria = 4,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 25,
                    Nome = "Smart TV LG 43 4K UHD 43UP7500",
                    NomeDescricao = "Smart TV LG 43 4K UHD 43UP7500, com WiFi e Bluetooth, HDR, ThinQAI Compatível com Inteligência Artificial - 43UP7500PSF",
                    Valor =   2149,
                    Estoque = 1,
                    IdMarca = 16,
                    Descricao = "Real TV LG 4K UHD Imersão Surreal A Smart TVs LG UHD sempre superam as expectativas. Experimente qualidade de imagem realista e cores vivas com quatro vezes mais precisão de pixels do que em Full HD. Desempenho arrasador garantido. Leve o cinema para casa. FILMMAKER MODE, HDR proporcionam uma experiência de visualização mais imersiva. Fique conectado com sua plataforma de streaming preferida para acessar o conteúdo que você adora. Todos os seus apps favoritos em um só lugar Acesse Netflix, Disney+, aplicativo Apple TV e Amazon prime video. Escolha entre os mais recentes filmes, programas de TV, documentários e esportes ao vivo e encontre todos eles em um só lugar, na sua Smart TV LG.",
                    ImagemPrincipal = "\\img\\produtos\\26.jpg",
                    IdCategoria = 7,
                    ExibirHome = false
                },
                new Produto(){
                    Id = 26,
                    Nome = "Smart TV LED 43 Full HD Sony",
                    NomeDescricao = "Smart TV LG 43 4K UHD 43UP7500, com WiFi e Bluetooth, HDR, ThinQAI Compatível com Inteligência Artificial - 43UP7500PSF",
                    Valor =   2800,
                    Estoque = 2,
                    IdMarca = 14,
                    Descricao = "Conheça a linha de TVs Smart e Durável da Sony! A KDL-43W665F foi cuidadosamente desenvolvida para oferecer maior segurança e durabilidade. Graças à tecnologia X-Protection PRO sua TV traz mais proteção contra poeira, umidade, raios e surtos de tensão. Com a função SmartTV você tem acesso aos melhores conteúdos da Internet, e o melhor, você decide quando quer assistir.",
                    ImagemPrincipal = "\\img\\produtos\\27.jpg",
                    IdCategoria = 7,
                    ExibirHome = false
                }
            };
            modelBuilder.Entity<Produto>().HasData(produtos);
            #endregion

            #region Populate Carroseis
            var imagemSite = new List<ImagemSite>(){
               new ImagemSite()
                {
                    Id = 1,
                    Img = "\\img\\carrosel\\01.jpg",
                    Ordem = 1,
                    Carrosel = true,
                    Secundaria = false
                },
                new ImagemSite()
                {
                    Id = 2,
                    Img = "\\img\\carrosel\\02.jpg",
                    Ordem = 2,
                    Carrosel = true,
                    Secundaria = false
                },
                new ImagemSite()
                {
                    Id = 3,
                    Img = "\\img\\carrosel\\04.png",
                    Ordem = 2,
                    Carrosel = false,
                    Secundaria = true
                },
                new ImagemSite()
                {
                    Id = 4,
                    Img = "\\img\\carrosel\\05.png",
                    Ordem = 2,
                    Carrosel = false,
                    Secundaria = true
                }
            };
            modelBuilder.Entity<ImagemSite>().HasData(imagemSite);
            #endregion
        }

    }
}