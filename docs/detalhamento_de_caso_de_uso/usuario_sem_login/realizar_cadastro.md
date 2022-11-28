	# Projeto comércio eletrônico (StackLearn)

## Especificação do caso de uso - Realizar cadastro

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 27/11/2022 | *1.00* | Versão Inicial  | Raquel Garcia |

### 1. Resumo 

Possibilita a inserção de dados no sistema de um futuro professor ou aluno.

### 2. Atores 

Usuário sem login.

### 3. Pré-condições

O usuário não vai poder ter seus dados já existentes no sistema.

### 4. Pós-condições

O usuário poderá usufruir dos serviços de professor, como ter controle dos cursos criados e do fórum, ou dos serviços do aluno, por exemplo, ter acesso ao ambiente de compra, ver as videoaulas dos cursos.

### 5. Fluxos de evento
#### 5.1. Fluxo Principal  
1.[IN] O usuário deverá acessar a interface.   
2.[IN] O usuário vai preencher os campos com dados, caso queira ser professor serão necessários: nome completo, senha, e-mail, CPF, CEP, e endereço, já se quiser ser aluno serão pedidos: nome completo, senha, e-mail, CPF.     
3.[OUT] O sistema valida as informações.   

#### 5.2 Fluxo de exceção passo 3 – dados não válidos
Quando o usuário inserir CPF ou CEP com a quantidade de algarismos inferior, ou superior, ao necessário, uma mensagem de erro aparecerá e ele voltará ao passo 3.
Mensagem1) “CPF não válido. Insira outro valor com mais/menos x algarismos.”
Mensagem2) “CEP não válido. Insira outro valor com mais/menos x algarismos.”
Mensagem3) “CPF e CEP não válidos. Insira outro valor.”
