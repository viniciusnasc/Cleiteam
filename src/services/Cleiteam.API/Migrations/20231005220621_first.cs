using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cleiteam.API.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposOcorrencia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(50)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposOcorrencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioConfiguracoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Alcance = table.Column<int>(type: "int", nullable: false),
                    ReceberNotificacao = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioConfiguracoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubtiposOcorrencia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    IdTipoOcorrencia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubtiposOcorrencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubtiposOcorrencia_TiposOcorrencia_IdTipoOcorrencia",
                        column: x => x.IdTipoOcorrencia,
                        principalTable: "TiposOcorrencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocorrencias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSubtipoOcorrencia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    Longitude = table.Column<decimal>(type: "Decimal(9,6)", nullable: false),
                    Latitude = table.Column<decimal>(type: "Decimal(8,6)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocorrencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ocorrencias_SubtiposOcorrencia_IdSubtipoOcorrencia",
                        column: x => x.IdSubtipoOcorrencia,
                        principalTable: "SubtiposOcorrencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImagensOcorrencia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdOcorrencia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeArquivo = table.Column<string>(type: "varchar(200)", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagensOcorrencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagensOcorrencia_Ocorrencias_IdOcorrencia",
                        column: x => x.IdOcorrencia,
                        principalTable: "Ocorrencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImagensOcorrencia_UsuarioConfiguracoes_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "UsuarioConfiguracoes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UsuarioOcorrencias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdOcorrencia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Responsavel = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioOcorrencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioOcorrencias_Ocorrencias_IdOcorrencia",
                        column: x => x.IdOcorrencia,
                        principalTable: "Ocorrencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioOcorrencias_UsuarioConfiguracoes_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "UsuarioConfiguracoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComentariosImagem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdImagem = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comentario = table.Column<string>(type: "varchar(300)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentariosImagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComentariosImagem_ImagensOcorrencia_IdImagem",
                        column: x => x.IdImagem,
                        principalTable: "ImagensOcorrencia",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ComentariosImagem_UsuarioConfiguracoes_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "UsuarioConfiguracoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TiposOcorrencia",
                columns: new[] { "Id", "DataCriacao", "DataEdicao", "Descricao" },
                values: new object[,]
                {
                    { new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea0"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5323), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5323), "Iluminação Pública" },
                    { new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea1"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5327), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5327), "Estradas e Tráfego" },
                    { new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea2"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5329), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5330), "Transporte Público" },
                    { new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea3"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5371), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5371), "Coleta de Lixo e Reciclagem" },
                    { new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea4"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5374), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5374), "Manutenção de Parques e Praças" },
                    { new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea5"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5376), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5376), "Abastecimento de Água" },
                    { new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea6"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5378), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5379), "Saneamento Básica" },
                    { new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea7"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5381), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5381), "Serviços de Emergência" },
                    { new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea8"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5383), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5383), "Serviços de Saúde" },
                    { new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea9"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5385), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5385), "Assistência Social" },
                    { new Guid("b8e6cd20-4268-4218-9abb-792c2b979ea0"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5387), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5387), "Atendimento ao Cliente" },
                    { new Guid("b8e6cd20-4268-4228-9abb-792c2b979ea0"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5393), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5393), "Questões Ambientais" },
                    { new Guid("b8e6cd20-4268-4238-9abb-792c2b979ea0"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5395), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5395), "Problemas de Segurança" },
                    { new Guid("b8e6cd20-4268-4248-9abb-792c2b979ea0"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5397), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5397), "Outras Preocupações Cidadãs" }
                });

            migrationBuilder.InsertData(
                table: "SubtiposOcorrencia",
                columns: new[] { "Id", "DataCriacao", "DataEdicao", "Descricao", "IdTipoOcorrencia" },
                values: new object[,]
                {
                    { new Guid("04519d3e-d29f-420c-ba09-fd9f286d0019"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5664), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5664), "Problemas com transporte de animais de estimação ou controle de pragas", new Guid("b8e6cd20-4268-4248-9abb-792c2b979ea0") },
                    { new Guid("0a2615af-e5b8-45e4-9216-afe540aa2080"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5543), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5544), "Lâmpadas de rua queimadas ou piscando", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea0") },
                    { new Guid("0b3747d3-b3af-4d7c-aeb0-3903dbfed9fa"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5621), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5621), "Problemas nos hospitais públicos ou clínicas de saúde", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea8") },
                    { new Guid("1db69d2b-d644-45bf-b169-1e3ef30ce669"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5609), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5609), "Iluminação Pública", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea7") },
                    { new Guid("248899f6-faae-47ca-83c7-91c53174cff1"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5602), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5602), "Entupimentos ou refluxo de esgoto", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea6") },
                    { new Guid("25fd807c-3c13-4a57-a3e1-87a34b439c3f"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5661), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5661), "Falta de estacionamento público", new Guid("b8e6cd20-4268-4248-9abb-792c2b979ea0") },
                    { new Guid("299edddf-c040-42c4-a2a5-c220285ec77f"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5647), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5647), "Descarte inadequado de resíduos", new Guid("b8e6cd20-4268-4228-9abb-792c2b979ea0") },
                    { new Guid("29c51f6a-3363-491b-9858-3fa5c5b40034"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5575), "Recipientes de reciclagem danificados", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea3") },
                    { new Guid("2ca9d8fa-67f1-4fd1-a06c-173dbf94112a"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5568), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5569), "Outros", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea2") },
                    { new Guid("34460679-2f95-49fd-bb28-274416265c4a"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5597), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5597), "Outros", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea5") },
                    { new Guid("39fc1183-0f69-4ae5-adb4-acdcba4fe475"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5566), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5566), "Veículos sujos ou danificados", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea2") },
                    { new Guid("43c5c10a-5239-4a0a-8052-413717ada3b6"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5605), "Outros", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea6") },
                    { new Guid("45d7330a-8fd7-469e-8cd8-c69a3b58e511"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5623), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5623), "Falhas na distribuição de vacinas ou medicamentos", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea8") },
                    { new Guid("4914af6f-0274-44db-a383-eb5d25dbc613"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5551), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5551), "Buracos nas estradas", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea1") },
                    { new Guid("534cf056-bffb-4075-a9d1-d0595355b488"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5635), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5635), "Dificuldades para entrar em contato com os órgãos governamentais", new Guid("b8e6cd20-4268-4218-9abb-792c2b979ea0") },
                    { new Guid("6fd22df9-f109-4b92-bb0e-f852b851203b"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5632), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5633), "Outros", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea9") },
                    { new Guid("70063257-58b7-4c8a-aecf-77b7993cb9f9"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5561), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5561), "Outros", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea1") },
                    { new Guid("72068216-3282-4987-920b-0548a19f0b60"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5640), "Outros", new Guid("b8e6cd20-4268-4218-9abb-792c2b979ea0") },
                    { new Guid("7490eaca-d535-400f-a009-a5ec6f50278f"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5554), "Sinalização inadequada ou ausente", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea1") },
                    { new Guid("77847aaa-ca33-400d-b8af-8168e7e75ed9"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5638), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5638), "Respostas lentas a reclamações ou pedidos de assistência", new Guid("b8e6cd20-4268-4218-9abb-792c2b979ea0") },
                    { new Guid("78c4fbb9-87e7-41d1-af0c-7a9a0a77088b"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5656), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5656), "Necessidade de melhorias na iluminação de áreas públicas para a segurança dos cidadãos", new Guid("b8e6cd20-4268-4228-9abb-792c2b979ea0") },
                    { new Guid("8639e4d9-f83a-4720-b5ae-f74f44becdcb"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5572), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5573), "Coleta irregular de lixo", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea3") },
                    { new Guid("8a5ee411-cc9d-4378-ac63-f62cf98f8c19"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5611), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5612), "Postes de luz danificados", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea7") },
                    { new Guid("9265cb6b-99e4-4cde-a0b0-71da22826c6a"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5652), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5652), "Zonas perigosas ou locais com alto índice de criminalidade", new Guid("b8e6cd20-4268-4238-9abb-792c2b979ea0") },
                    { new Guid("9539eb44-58e7-4859-a473-ccc697dfb936"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5563), "Atrasos ou interrupções nos serviços de transporte público", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea2") },
                    { new Guid("9dbc7775-30a4-4617-a819-2dd83b617352"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5578), "Outros", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea3") },
                    { new Guid("aa8e02e3-9058-4882-ad4b-0ee77dc6fa2c"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5599), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5600), "Problemas com esgoto ou drenagem", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea6") },
                    { new Guid("aca339be-bdc7-4d97-8dfc-043656a87e93"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5614), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5614), "Lâmpadas de rua queimadas ou piscando", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea7") },
                    { new Guid("b876255c-72d5-4db3-b45f-492423d4a00b"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5628), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5629), "Problemas com abrigos ou programas de assistência a pessoas em situação de rua", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea9") },
                    { new Guid("b963c996-012c-47b6-b981-7d0d9699919d"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5644), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5645), "Poluição do ar ou da água", new Guid("b8e6cd20-4268-4228-9abb-792c2b979ea0") },
                    { new Guid("bafa9694-3040-461f-9182-48313619f535"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5581), "Postes de luz danificados", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea4") },
                    { new Guid("bfcd1553-3de2-43ef-af73-ddf959c174b7"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5616), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5617), "Outros", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea7") },
                    { new Guid("c180b287-273d-4117-b704-d66591932017"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5626), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5626), "Outros", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea8") },
                    { new Guid("c83d5e61-33ba-4007-8260-bcee4169c9e9"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5548), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5549), "Outros", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea0") },
                    { new Guid("d15ee95e-3219-48f7-bbea-1f6363cc8fca"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5659), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5659), "Ruído excessivo", new Guid("b8e6cd20-4268-4248-9abb-792c2b979ea0") },
                    { new Guid("d1883cf6-34d4-4603-8887-4de4b406e9a3"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5556), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5557), "Problemas de congestionamento de tráfego", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea1") },
                    { new Guid("d32a6fb7-1342-40f4-bb3a-68684e3276ee"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5668), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5668), "Outros", new Guid("b8e6cd20-4268-4248-9abb-792c2b979ea0") },
                    { new Guid("d4c19a09-4d9c-40eb-a8dd-6c4d7b760081"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5649), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5650), "Outros", new Guid("b8e6cd20-4268-4228-9abb-792c2b979ea0") },
                    { new Guid("ded0d718-fc97-4c37-bff1-c4740e783fe5"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5590), "Vazamentos de água visíveis", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea5") },
                    { new Guid("e4e12ea1-3f8b-4caa-ad22-42aebc37a497"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5539), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5540), "Postes de luz danificados", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea0") },
                    { new Guid("e5649d5a-6031-41aa-82e5-e2793dbaa32c"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5592), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5593), "Problemas com o abastecimento de água potável", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea5") },
                    { new Guid("f50800e7-6d70-4b5b-82b0-831a16ea5786"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5587), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5587), "Outros", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea4") },
                    { new Guid("fbdac80a-c37b-4731-91f7-86e5eca7a73f"), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5584), new DateTime(2023, 10, 5, 19, 6, 21, 712, DateTimeKind.Local).AddTicks(5585), "Lampadas de rua queimadas ou piscando", new Guid("b8e6cd20-4268-4208-9abb-792c2b979ea4") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComentariosImagem_IdImagem",
                table: "ComentariosImagem",
                column: "IdImagem");

            migrationBuilder.CreateIndex(
                name: "IX_ComentariosImagem_IdUsuario",
                table: "ComentariosImagem",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ImagensOcorrencia_IdOcorrencia",
                table: "ImagensOcorrencia",
                column: "IdOcorrencia");

            migrationBuilder.CreateIndex(
                name: "IX_ImagensOcorrencia_IdUsuario",
                table: "ImagensOcorrencia",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencias_IdSubtipoOcorrencia",
                table: "Ocorrencias",
                column: "IdSubtipoOcorrencia");

            migrationBuilder.CreateIndex(
                name: "IX_SubtiposOcorrencia_IdTipoOcorrencia",
                table: "SubtiposOcorrencia",
                column: "IdTipoOcorrencia");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioOcorrencias_IdOcorrencia",
                table: "UsuarioOcorrencias",
                column: "IdOcorrencia");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioOcorrencias_IdUsuario",
                table: "UsuarioOcorrencias",
                column: "IdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComentariosImagem");

            migrationBuilder.DropTable(
                name: "UsuarioOcorrencias");

            migrationBuilder.DropTable(
                name: "ImagensOcorrencia");

            migrationBuilder.DropTable(
                name: "Ocorrencias");

            migrationBuilder.DropTable(
                name: "UsuarioConfiguracoes");

            migrationBuilder.DropTable(
                name: "SubtiposOcorrencia");

            migrationBuilder.DropTable(
                name: "TiposOcorrencia");
        }
    }
}
