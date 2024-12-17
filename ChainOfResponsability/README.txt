Referencia
https://refactoring.guru/pt-br/design-patterns/chain-of-responsibility
https://medium.com/@jonesroberto/design-patterns-parte-15-chain-of-resposability-8790ebb5d443

- Intenção
É um padrão de design comportamental que permite passar solicitações ao longo de uma cadeia de manipuladores. Ao receber uma solicitação, cada manipulador decide processar a solicitação ou passá-la para o próximo manipulador na cadeia.

- Problema
Ao escrever um aplicativo de qualquer tipo, geralmente acontece que o evento gerado por um objeto precisa ser tratado por outro. E, para tornar nosso trabalho ainda mais difícil, também temos acesso negado ao objeto que precisa lidar com o evento.

- Solução
O padrão de design da Chain of Responsibility permite que um objeto envie um comando sem saber qual objeto receberá e manipulará. A solicitação é enviada de um objeto para outro, tornando-os partes de uma cadeia e cada objeto dessa cadeia pode manipular o comando, transmiti-lo ou fazer os dois. O exemplo mais comum de uma máquina que usa a Cadeia de Responsabilidade é o slot para moedas da máquina de venda automática: em vez de ter um slot para cada tipo de moeda, a máquina possui apenas um slot para todos eles. A moeda descartada é roteada para o local de armazenamento apropriado, determinado pelo receptor do comando.

- Client
Essa é a classe que gera a solicitação e a passa para o primeiro manipulador na cadeia de responsabilidade.

- Handler
Esta é a classe abstrata que contém um membro que mantém o próximo manipulador na cadeia e um método associado para definir esse sucessor. Ele também possui um método abstrato que deve ser implementado por classes concretas para manipular a solicitação ou passá-la para o próximo objeto no pipeline.

- ConcreteHandlerA & ConcreteHandlerB
Essas são classes de concretas de manipuladores que são herdadas da classe Handler. Isso inclui a funcionalidade de lidar com algumas solicitações e passar outras para o próximo item na cadeia de solicitações.

- Prós
Você pode controlar a ordem de tratamento de solicitações.
Princípio de responsabilidade única . Você pode desacoplar classes que invocam operações de classes que executam operações.
Princípio Aberto/Fechado . Você pode introduzir novos manipuladores no aplicativo sem quebrar o código do cliente existente.

- Contras
Alguns pedidos podem acabar sem tratamento.