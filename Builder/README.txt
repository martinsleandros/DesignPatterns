Referencia
https://refactoring.guru/pt-br/design-patterns/builder
https://medium.com/@jonesroberto/desing-patterns-parte-6-builder-f20752fb0c35

- Intenção
O Builder é um padrão de design criacional que permite construir objetos complexos passo a passo. O padrão permite produzir diferentes tipos e representações de um objeto usando o mesmo código de construção.

Além disso, o padrão builder descreve uma maneira de separar um objeto de sua construção. O mesmo método de construção pode criar uma representação diferente do objeto.

- Problema
Por exemplo, vamos pensar em como criar uma classe House. Para construir uma casa simples, você precisa construir quatro paredes e um piso, instalar portas, encaixar janelas e criar um telhado. Mas se você quiser uma casa maior de dois andares e com garagem para vários carros, com um quintal e outras coisas boas (como um sistema de aquecimento, encanamento e fiação elétrica)?

A solução mais simples é estender a class House e criar um conjunto de subclasses para cobrir todas as combinações dos parâmetros. Mas, eventualmente, você terminará com um número considerável de subclasses. Qualquer novo parâmetro, como o estilo de varanda, exigirá que a hierarquia cresça ainda mais.

Ou você também pode criar um construtor gigante na classe House com todos os parâmetros possíveis que controlam o objeto. Embora essa abordagem elimine a necessidade de subclasses, ela cria outro problema, vários parâmetros não serão utilizados, tornando o construtor grande e feio (e difícil de utilizar). Por exemplo, poucas casas tem piscinas; portanto, os parâmetros relacionados às piscinas seriam inúteis na maioria das vezes.

- Solução
O padrão Builder sugere que você extraia o código de construção do objeto de sua própria classe e o mova para objetos separados chamados builders.

O padrão Builder permite construir objetos complexos passo a passo. O Builder não permite que outros objetos acessem o produto enquanto ele está sendo construído.

O padrão organiza construção objeto organizando em um conjunto de passos. Para criar um objeto, você executa uma série dessas etapas em um objeto construtor. A parte importante é que você não precisa executar todas as etapas. Você pode chamar apenas as etapas necessárias para produzir uma configuração específica de um objeto.

Algumas das etapas de construção podem exigir implementação diferente quando você precisa criar várias representações do produto.

Nesse caso, você pode criar várias classes builders diferentes que implementam o mesmo conjunto de etapas de construção, mas de uma maneira diferente. Em seguida, você pode usar esses builders no processo de construção para produzir diferentes tipos de objetos.

- Prós
Você pode construir objetos passo a passo, adiar etapas de construção ou executar etapas recursivamente.
Você pode reutilizar o mesmo código de construção ao criar várias representações de produtos.
Princípio de responsabilidade única . Você pode isolar o código de construção complexo da lógica de negócios do produto.

- Contras
A complexidade geral do código aumenta, pois o padrão requer a criação de várias novas classes.