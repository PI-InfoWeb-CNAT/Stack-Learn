<StackLearn>
Especificação de Caso de Uso
<Gerenciar cursos>
1 Resumo
Possibilita o gerenciamento dos cursos, de forma a conseguir  “Criar curso”, “Excluir curso” e “Atualizar curso”.
2 Atores
Administrador.
3 Precondições
Criar curso: pelo menos existir um professor e uma categoria para ser associado.
4 Pós-condições 
Criar curso: professores e categorias terão esse curso associado.
Excluir curso: professores e categorias não terão mais esse curso associado.
Atualizar curso: informações do curso alteradas.
5 Fluxos de evento
5.1 Fluxo básico
Criar curso
1.[IN] O usuário acessa a funcionalidade de adicionar mais um curso.
2.[OUT] O sistema disponibiliza o formulário para ser preenchido.
3.[IN] O usuário preenche os campos contendo informações de: nome, descrição, quantidade de aulas, preço, professor e categoria.
4.[OUT] O sistema valida os campos e exibe a interface com todos os cursos.
Excluir curso
1.[IN] O usuário acessa a funcionalidade de excluir um curso em específico.
2.[OUT] O sistema disponibiliza todos os dados daquele curso e a opção de confirmar a exclusão.
3.[IN] O usuário preenche essa opção.
4.[OUT] O sistema valida a exclusão e exibe a interface com todos os cursos.
Atualizar curso
1.[IN] O usuário acessa a funcionalidade de atualizar um curso.
2.[OUT] O sistema disponibiliza a interface de um formulário com todos os dados até agora naquele curso.
3.[IN] O usuário altera os campos de: nome, descrição, quantidade de aulas, preço, professor e categoria.
4.[OUT] O sistema valida as alterações e exibe a interface com todos os cursos.
5.2 Fluxo alternativo
Não existe fluxo alternativo
5.3 Fluxo de exceção
Criar curso
	1.Dados inválidos: se o usuário disponibilizar dados não aceitos no sistema.
	2. Se o usuário esquecer de relacionar um professor e uma categoria ao curso, o sistema deverá exibir a mensagem “Professor e categoria devem estar relacionados” e voltar ao passo 3.
	3. Se o usuário escrever um nome já existente de curso, o sistema deverá exibir a mensagem de “Nome de curso já existente, tente novamente” e voltar ao passo 3.
Excluir curso
Não há casos de exceção para esse passo.
Atualizar perfil
1.Dados inválidos: se o usuário disponibilizar dados não aceitos no sistema.
2. Todos os passos do passo “Criar curso”.
