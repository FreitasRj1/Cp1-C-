using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaEFCore.App.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RM550187_FORNECEDOR",
                columns: table => new
                {
                    idFornecedor = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nrCEP = table.Column<string>(type: "NVARCHAR2(9)", maxLength: 9, nullable: false),
                    dsEndereco = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Estado = table.Column<string>(type: "NVARCHAR2(2)", maxLength: 2, nullable: false),
                    Cidade = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM550187_FORNECEDOR", x => x.idFornecedor);
                });

            migrationBuilder.CreateTable(
                name: "RM550187_PEDIDO",
                columns: table => new
                {
                    idPedido = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    dataPedido = table.Column<DateTime>(type: "DATE", nullable: false),
                    valorTotal = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM550187_PEDIDO", x => x.idPedido);
                });

            migrationBuilder.CreateTable(
                name: "RM550187_PRODUTO",
                columns: table => new
                {
                    idProduto = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nmProduto = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false),
                    preco = table.Column<decimal>(type: "DECIMAL(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM550187_PRODUTO", x => x.idProduto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RM550187_FORNECEDOR");

            migrationBuilder.DropTable(
                name: "RM550187_PEDIDO");

            migrationBuilder.DropTable(
                name: "RM550187_PRODUTO");
        }
    }
}
