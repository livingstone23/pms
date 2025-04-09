using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PVM.CLI.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeNumber", "Age", "DateOfBirth", "Department", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 29, new DateTime(1995, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Lucas Martínez", "69845101" },
                    { 2, 34, new DateTime(1990, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "María López", "69845102" },
                    { 3, 36, new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Diego Sánchez", "69845103" },
                    { 4, 29, new DateTime(1995, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Sofía González", "69845104" },
                    { 5, 32, new DateTime(1992, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Mateo Romero", "69845105" },
                    { 6, 37, new DateTime(1987, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Valentina Herrera", "69845106" },
                    { 7, 30, new DateTime(1994, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Tomás Ortega", "69845107" },
                    { 8, 28, new DateTime(1996, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Emma Jiménez", "69845108" },
                    { 9, 33, new DateTime(1991, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Daniel Ruiz", "69845109" },
                    { 10, 35, new DateTime(1989, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Isabella Castro", "69845110" },
                    { 11, 31, new DateTime(1993, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Gabriel Navarro", "69845111" },
                    { 12, 32, new DateTime(1992, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Camila Paredes", "69845112" },
                    { 13, 34, new DateTime(1990, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Andrés Molina", "69845113" },
                    { 14, 28, new DateTime(1996, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Valeria Aguirre", "69845114" },
                    { 15, 29, new DateTime(1995, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Sebastián Vera", "69845115" },
                    { 16, 30, new DateTime(1994, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Paula Rivas", "69845116" },
                    { 17, 33, new DateTime(1991, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Julián Vargas", "69845117" },
                    { 18, 35, new DateTime(1989, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Renata Salas", "69845118" },
                    { 19, 36, new DateTime(1988, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Martín Peña", "69845119" },
                    { 20, 27, new DateTime(1997, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Antonella Cabrera", "69845120" },
                    { 21, 34, new DateTime(1990, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Nicolás Castillo", "69845121" },
                    { 22, 31, new DateTime(1993, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Victoria Ferrer", "69845122" },
                    { 23, 29, new DateTime(1995, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Matías Rojas", "69845123" },
                    { 24, 30, new DateTime(1994, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Florencia Muñoz", "69845124" },
                    { 25, 32, new DateTime(1992, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Benjamín Soto", "69845125" },
                    { 26, 35, new DateTime(1989, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Julieta Morales", "69845126" },
                    { 27, 37, new DateTime(1987, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Facundo Delgado", "69845127" },
                    { 28, 33, new DateTime(1991, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Agustina Vargas", "69845128" },
                    { 29, 28, new DateTime(1996, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Santiago Carrillo", "69845129" },
                    { 30, 34, new DateTime(1990, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Josefina Duarte", "69845130" },
                    { 31, 29, new DateTime(1995, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Maximiliano Arias", "69845131" },
                    { 32, 32, new DateTime(1992, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Lucía Sánchez", "69845132" },
                    { 33, 36, new DateTime(1988, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Bruno Cortés", "69845133" },
                    { 34, 31, new DateTime(1993, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Abril Guerrero", "69845134" },
                    { 35, 30, new DateTime(1994, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Emilia Ponce", "69845135" },
                    { 36, 33, new DateTime(1991, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Joaquín Roldán", "69845136" },
                    { 37, 35, new DateTime(1989, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Catalina Rivera", "69845137" },
                    { 38, 37, new DateTime(1987, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Pedro Domínguez", "69845138" },
                    { 39, 32, new DateTime(1992, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Carla Villalba", "69845139" },
                    { 40, 34, new DateTime(1990, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Esteban Sosa", "69845140" },
                    { 41, 28, new DateTime(1996, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Mía Cordero", "69845141" },
                    { 42, 29, new DateTime(1995, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Agustín Leiva", "69845142" },
                    { 43, 31, new DateTime(1993, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Julia Campos", "69845143" },
                    { 44, 35, new DateTime(1989, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Franco Cabrera", "69845144" },
                    { 45, 33, new DateTime(1991, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Gabriela Cruz", "69845145" },
                    { 46, 36, new DateTime(1988, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Leonardo Paredes", "69845146" },
                    { 47, 32, new DateTime(1992, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Daniela Méndez", "69845147" },
                    { 48, 29, new DateTime(1995, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Alejandro Ríos", "69845148" },
                    { 49, 30, new DateTime(1994, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Bianca Espinoza", "69845149" },
                    { 50, 34, new DateTime(1990, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Cristian Mendoza", "69845150" },
                    { 51, 35, new DateTime(1989, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Fernanda Ramos", "69845151" },
                    { 52, 37, new DateTime(1987, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Patricio Silva", "69845152" },
                    { 53, 28, new DateTime(1996, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Malena Cáceres", "69845153" },
                    { 54, 31, new DateTime(1993, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Gonzalo Beltrán", "69845154" },
                    { 55, 33, new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Romina Palma", "69845155" },
                    { 56, 36, new DateTime(1988, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Ignacio Cifuentes", "69845156" },
                    { 57, 30, new DateTime(1994, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", "Pilar Olivares", "69845157" },
                    { 58, 32, new DateTime(1992, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Mauricio Parra", "69845158" },
                    { 59, 34, new DateTime(1990, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Bárbara Solís", "69845159" },
                    { 60, 37, new DateTime(1987, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Rodrigo Fuentes", "69845160" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeNumber",
                keyValue: 60);
        }
    }
}
