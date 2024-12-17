Referencia
https://refactoring.guru/pt-br/design-patterns/template-method
https://medium.com/@jonesroberto/design-patterns-parte-24-template-method-69e3a7927dcd

- Intenção
É um padrão de design comportamental que define o esqueleto de um algoritmo na superclasse, mas permite que as subclasses substituam etapas específicas do algoritmo sem alterar sua estrutura.

- Problema
Dois componentes diferentes têm semelhanças significativas, mas não demonstram reutilização de interface ou implementação comum. Se uma alteração comum a ambos os componentes for necessária, um esforço duplicado deverá ser gasto.

- Solução
O padrão do Template Method sugere que você divida um algoritmo em uma série de etapas, transforme essas etapas em métodos e faça uma série de chamadas para esses métodos em um único “template method”. As etapas podem ser abstract ou ter algum padrão implementação. Para usar o algoritmo, o cliente deve fornecer sua própria subclasse, implementar todas as etapas abstratas e substituir algumas opcionais, se necessário (mas não o próprio método de modelo).

- Prós
Você pode permitir que os clientes substituam apenas certas partes de um algoritmo grande, tornando-os menos afetados pelas alterações que acontecem com outras partes do algoritmo.
Você pode colocar o código duplicado em uma superclasse.

- Contras
Alguns clientes podem ser limitados pelo esqueleto fornecido de um algoritmo.
Você pode violar o princípio de substituição de Liskov suprimindo uma implementação de etapa padrão por meio de uma subclasse.
Os métodos de modelo tendem a ser mais difíceis de manter quanto mais etapas eles tiverem.