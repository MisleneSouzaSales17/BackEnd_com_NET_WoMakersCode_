# BackEnd_com_NET_WoMakersCode

Este repositório contém um projeto de exemplo em C# para .NET 10.0, com vários arquivos de código-fonte (`Program.cs`, `Program1.cs`, `Program2.cs`, `Program3.cs`, `Program4.cs`) e um projeto principal `TestProject.csproj`.

## Estrutura

- `Program.cs`, `Program1.cs`, `Program2.cs`, `Program3.cs`, `Program4.cs` — arquivos de código-fonte principais na raiz.
- `TestProject.csproj` — arquivo de projeto .NET SDK que define a aplicação de console.
- `TestProject/` — diretório de suporte do projeto.
- `bin/` e `obj/` — diretórios de saída e build gerados automaticamente.

## Requisitos

- .NET 10.0 SDK

## Como executar

No terminal, execute os comandos abaixo a partir da raiz do repositório:

```bash
cd "c:\Visual Studio Code\BackEnd_com_NET_WoMakersCode\CsharpProjects"
dotnet build

dotnet run --project TestProject.csproj
```

## Observações

- O projeto usa recursos padrão do .NET 10 e `ImplicitUsings` habilitado.
- Se houver mais de um arquivo `Program*.cs`, verifique qual arquivo é usado como ponto de entrada ou ajuste `TestProject.csproj` conforme necessário.
