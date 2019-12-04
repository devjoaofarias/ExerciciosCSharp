using System;
using RoleTopMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Controllers;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;


public class CadastroController : AbstractController {
    ClienteRepository clienteRepository = new ClienteRepository ();
    public IActionResult Cadastro () {
        return View (new BaseViewModel () {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession (),
                UsuarioNome = ObterUsuarioNomeSession ()
        });
    }

    public IActionResult CadastrarCliente (IFormCollection form) {
        ViewData["Action"] = "Cadastro";
        try {
            Cliente cliente = new Cliente (
                form["nome"],
                form["email"],
                form["cpf"],
                form["telefone"],
                form["senha"]);


            cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;
            if(!string.IsNullOrEmpty(form["name"]) && !string.IsNullOrEmpty(form["email"]) && !string.IsNullOrEmpty(form["cpf"]) && !string.IsNullOrEmpty(form["telefone"]) && !String.IsNullOrEmpty(form["senha"])) {
                clienteRepository.Inserir (cliente);

            return View ("Sucesso", new RespostaViewModel () {
                NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession ()});
            } else {
                return View ("Erro", new RespostaViewModel() {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        } catch (Exception e) {
            System.Console.WriteLine (e.StackTrace);
            return View ("Erro", new RespostaViewModel () {
                NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession ()
            });
        }
    }

    

}