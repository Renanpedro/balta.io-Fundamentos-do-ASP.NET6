# Introducao e Minimal APIS
**Api -** Aplicação web que fica esperando um request e retorna o response fica “ouvindo” uma porta e caso passe algo pela porta configurada para a Api ela irá manipular a informação e fazer o retorno.

**HTTPS -** Hyper Text Transfer Protocol Secure protocolo para transferencia de hipertexto, imagem, midia e afins.

**Verbos do HTTP**
- GET - Usado para obter alguma informação
- POST - Enviar alguma informação para a aplicação
- PUT - Atualizar alguma informação
- DELETE - Para excluir alguma informação

**Status Code:**
200 - OK 
300 - Movido
400 - Erro pelo lado do Cliente(Bad Request)
500 - Erro interno do Servidor

**Request -** É devidido em headers(cabecalho) e body(corpo)

**dotnet new web -o NomeProjeto -** Para criar a api via terminal

**DNS Domain Name Service -** Faz o depara do IP para o dominio na internet toda página é hospedada em um ip para não precisar digitar o ip para acessar a pagina nos procuramos pelo dominio e o DNS faz a conversão.

**Serializacao JSON -** JavaScript Object Notation
- Serialização - Pegar o objeto C# e transformar em um JSON
- Deserialização - Pegar um JSON e transformar em um objeto C#