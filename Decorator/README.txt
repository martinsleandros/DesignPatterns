Referencia
https://refactoring.guru/pt-br/design-patterns/decorator/
https://medium.com/@jonesroberto/desing-patterns-parte-11-decorator-ba348f44142f

- Intenção
O Decorator é um padrão de design estrutural que permite anexar novos comportamentos aos objetos, colocando-os dentro de objetos especiais do wrapper que contêm os comportamentos.

- Problema
Você deseja adicionar comportamento ou estado a objetos individuais em tempo de execução. A herança não é viável porque é estática e se aplica a uma classe inteira.

- Solução
Estender uma classe é a primeira coisa que vem à mente quando você precisa alterar o comportamento de um objeto. No entanto, a herança tem várias advertências sérias que você precisa estar ciente.

	A herança é estática. Você não pode alterar o comportamento de um objeto existente no tempo de execução. Você só pode substituir o objeto inteiro por outro criado a partir de uma subclasse diferente.
	As subclasses podem ter apenas uma classe pai. Na maioria dos idiomas, a herança não permite que uma classe herde comportamentos de várias classes ao mesmo tempo.

Uma das maneiras de superar essas advertências é usando Agregação ou Composição em vez de herança . Ambas as alternativas funcionam quase da mesma maneira: um objeto fazreferência a outro e delega-lhe algum trabalho, enquanto que com a herança, o próprio objeto é capaz de fazer esse trabalho, herdando o comportamento de sua superclasse.

Com essa nova abordagem, você pode facilmente substituir o objeto “auxiliar” vinculado por outro, alterando o comportamento do contêiner em tempo de execução. Um objeto pode usar o comportamento de várias classes, tendo referências a vários objetos e delegando a eles todos os tipos de trabalho. A agregação / composição é o princípio principal por trás de muitos padrões de design, incluindo o Decorator. Nessa nota, vamos voltar à discussão sobre padrões.

- Component
Essa é uma interface que contém membros que serão implementados pela ConcreteClass e Decorator.

- ConcreteComponent
Esta é uma classe que implementa a interface do componente.

- Decorator
Esta é uma classe abstrata que implementa a interface Component e contém a referência a uma instância Component. Essa classe também atua como classe base para todos os decoradores de componentes.

- ConcreteDecorator
Esta é uma classe que herda da classe Decorator e fornece um decorador para componentes.

- Prós
Você pode estender o comportamento de um objeto sem criar uma nova subclasse.
Você pode adicionar ou remover responsabilidades de um objeto em tempo de execução.
Você pode combinar vários comportamentos envolvendo um objeto em vários decoradores.
Princípio de responsabilidade única . Você pode dividir uma classe monolítica que implementa muitas variantes possíveis de comportamento em várias classes menores.

- Contras
É difícil remover um invólucro específico da pilha de invólucros.
É difícil implementar um decorador de forma que seu comportamento não dependa da ordem na pilha de decoradores.
O código de configuração inicial das camadas pode parecer bastante feio.