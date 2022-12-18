	# Projeto comércio eletrônico (StackLearn)

## Especificação do caso de uso - Verificar e modificar progresso do curso

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 27/11/2022 | *1.00* | Versão Inicial  | Raquel Garcia |

### 1. Resumo 

Possibilita que os usuários tenham acesso a quantas aulas ele já assistiu e quer assistir.

### 2. Atores

Alunos.

### 3. Pré-condições

O aluno deve estar cadastrado no sistema.
O usuário deve ter comprado o curso.

### 4. Pós-condições

O usuário vai verificar e modificar o progresso do curso.

### 5. Fluxos de evento
#### 5.1 Fluxo principal
1[IN]. O usuário acessa a funcionalidade “Meus Cursos” disponível no menu.
2[OUT]. O sistema carrega a página dividida em duas listas: “Em andamento” e “Concluído”.
3[IN]. O usuário acessa um curso em andamento, uma vez que os concluídos já foram concluídos.
4[OUT]. O sistema carrega a página com as aulas do curso.
5[IN]. O usuário marca a aula como concluída ou não.
6[OUT]. O sistema valida as informações e volta para a funcionalidade “Meus Curso”.



