# Semáforo em C#

Este projeto implementa um semáforo em C# que simula a transição entre as cores vermelho, amarelo e verde, utilizando um `Timer` para controlar o tempo de cada estado.

## Descrição

O semáforo alterna automaticamente entre três estados:
- **Vermelho**: Indica parada.
- **Amarelo**: Indica atenção ou transição.
- **Verde**: Indica passagem liberada.

A mudança de cores é gerenciada por um `Timer`, que define intervalos de tempo para cada cor, simulando o comportamento de um semáforo de trânsito.

## Funcionalidades

- Transição automática entre as cores vermelho, amarelo e verde.
- Temporização configurável para cada estado do semáforo.
- Implementação simples e modular, fácil de integrar em outros projetos.

## Configuração do Timer

- Os tempos padrão para cada cor são:
- **Vermelho: 5 segundos**
- **Amarelo: 2 segundos**
- **Verde: 5 segundos**

## Requisitos

- .NET Framework ou .NET Core (dependendo da versão do C# utilizada).
- Ambiente de desenvolvimento (Visual Studio, VS Code com extensões C#).

## Imagem do software
![Print do Semáforo](print.PNG)
