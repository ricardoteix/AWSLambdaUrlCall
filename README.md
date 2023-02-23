# AWS Lambda URL Call 

Este projeto tem o propósito de facilitar a execução de URLs de função do Lambda na AWS. A URL da função Lambda pode ser usada para executar a função via requisição HTTP.

Para saber mais sobre URLs de função do Lambda acesse https://docs.aws.amazon.com/pt_br/lambda/latest/dg/lambda-urls.html?icmpid=docs_lambda_help

# Compilação

O software foi desenvolvido em C# no Microsoft Visual Studio Community 2019. 

Para compilar baixe o repositório e abra no Microsoft Visual Studio Community 2019 ou mais recente. 

As dependências no NuGet são:

- Aws4RequestSigner
- AWSSDK.Core
- AWSSDK.SecurityToken
- Newtonsoft.Json

# Compatibilidade e Uso

O software é compatível apenas com Windows e foi testado no Windows 10.

Para usar o software você pode compilar sua versão ou baixar a versão disponível na pasta Releases deste repositório e executar o arquivo EXE chamado **AWSLambdaUrlCall.exe**, o único com o ícone do AWS Lambda. Se seu PC não exibir as extensões dos arquivos o nome aparecerá sem o .exe.

Ao abrir o software você precisará informar alguns campos:

- AWS CLI Profile: um profile criado com a AWS CLI com o comando:
  
  ``aws configure --profile nome_do_seu_profile``
- Lambda URL: é a URL da função Lambda que você pode obter na console da AWS, logo abaixo do ARN da função.
- Região: este campo está com o valor padrão da Virgínia, *us-east-1*. Modifique caso necessário.

Para realziar a requisição à URL da função é preciso especificar as credenciais. Estas credenciais podem ser obtidas com o comando no AWS CLI:

``aws sts get-caller-identity --profile nome_do_seu_profile``

Este comando fornecerá:

- AccessKeyId
- SecretAccessKey
- SessionToken

Também é possível obter as credenciais clicando no botão **Obter Credenciais Automaticamente**.

Após obter as credenciais e preencher os campos corretamente, será possível realizar a requisição. Para isso basta clicar no botão **Executar Lambda**, na canto inferior direito.

Caso seja preciso enviar dados na requisição use o campo *Conteúdo para enviar (JSON)*. Deve ser um texto no formato JSON.

O campo *Resultado* exibirá o retorno da sua função após a execução ou informações de possíveis problemas que ocorram, como token expirado.
