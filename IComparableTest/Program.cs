using IComparableTest.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace IComparableTest {
    class Program {
        static void Main(string[] args) {
            //Faça um programa para ler um arquivo contendo funcionários(nome e salário) no
            //formato.csv, armazenando - os em uma lista.Depois, ordenar a lista por nome e mostrar
            //o resultado na tela.Nota: o caminho do arquivo pode ser informado "hardcode".

            string path = @"c:/temp/in.csv";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream) {                        
                        list.Add(new Employee(sr.ReadLine()));                        
                    }

                    list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

                    foreach (Employee emp in list) {
                        Console.WriteLine(emp);
                    }
                }
            } 
            catch(IOException e) {
                Console.WriteLine("Error: " + e.Message);
            }
            catch(ArgumentException e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
