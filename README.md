<h1 align="center" style="font-weight: bold;">MedAgenda</h1>

<p align="center">
 <a href="#introdução">Introdução</a> • 
  <a href="#descrição">Descrição do Projeto</a> •
 <a href="#tecnologia">Tecnologias</a> •
  <a href="#colab">Colaboladores e Contribuições</a> •
 <a href="#links">Links do Projeto</a> 
 <a href="#"</a></a>
</p>
<p align="center">
    <b>
</p>

<h2 id="Introdução"> Introdução</h2>

O MedAgenda é uma ferramenta simples e prática que conecta médicos e pacientes via aplicativo. Com um sistema intuitivo, ele permite que os pacientes agendem consultas utilizando seus convênios de maneira facilitada, reduzindo burocracias e melhorando a experiência de atendimento médico. 


<h2 id="descriçao"> Descrição do Projeto</h2>

O uso da ferramenta visa otimizar o processo de agendamento e acesso a informações de saúde, facilitando a comunicação e o acompanhamento tanto para pacientes quanto para profissionais da saúde, com foco em conveniência e praticidade, oferecendo as seguintes funcionalidades:

Para Pacientes:

- Marcação simplificada de consultas: Agendamento online intuitivo, com visualização de horários disponíveis e escolha de profissionais/especialidades;
- Acesso ao histórico de exames: Visualização rápida e segura de resultados de exames realizados;
- Notificações inteligentes: Lembretes de consultas agendadas para evitar esquecimentos.

Para Médicos:

- Gestão de agenda: Visualização e organização eficiente da agenda de consultas;
- Acesso ao histórico de exames de pacientes: Consulta rápida e segura do histórico de exames de seus pacientes para acompanhamento.

<h2 id="Tecnologias"> Tecnologias</h2>

Para a construção do app MedAgenda foram utilizados as seguintes tecnologias: 

- Reactive Native 
- TypeScript 
- ASP.NET Core 8
- Entity Framework
- PostgreSQL

Essa tecnologias são as estruturas principais para o funcionamento do app. 

<h3 id="Front"> Front-end</h3>

Para a criação do front-end de nosso app. utilizamos o React Native e TypeScript, uma combinação poderosa que une produtividade e qualidade. Essa abordagem permite criar apps nativos para iOS e Android a partir de um único código base, garantindo eficiência no desenvolvimento sem sacrificar performance.

O React Native serve como nosso alicerce principal - um framework criado pelo Facebook que revolucionou o desenvolvimento mobile. Ele funciona como uma ponte inteligente entre JavaScript e os componentes nativos de cada plataforma. Isso significa que escrevemos o código uma vez, mas o resultado final são aplicativos verdadeiramente nativos, não apenas "web apps embrulhados". A grande vantagem está na capacidade de reutilização de código, que pode chegar a 90% entre as plataformas, economizando tempo e recursos significativos.

TypeScript entra como nosso superpoder de desenvolvimento, adicionando tipagem estática ao JavaScript. Ele age como um assistente inteligente que previne erros antes mesmo de executarmos o código. Com seu sistema de tipos, conseguimos definir contratos claros para nossos dados e funções, tornando o código mais auto-documentado e menos propenso a falhas. A experiência de desenvolvimento se transforma - o editor passa a entender melhor nossa intenção, oferecendo autocompletar mais preciso e detectando problemas durante a escrita do código.

A arquitetura típica de um projeto React Native com TypeScript se organiza em camadas lógicas: os componentes visuais (que definem a interface do usuário), os gerenciadores de estado (que cuidam dos dados da aplicação), e os serviços (que lidam com comunicação externa como APIs). Essa separação clara de responsabilidades torna o código mais sustentável e fácil de testar. O React Native Navigation oferece soluções maduras para fluxos de telas complexos, enquanto bibliotecas como Redux ou Context API ajudam a gerenciar o estado global da aplicação.

Para o desenvolvimento prático, contamos com ferramentas excelentes. O Expo oferece um ecossistema completo que acelera o começo dos projetos, com suporte a diversos módulos nativos prontos para uso. Quando precisamos de mais controle, podemos migrar para o React Native "puro" e acessar funcionalidades específicas de cada plataforma. O Hot Reloading mantém nossa produtividade alta, mostrando mudanças no código quase instantaneamente no emulador ou dispositivo físico.

As vantagens dessa stack são impressionantes: desenvolvimento significativamente mais rápido que as abordagens nativas tradicionais, com performance próxima do nativo puro. A curva de aprendizado é suave, especialmente para desenvolvedores com experiência em React. O TypeScript reduz drasticamente erros comuns de JavaScript, enquanto mantemos toda a flexibilidade do ecossistema JavaScript. O resultado são aplicativos com código mais limpo, manutenção simplificada e maior confiabilidade.

