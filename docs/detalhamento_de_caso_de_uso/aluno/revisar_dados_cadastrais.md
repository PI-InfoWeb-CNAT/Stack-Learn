	# Projeto comércio eletrônico (StackLearn)

## Especificação do caso de uso - Realizar cadastro

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 27/11/2022 | *1.00* | Versão Inicial  | Raquel Garcia |

### 1. Resumo 

Possibilita que o usuário altere os dados cadastrados no sistema.

### 2. Atores

Alunos e professores.

### 3. Pré-condições

Aluno e professor cadastrados.

### 4. Pós-condições

Dados no sistema alterados.

### 5. Fluxos de evento
#### 5.1 Fluxo principal
1.[IN] O usuário acessa a funcionalidade de revisar dados, indicada pelo ícone de perfil.
2.[OUT] O sistema disponibiliza o formulário com informações já preenchidos.
3.[IN] O usuário altera os campos, podendo eles serem: nome completo, e-mail, senha. Já especificamente para professor o CEP e o endereço poderão ser alterados também.
4.[OUT] O sistema salva e valida as informações.

#### 5.2 Fluxo de exceção passo 4 – campo sem informações
Quando o usuário for salvar as alterações e uma categoria estiver vazia, uma mensagem de erro deverá aparecer “Não há informações em x”, fazendo o usuário voltar a etapa 3.
