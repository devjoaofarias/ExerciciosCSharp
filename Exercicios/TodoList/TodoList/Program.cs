﻿using System;
using System.Collections.Generic;
using System.IO;

namespace TodoList {
    class Program {
        static void Main (string[] args) {

            List<TodoItem> todoList = new List<TodoItem> ();
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName;

            try {
                string[] todoFile = File.ReadAllLines (filePath);

                foreach (var line in todoFile) {
                    string[] itens = line.Split (",");
                    string titulo = itens[0].Replace ("\"", "");
                    string nota = itens[1].Replace ("\"", "");

                    TodoItem todoItem = new TodoItem (titulo, nota);
                    todoList.Add (todoItem);

                }

            } catch (IOException ioe) {
                System.Console.WriteLine ("Erro ao acessar arquivo");
                System.Console.WriteLine (ioe.Message);
            }

            int opcao = 0;
            do {
                Console.Clear ();
                System.Console.WriteLine ("TODO LIST");
                System.Console.WriteLine ();
                ListaItens (todoList);
                System.Console.WriteLine ();
                System.Console.WriteLine ("Digite uma opção: ");
                System.Console.WriteLine ("1 - Adicionar item");
                System.Console.WriteLine ("2 - Remover item");
                System.Console.WriteLine ("3 - Sair do programa");
                System.Console.WriteLine ("Opção: ");

                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        AddItem (todoList);
                        break;
                    case 2:
                        RemoveItem (todoList);
                        break;
                    case 3:
                        System.Console.WriteLine ("Tchau!");
                        SaveItem (todoList, filePath);
                        break;
                    default:
                        System.Console.WriteLine ("Opção inválida!");
                        Console.ReadLine ();
                        break;
                }

            } while (opcao != 3);
        }
        public static void ListaItens (List<TodoItem> todoList) {
            Console.Clear ();
            int count = 1;
            System.Console.WriteLine ("Todo list");
            System.Console.WriteLine ();
            System.Console.WriteLine ($"ID {"",2} Título {"", 12} Notas");
            foreach (var item in todoList) {
                System.Console.WriteLine ($"{count, 3}: {item.Titulo, -15} - {item.Nota}");
                count++;

            }
        }

        public static void AddItem (List<TodoItem> todoList) {
            Console.Clear ();
            System.Console.WriteLine ("Novo Item: ");
            System.Console.WriteLine ();
            System.Console.WriteLine ("Título: ");
            string titulo = Console.ReadLine ();
            System.Console.WriteLine ("Nota: ");
            string nota = Console.ReadLine ();
            TodoItem item = new TodoItem (titulo, nota);

            todoList.Add (item);
        }
        public static void RemoveItem (List<TodoItem> todoList) {

            int index = 0;
            do {
                Console.Clear ();
                System.Console.WriteLine ("Remove item");
                System.Console.WriteLine ();
                ListaItens (todoList);
                System.Console.WriteLine ();
                System.Console.WriteLine ("Digite o ID ou X para terminar");
                System.Console.WriteLine ("ID: ");
                string id = Console.ReadLine ();

                if (id.ToLower () == "x") {
                    break;
                } else {
                    index = int.Parse (id) - 1;
                }

                if ((index < 0) || (index > todoList.Count - 1)) {
                    System.Console.WriteLine ("ID Inválido");
                    System.Console.WriteLine ("Pressione <enter> para confirmar");
                    Console.ReadLine ();

                } else {
                    todoList.RemoveAt (index);
                }

            } while (true);

        }

        #region Grava a lista no arquivo
        static void SaveItem (List<TodoItem> lista, string filePath) {
            List<string> linhas = new List<string>();
            linhas.Add("Titulo, Nota");
        foreach (TodoItem item in lista) {
                string titulo = "\"" + item.Titulo + "\"";
                string nota = "\"" + item.Nota + "\"";
                linhas.Add(titulo + "," + nota);
            }
            string tryAgain = "";
            do {
                try {
                    File.WriteAllLines(filePath, linhas);
                    tryAgain = "n";
                } catch(IOException e) {
                    System.Console.WriteLine("Erro na gravação do arquivo.");
                    System.Console.WriteLine(e.Message);
                    do {
                        System.Console.WriteLine("Deseja tentar novamente?");
                        tryAgain = Console.ReadLine().ToLower();
                    } while (tryAgain == "s" || tryAgain == "n");
                }
            } while (tryAgain != "n");


        #endregion
        }
    }
}
