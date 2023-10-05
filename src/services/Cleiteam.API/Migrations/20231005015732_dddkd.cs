using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cleiteam.API.Migrations
{
    /// <inheritdoc />
    public partial class dddkd : Migration
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
                name: "Ocorrencias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoOcorrencia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_Ocorrencias_TiposOcorrencia_IdTipoOcorrencia",
                        column: x => x.IdTipoOcorrencia,
                        principalTable: "TiposOcorrencia",
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
                name: "IX_Ocorrencias_IdTipoOcorrencia",
                table: "Ocorrencias",
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
                name: "TiposOcorrencia");
        }
    }
}
