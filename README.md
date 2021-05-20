<div align="center">
  <h1>
    <SavingSystem>
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

- This is an open-source saving system to Unity made in C#.

### 🛠 Technologies

The following tools were used in the construction of the project:
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [Unity](https://unity.com)

### 🚀 How to Use

#### 1. Create the "SavingSystem" object
  <p>Create a GameObject on your scene and add the "SavingSystem" component to it.</p>
  <img src="./images/savingSystemObject.png" alt="Saving System Object" width="500" />

#### 2. Add the "SaveableEntity" component
  <p>Add the "SaveableEntity" component to the for the GameObjects you want to save the data and dont modify the ID property.</p>
  <img src="./images/saveableObject.png" alt="Saveable object" width="500" />

#### 3. Implement the "ISaveable" interface
   <p>Add the "ISaveable" interface to the classes you want to store data and then implement the interface. On the "CaptureState()" method you need to return the data you want to save and on the "RestoreState()" you want to deal with this data.</p>
   <img src="./images/position.png" alt="Saveable object" width="500" />

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