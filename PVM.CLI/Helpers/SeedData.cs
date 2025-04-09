using Microsoft.EntityFrameworkCore;
using PVM.CLI.DataAccess.Entities;

namespace PVM.CLI.Helpers;

public static class SeedData
{

    public static void GenerateSeed(this ModelBuilder modelBuilder)
    {
        
        var employee = new[]
        {

            new Employee { EmployeeNumber = 1, FullName = "Lucas Martínez", Department = "Sales", DateOfBirth = new DateTime(1995, 6, 6), Age = 29, PhoneNumber = "69845101" },
            new Employee { EmployeeNumber = 2, FullName = "María López", Department = "HR", DateOfBirth = new DateTime(1990, 2, 15), Age = 34, PhoneNumber = "69845102" },
            new Employee { EmployeeNumber = 3, FullName = "Diego Sánchez", Department = "IT", DateOfBirth = new DateTime(1988, 11, 23), Age = 36, PhoneNumber = "69845103" },
            new Employee { EmployeeNumber = 4, FullName = "Sofía González", Department = "Marketing", DateOfBirth = new DateTime(1995, 4, 2), Age = 29, PhoneNumber = "69845104" },
            new Employee { EmployeeNumber = 5, FullName = "Mateo Romero", Department = "Finance", DateOfBirth = new DateTime(1992, 9, 9), Age = 32, PhoneNumber = "69845105" },
            new Employee { EmployeeNumber = 6, FullName = "Valentina Herrera", Department = "Sales", DateOfBirth = new DateTime(1987, 12, 5), Age = 37, PhoneNumber = "69845106" },
            new Employee { EmployeeNumber = 7, FullName = "Tomás Ortega", Department = "HR", DateOfBirth = new DateTime(1994, 3, 17), Age = 30, PhoneNumber = "69845107" },
            new Employee { EmployeeNumber = 8, FullName = "Emma Jiménez", Department = "IT", DateOfBirth = new DateTime(1996, 5, 12), Age = 28, PhoneNumber = "69845108" },
            new Employee { EmployeeNumber = 9, FullName = "Daniel Ruiz", Department = "Marketing", DateOfBirth = new DateTime(1991, 7, 1), Age = 33, PhoneNumber = "69845109" },
            new Employee { EmployeeNumber = 10, FullName = "Isabella Castro", Department = "Finance", DateOfBirth = new DateTime(1989, 1, 26), Age = 35, PhoneNumber = "69845110" },


            new Employee { EmployeeNumber = 11, FullName = "Gabriel Navarro", Department = "Sales", DateOfBirth = new DateTime(1993, 8, 8), Age = 31, PhoneNumber = "69845111" },
            new Employee { EmployeeNumber = 12, FullName = "Camila Paredes", Department = "HR", DateOfBirth = new DateTime(1992, 5, 19), Age = 32, PhoneNumber = "69845112" },
            new Employee { EmployeeNumber = 13, FullName = "Andrés Molina", Department = "IT", DateOfBirth = new DateTime(1990, 12, 13), Age = 34, PhoneNumber = "69845113" },
            new Employee { EmployeeNumber = 14, FullName = "Valeria Aguirre", Department = "Marketing", DateOfBirth = new DateTime(1996, 7, 30), Age = 28, PhoneNumber = "69845114" },
            new Employee { EmployeeNumber = 15, FullName = "Sebastián Vera", Department = "Finance", DateOfBirth = new DateTime(1995, 9, 22), Age = 29, PhoneNumber = "69845115" },
            new Employee { EmployeeNumber = 16, FullName = "Paula Rivas", Department = "Sales", DateOfBirth = new DateTime(1994, 11, 1), Age = 30, PhoneNumber = "69845116" },
            new Employee { EmployeeNumber = 17, FullName = "Julián Vargas", Department = "HR", DateOfBirth = new DateTime(1991, 4, 5), Age = 33, PhoneNumber = "69845117" },
            new Employee { EmployeeNumber = 18, FullName = "Renata Salas", Department = "IT", DateOfBirth = new DateTime(1989, 1, 9), Age = 35, PhoneNumber = "69845118" },
            new Employee { EmployeeNumber = 19, FullName = "Martín Peña", Department = "Marketing", DateOfBirth = new DateTime(1988, 10, 28), Age = 36, PhoneNumber = "69845119" },
            new Employee { EmployeeNumber = 20, FullName = "Antonella Cabrera", Department = "Finance", DateOfBirth = new DateTime(1997, 3, 17), Age = 27, PhoneNumber = "69845120" },
            new Employee { EmployeeNumber = 21, FullName = "Nicolás Castillo", Department = "Sales", DateOfBirth = new DateTime(1990, 8, 2), Age = 34, PhoneNumber = "69845121" },
            new Employee { EmployeeNumber = 22, FullName = "Victoria Ferrer", Department = "HR", DateOfBirth = new DateTime(1993, 5, 14), Age = 31, PhoneNumber = "69845122" },
            new Employee { EmployeeNumber = 23, FullName = "Matías Rojas", Department = "IT", DateOfBirth = new DateTime(1995, 2, 26), Age = 29, PhoneNumber = "69845123" },
            new Employee { EmployeeNumber = 24, FullName = "Florencia Muñoz", Department = "Marketing", DateOfBirth = new DateTime(1994, 9, 12), Age = 30, PhoneNumber = "69845124" },
            new Employee { EmployeeNumber = 25, FullName = "Benjamín Soto", Department = "Finance", DateOfBirth = new DateTime(1992, 7, 3), Age = 32, PhoneNumber = "69845125" },
            new Employee { EmployeeNumber = 26, FullName = "Julieta Morales", Department = "Sales", DateOfBirth = new DateTime(1989, 5, 15), Age = 35, PhoneNumber = "69845126" },
            new Employee { EmployeeNumber = 27, FullName = "Facundo Delgado", Department = "HR", DateOfBirth = new DateTime(1987, 3, 21), Age = 37, PhoneNumber = "69845127" },
            new Employee { EmployeeNumber = 28, FullName = "Agustina Vargas", Department = "IT", DateOfBirth = new DateTime(1991, 11, 8), Age = 33, PhoneNumber = "69845128" },
            new Employee { EmployeeNumber = 29, FullName = "Santiago Carrillo", Department = "Marketing", DateOfBirth = new DateTime(1996, 4, 25), Age = 28, PhoneNumber = "69845129" },
            new Employee { EmployeeNumber = 30, FullName = "Josefina Duarte", Department = "Finance", DateOfBirth = new DateTime(1990, 2, 10), Age = 34, PhoneNumber = "69845130" },
            new Employee { EmployeeNumber = 31, FullName = "Maximiliano Arias", Department = "Sales", DateOfBirth = new DateTime(1995, 6, 3), Age = 29, PhoneNumber = "69845131" },
            new Employee { EmployeeNumber = 32, FullName = "Lucía Sánchez", Department = "HR", DateOfBirth = new DateTime(1992, 12, 15), Age = 32, PhoneNumber = "69845132" },
            new Employee { EmployeeNumber = 33, FullName = "Bruno Cortés", Department = "IT", DateOfBirth = new DateTime(1988, 9, 30), Age = 36, PhoneNumber = "69845133" },
            new Employee { EmployeeNumber = 34, FullName = "Abril Guerrero", Department = "Marketing", DateOfBirth = new DateTime(1993, 5, 18), Age = 31, PhoneNumber = "69845134" },
            new Employee { EmployeeNumber = 35, FullName = "Emilia Ponce", Department = "Finance", DateOfBirth = new DateTime(1994, 8, 5), Age = 30, PhoneNumber = "69845135" },
            new Employee { EmployeeNumber = 36, FullName = "Joaquín Roldán", Department = "Sales", DateOfBirth = new DateTime(1991, 6, 1), Age = 33, PhoneNumber = "69845136" },
            new Employee { EmployeeNumber = 37, FullName = "Catalina Rivera", Department = "HR", DateOfBirth = new DateTime(1989, 11, 22), Age = 35, PhoneNumber = "69845137" },
            new Employee { EmployeeNumber = 38, FullName = "Pedro Domínguez", Department = "IT", DateOfBirth = new DateTime(1987, 7, 14), Age = 37, PhoneNumber = "69845138" },
            new Employee { EmployeeNumber = 39, FullName = "Carla Villalba", Department = "Marketing", DateOfBirth = new DateTime(1992, 4, 11), Age = 32, PhoneNumber = "69845139" },
            new Employee { EmployeeNumber = 40, FullName = "Esteban Sosa", Department = "Finance", DateOfBirth = new DateTime(1990, 9, 9), Age = 34, PhoneNumber = "69845140" },
            new Employee { EmployeeNumber = 41, FullName = "Mía Cordero", Department = "Sales", DateOfBirth = new DateTime(1996, 2, 28), Age = 28, PhoneNumber = "69845141" },
            new Employee { EmployeeNumber = 42, FullName = "Agustín Leiva", Department = "HR", DateOfBirth = new DateTime(1995, 5, 23), Age = 29, PhoneNumber = "69845142" },
            new Employee { EmployeeNumber = 43, FullName = "Julia Campos", Department = "IT", DateOfBirth = new DateTime(1993, 3, 17), Age = 31, PhoneNumber = "69845143" },
            new Employee { EmployeeNumber = 44, FullName = "Franco Cabrera", Department = "Marketing", DateOfBirth = new DateTime(1989, 12, 26), Age = 35, PhoneNumber = "69845144" },
            new Employee { EmployeeNumber = 45, FullName = "Gabriela Cruz", Department = "Finance", DateOfBirth = new DateTime(1991, 1, 6), Age = 33, PhoneNumber = "69845145" },
            new Employee { EmployeeNumber = 46, FullName = "Leonardo Paredes", Department = "Sales", DateOfBirth = new DateTime(1988, 7, 7), Age = 36, PhoneNumber = "69845146" },
            new Employee { EmployeeNumber = 47, FullName = "Daniela Méndez", Department = "HR", DateOfBirth = new DateTime(1992, 2, 14), Age = 32, PhoneNumber = "69845147" },
            new Employee { EmployeeNumber = 48, FullName = "Alejandro Ríos", Department = "IT", DateOfBirth = new DateTime(1995, 10, 3), Age = 29, PhoneNumber = "69845148" },
            new Employee { EmployeeNumber = 49, FullName = "Bianca Espinoza", Department = "Marketing", DateOfBirth = new DateTime(1994, 11, 27), Age = 30, PhoneNumber = "69845149" },
            new Employee { EmployeeNumber = 50, FullName = "Cristian Mendoza", Department = "Finance", DateOfBirth = new DateTime(1990, 8, 19), Age = 34, PhoneNumber = "69845150" },
            new Employee { EmployeeNumber = 51, FullName = "Fernanda Ramos", Department = "Sales", DateOfBirth = new DateTime(1989, 3, 15), Age = 35, PhoneNumber = "69845151" },
            new Employee { EmployeeNumber = 52, FullName = "Patricio Silva", Department = "HR", DateOfBirth = new DateTime(1987, 5, 1), Age = 37, PhoneNumber = "69845152" },
            new Employee { EmployeeNumber = 53, FullName = "Malena Cáceres", Department = "IT", DateOfBirth = new DateTime(1996, 6, 18), Age = 28, PhoneNumber = "69845153" },
            new Employee { EmployeeNumber = 54, FullName = "Gonzalo Beltrán", Department = "Marketing", DateOfBirth = new DateTime(1993, 9, 10), Age = 31, PhoneNumber = "69845154" },
            new Employee { EmployeeNumber = 55, FullName = "Romina Palma", Department = "Finance", DateOfBirth = new DateTime(1991, 2, 2), Age = 33, PhoneNumber = "69845155" },
            new Employee { EmployeeNumber = 56, FullName = "Ignacio Cifuentes", Department = "Sales", DateOfBirth = new DateTime(1988, 4, 29), Age = 36, PhoneNumber = "69845156" },
            new Employee { EmployeeNumber = 57, FullName = "Pilar Olivares", Department = "HR", DateOfBirth = new DateTime(1994, 12, 4), Age = 30, PhoneNumber = "69845157" },
            new Employee { EmployeeNumber = 58, FullName = "Mauricio Parra", Department = "IT", DateOfBirth = new DateTime(1992, 3, 1), Age = 32, PhoneNumber = "69845158" },
            new Employee { EmployeeNumber = 59, FullName = "Bárbara Solís", Department = "Marketing", DateOfBirth = new DateTime(1990, 5, 16), Age = 34, PhoneNumber = "69845159" },
            new Employee { EmployeeNumber = 60, FullName = "Rodrigo Fuentes", Department = "Finance", DateOfBirth = new DateTime(1987, 10, 24), Age = 37, PhoneNumber = "69845160" }

        };


        modelBuilder.Entity<Employee>().HasData(employee);

    }

}