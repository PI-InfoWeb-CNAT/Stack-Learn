	# Projeto comércio eletrônico (StackLearn)

## Especificação do caso de uso - Gerenciar categorias

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 20/08/2021 | *1.00* | Versão Inicial  | Raquel Garcia |

### 1. Resumo 

Possibilita o gerenciamento dos cursos, de forma a conseguir  “Criar categoria”, “Excluir categoria” e “Atualizar categoria”.

### 2. Atores 

Administrador.

### 3. Pré-condições

Criar categoria: pelo menos existir um curso para a categoria estar associada.

### 4. Pós-condições

Criar categoria: cursos estarão associados a essa categoria.
Excluir categoria: cursos não terão mais essa categoria.
Atualizar categoria: todos os cursos vinculados terão o nome da categoria alterada.

### 5. Fluxos de evento
#### 5.1. Fluxo Principal
**Criar categoria**   
1.[IN] O usuário acessa a funcionalidade de adicionar mais uma categoria.   
2.[OUT] O sistema disponibiliza o formulário para ser preenchido.   
3.[IN] O usuário preenche o único campo contendo a informação de nome.   
4.[OUT] O sistema valida os campos e exibe a interface com todas as categorias existentes.   
	
**Excluir categoria**   
1.[IN] O usuário acessa a funcionalidade de excluir uma categoria em específico.   
2.[OUT] O sistema disponibiliza o nome da categoria e os cursos agregados a ela.   
3.[IN] O usuário preenche essa opção.   
4.[OUT] O sistema valida a exclusão e exibe a interface com todas as categorias.   
	
**Atualizar categoria**   
1.[IN] O usuário acessa a funcionalidade de atualizar uma categoria.   
2.[OUT] O sistema disponibiliza a interface de um formulário com o nome da categoria em questão.   
3.[IN] O usuário altera o campo de nome.   
4.[OUT] O sistema valida as alterações e exibe a interface com todas as categorias.   

#### 5.2 Fluxo de exceção
**Criar categoria**   
1.Dados inválidos: se o usuário disponibilizar dados não aceitos no sistema.   
2. Se o usuário escrever um nome já existente de curso, o sistema deverá exibir a mensagem de “Nome de categoria já existente, tente novamente” e voltar ao passo 3.  

**Excluir categoria**   
Não há casos de exceção para esse passo.   

**Atualizar categoria**   
1.Dados inválidos: se o usuário disponibilizar dados não aceitos no sistema.   
2.Mesmo passo para  "Criar categoria”.   

### 6. Prototipos de Interface

`A ser desenvolvido pelo aluno.`