Essa combinação representa o estado da arte no desenvolvimento mobile multiplataforma, equilibrando produtividade e performance de maneira excepcional. Ela permite desde a criação de protótipos rápidos até aplicativos complexos para produção, tudo com uma base de código compartilhada que reduz custos e tempo de desenvolvimento. Para equipes que já dominam JavaScript, a adoção é natural, e os benefícios em qualidade e velocidade de desenvolvimento são perceptíveis desde os primeiros projetos. 

<h3 id="Back"> Back-end</h3>

Para construção do back-end utilizamos uma API moderna de forma simples e eficiente usando as tecnologias mais recentes da Microsoft em conjunto com o banco de dados PostgreSQL. Essa combinação oferece uma solução completa para desenvolver sistemas robustos que se comunicam pela internet de maneira segura e organizada.

O coração do nosso sistema é o ASP.NET Core 8, a versão mais atualizada do framework da Microsoft para criar APIs web. Ele funciona como uma base sólida que nos permite definir todos os pontos de contato da nossa aplicação (os chamados endpoints), controlar quem pode acessar cada funcionalidade e garantir que a comunicação siga os padrões mais utilizados no mercado. Uma vantagem importante é que ele já vem com ferramentas que automaticamente documentam como a API funciona, poupando muito tempo de desenvolvimento.

Para trabalhar com os dados, usamos o Entity Framework, que age como um facilitador entre nosso código e o banco de dados. Em vez de escrever comandos complexos diretamente em SQL, podemos trabalhar com objetos simples no código - por exemplo, um objeto "Produto" que representa diretamente uma tabela no banco de dados. Isso torna o desenvolvimento mais intuitivo e menos propenso a erros, além de facilitar a manutenção futura do sistema.

O PostgreSQL entra como nosso repositório de dados confiável. Esse banco de dados gratuito e de código aberto é conhecido por sua estabilidade e capacidade de lidar com grandes volumes de informação. Ele mantém nossos dados organizados e seguros, permitindo desde armazenamento tradicional em tabelas até estruturas mais flexíveis como documentos JSON, tudo isso com garantia de consistência e disponibilidade.

Na estrutura do projeto, organizamos o código em camadas lógicas: uma parte cuida da comunicação com os usuários (recebendo e respondendo requisições), outra contém as regras específicas do negócio, e uma terceira gerencia o acesso ao banco de dados. Essa separação torna o sistema mais fácil de entender e modificar quando necessário. Além disso, implementamos um sistema de segurança baseado em tokens, que funcionam como credenciais digitais para controlar o acesso às funcionalidades.

As vantagens dessa abordagem são significativas: obtemos um sistema rápido desde o primeiro dia, com arquitetura preparada para crescer conforme a demanda aumenta. O desenvolvimento se torna mais ágil porque muitas funcionalidades básicas já estão incluídas no framework, enquanto o PostgreSQL garante que nossos dados permaneçam íntegros e disponíveis. Um exemplo prático seria uma API para gerenciar produtos, onde com poucas linhas de código podemos oferecer operações completas de cadastro, consulta e atualização - com o ASP.NET Core gerenciando as requisições, o Entity Framework interagindo com o banco de dados e o PostgreSQL armazenando tudo com eficiência.

Essa combinação de tecnologias forma uma base excelente para diversos tipos de aplicações, desde sistemas internos até plataformas abertas na internet. Ela equilibra simplicidade no desenvolvimento com robustez na operação, permitindo que nos concentremos em resolver problemas reais e entregar valor aos usuários finais, sem nos perdermos em complexidades técnicas desnecessárias. 

<h2 id="Modelo"> Modelo Fisico de Banco de Dados</h2>
<img src="Grupo 33 - 2.png">


<h2 id="colab"> Colaboradores e Contribuições</h2>

* [Danielle Rossetti Rodrigues](https://github.com/danieller) - Readme (GitHub)
* [Lana Ariza Obuti]() - Backend
* [Luis Felipe Lourenco](https://github.com/FelipeLourenc) - Landing page (GitHub) - Video
* [Mariana Dias Oliveira] - Landing page (Chamada para ação secundaria, seção de preços, rodapé, formulário de contato)
* [Gustavo Pereira Martins](https://github.com/gustapmartins) - Frontend
* [Helison Savio Ramos](https://github.com/HeliSaviON) - Frontend
* [Thales Shinji Sato](https://github.com/ThalesShinji) - Modelo Fisico de Banco de Dados 
* [Joao Wallace Leonel Pereira](https://github.com/wallaceleonel) - Backend

<h2 id="links"> Links do Projeto</h2>


