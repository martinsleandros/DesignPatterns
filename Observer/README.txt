Referencia
https://refactoring.guru/pt-br/design-patterns/observer
https://medium.com/@jonesroberto/design-patterns-parte-21-observer-e2260412011a

- Intenção
É um padrão de design comportamental que permite definir um mecanismo de assinatura para notificar vários objetos sobre quaisquer eventos que ocorram no objeto que estão observando.

- Problema
Um grande projeto monolítico não se adapta bem à medida que novos requisitos de gráficos ou monitoramento são cobrados.

- Solução
Defina um objeto que seja o “guardião” do modelo de dados e / ou lógica de negócios (Subject). Delegue todas as funcionalidades de “ view” a objetos Observer dissociados e distintos. Os observers se registram no Subject à medida que são criados. Sempre que o Subject muda, transmite a todos os Observers registrados que ele mudou, e cada Observer consulta o Subject pelo subconjunto do estado do Subject que é responsável pelo monitoramento.

Isso permite que o número e o “type” de objetos “view” sejam configurados dinamicamente, em vez de serem especificados estaticamente em tempo de compilação.

- Prós
Princípio Aberto / Fechado . Você pode introduzir novas classes de assinantes sem precisar alterar o código do editor (e vice-versa, se houver uma interface do editor).
Você pode estabelecer relações entre objetos em tempo de execução.

- Contras
Os assinantes são notificados em ordem aleatória.