Referencia
https://refactoring.guru/pt-br/design-patterns/state
https://medium.com/@jonesroberto/design-patterns-parte-22-state-73c5cda90029

- Intenção
É um padrão de design comportamental que permite que um objeto altere seu comportamento quando seu estado interno for alterado. Parece que o objeto mudou de classe.

- Problema
O padrão de estado está intimamente relacionado ao conceito de uma máquina de estado finito.

A idéia principal é que, a qualquer momento, existe um número finito de estados nos quais um programa pode estar. Dentro de qualquer estado único, o programa se comporta de maneira diferente e o programa pode ser alternado de um estado para outro instantaneamente. No entanto, dependendo do estado atual, o programa pode ou não mudar para outros estados. Essas regras de comutação, chamadas transições , também são finitas e predeterminadas.

- Solução
O padrão State sugere que você crie novas classes para todos os estados possíveis de um objeto e extraia todos os comportamentos específicos do estado para essas classes.

Em vez de implementar todos os comportamentos por conta própria, o objeto original, chamado contexto , armazena uma referência a um dos objetos de estado que representam seu estado atual e delega todo o trabalho relacionado a esse objeto.

Para fazer a transição do contexto para outro estado, substitua o objeto de estado ativo por outro objeto que represente esse novo estado. Isso é possível apenas se todas as classes de estado seguirem a mesma interface e o próprio contexto trabalhar com esses objetos por meio dessa interface.


- Prós
Princípio de responsabilidade única . Organize o código relacionado a estados específicos em classes separadas.
Princípio Aberto / Fechado . Introduzir novos estados sem alterar as classes de estado existentes ou o contexto.
Simplifique o código do contexto, eliminando condicionais volumosos da máquina de estado.

- Contras
A aplicação do padrão pode ser um exagero se uma máquina de estados tiver apenas alguns estados ou raramente mudar.