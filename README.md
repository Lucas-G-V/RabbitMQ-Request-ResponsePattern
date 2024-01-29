***
# Exemplo de RPC com EasyNetQ
***

Este é um exemplo simples que demonstra a implementação do padrão de solicitação/resposta (RPC - Remote Procedure Call) usando EasyNetQ, um cliente RabbitMQ para .NET.

## Descrição

Este exemplo consiste em dois aplicativos de console simples: um servidor e um cliente. O servidor aguarda por solicitações, e o cliente envia solicitações para o servidor, recebendo respostas correspondentes.

## Pré-requisitos

- .NET Core ou .NET Framework instalado
- RabbitMQ instalado e em execução localmente (ou host configurado para conexão)

## Uso

1. Abra o projeto em sua IDE preferida.
2. Abra dois terminais ou janelas de prompt de comando.
3. No primeiro terminal, navegue até a pasta do projeto e execute o servidor:

    ```bash
    dotnet run --project EasyNetQRpcServer
    ```

4. No segundo terminal, navegue até a mesma pasta do projeto e execute o cliente:

    ```bash
    dotnet run --project EasyNetQRpcClient
    ```

5. O cliente solicitará uma mensagem de entrada. Digite uma mensagem e pressione Enter para enviá-la ao servidor. O servidor responderá com uma mensagem de confirmação.

6. Repita o passo 5 conforme necessário para enviar mais solicitações.

7. Para encerrar o servidor ou cliente, pressione Ctrl + C no terminal correspondente.

## Estrutura do Projeto

- **EasyNetQRpcServer**: Aplicativo de console que atua como o servidor RPC. Ele aguarda solicitações e envia respostas correspondentes.
- **EasyNetQRpcClient**: Aplicativo de console que atua como o cliente RPC. Ele envia solicitações ao servidor e exibe as respostas recebidas.

## Notas

- Certifique-se de ter o RabbitMQ em execução localmente ou configure o host de conexão em ambos os aplicativos de acordo com sua configuração do RabbitMQ.
- Este é apenas um exemplo básico de implementação do padrão RPC usando EasyNetQ e RabbitMQ. Ajustes e melhorias adicionais podem ser feitos para atender aos requisitos específicos do seu projeto.

***
