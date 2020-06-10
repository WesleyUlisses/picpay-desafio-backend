# Desafio Back-end PicPay

Primeiramente, obrigado pelo seu interesse em trabalhar na melhor plataforma de pagamentos do mundo!
Abaixo você encontrará todos as informações necessárias para iniciar o seu teste.

## Avisos antes de começar

- Primeiro crie uma branch a partir da `master` nesse padrão de nomenclatura: dd-mm-yy/nome-sobrenome (por exemplo, 30-04-20/meu-nome)
- Você poderá consultar o Google, Stackoverflow ou algum projeto particular na sua máquina.
- Fique à vontade para perguntar qualquer dúvida aos recrutadores.
- Fique tranquilo, respire, assim como você, também já passamos por essa etapa. Boa sorte! :)

## Setup do projeto

- Laravel 5.8
- PHP > 7.2

## Como Rodar?

- Instale as dependências usando o comando `composer install`
- Na raiz do repositório, rode este comando `php artisan serve` para iniciar o servidor de desenvolvimento.
- A Aplicação estará disponível na porta `http://localhost:8080/`

## Objetivo
Tem-se usuários comuns e lojistas, ambos têm carteira com dinheiro. Usuários podem enviar dinheiro (efetuar transações) para lojistas e entre usuários. 

- Lojistas não podem enviar dinheiro para usuários. 

- Deve verificar se o usuário tem saldo suficiente

- A operação de transação deve ser uma transação (ou seja, revertida em qualquer caso de inconsistência) e o dinheiro deve voltar para a carteira do usuário que envia. 

- No recebimento de pagamento, o usuário ou lojista precisa receber notificação enviada por um serviço de terceiro e eventualmente pode estar indisponível (https://run.mocky.io/v3/b19f7b9f-9cbf-4fc6-ad22-dc30601aec04). 

- Esse serviço funciona via interface RESTful. 

### Payload
```json
{
    "value" : 100.00,
    "payer" : 4,
    "payee" : 15
}
```

- No recebimento de pagamento, o usuário ou lojista precisa receber notificação enviada por um serviço de terceiro e eventualmente pode estar indisponível (https://run.mocky.io/v3/b19f7b9f-9cbf-4fc6-ad22-dc30601aec04). 

## O que será avaliado
- Organização do código
- Arquitetura

## o que será um diferencial
- Criação de imagem própria (Dockerfile)
- Teste unitários
- 

## Documentação Laravel

https://laravel.com/docs

## Sugestões de estudo
https://laracasts.com

