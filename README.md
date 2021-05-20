<<<<<<< HEAD
<div align="center">
  <h1>
    <REPO_NAME>
  </h1>
  <blockquote>
    <REPO_SHORT_DESCRIPTION>
  </blockquote>
  <div id="badges">
    <img src="https://img.shields.io/github/repo-size/serjolas1/SavingSystem?color=4000FF" alt="repo-size" />
    <img src="https://img.shields.io/github/issues-raw/serjolas1/SavingSystem?color=4000FF" alt="issues" />
    <img src="https://img.shields.io/badge/license-MIT-4000FF" alt="license" />
  </div>
</div>

## Tabela de conteúdos

   * [About the Project](#-sobre-o-projeto)
      - [Tecnologias](#-tecnologias)
      - [Como executar](#-como-executar)
   * [Como contribuir](#-como-contribuir)
   * [Licença](#-licença)

## 💻 Sobre o projeto

<SavingSystem> - <This is an open-source saving system to Unity made in C#.>

### 🛠 Technologies

As seguintes ferramentas foram usadas na construção do projeto:
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [Unity](https://unity.com)

### 🚀 How to Use

1. Create the "SavingSystem" object
   ```md
    Create a GameObject on your scene and add the "SavingSystem" component to it
   ```
    <img src="./images/savingSystemObject.png" alt="Saving System Object" width="300" />

2. Instale as dependências
   ```bash
   cd <REPO_NAME>
   yarn install
   ```

3. Rode a aplicação
   ```bash
   yarn start
   ```

## 🤝 Como contribuir

Todo tipo de contribuição é bem-vinda, nós admiramos isso!

Tem algum problema? Encontrou um bug? Tem alguma dica? Abra uma [issue](https://github.com/carlos3g/<REPO_NAME>/issues) descrevendo.

Quer contribuir com código? Pedimos que antes leia [este guia de contribuição](https://github.com/firstcontributions/first-contributions)

Não esqueça de deixar a sua ⭐, também é um modo de contribuir com o projeto ;)

## 📝 Licença

Esse projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---
<div align="center">

  Criado por [Carlos Mesquita](https://github.com/carlos3g) 💜

</div>
=======
# SavingSystem
 This is an open-source saving system to Unity made in C#.

<h3> How to Use </h3>

<p>
first you need to add a GameObject and add the class "SavingSystem" to it, then add the class "SaveableEntity" to the object you want to save data to and add the interface "ISaveable" to the classes you want to save data to. Then just implement the "ISaveable" interface by returning the information you want to save in the "CaptureState ()" mathod and using that information in the "RestoreState ()" method.
</p>

>>>>>>> 4d377367f7933fbffb993d8eaf3731a78a4b003b
