# 🎲 Jogo de Adivinhação em C#

Bem-vindo ao Jogo de Adivinhação! Este é um pequeno projeto em C# no qual o usuário precisa adivinhar um número secreto entre 1 e 10 em até 3 tentativas.

---

## 📜 Descrição

O objetivo do jogo é simples: você terá **3 tentativas** para adivinhar corretamente o número secreto. A cada tentativa, você digita um número de 1 a 10. Se acertar, vence o jogo. Caso contrário, o jogo continua até acabar as tentativas.

O programa também valida a entrada do usuário para garantir que apenas números inteiros sejam aceitos, evitando falhas por entradas inválidas.

---

## 🛠️ Tecnologias Utilizadas

- Linguagem: **C#**
- Framework: **.NET Console Application**
- Editor recomendado: **Visual Studio** ou **Visual Studio Code**

---

## 🚀 Como Executar o Projeto

1. **Clone este repositório:**
   ```bash
   git clone https://github.com/seu-usuario/nome-do-repositorio.git
   cd nome-do-repositorio

   

2. Abra o projeto:
	- Abra a pasta do projeto no Visual Studio ou VS Code.

3. Compile e execute:

- Se estiver usando o Visual Studio:

	-Pressione Ctrl + F5 para compilar e rodar o projeto.

- Se estiver usando VS Code:

	- Compile e execute com:
	  dotnet run
	

💻 Código Principal
```csharp
Aqui está a versão atualizada do código que inclui validação das entradas do usuário:

int numeroSecreto = 9; // número secreto
int chute; // chute do usuário
int tentativasRestantes = 3; // limite de tentativas

do
{
    Console.WriteLine($"Adivinhe o número secreto (entre 1 e 10). Tentativas restantes: {tentativasRestantes}");

    string entrada = Console.ReadLine();

    bool conversaoBemSucedida = int.TryParse(entrada, out chute);

    if (!conversaoBemSucedida)
    {
        Console.WriteLine("Entrada inválida! Por favor, digite um número inteiro.");
        continue; // não gasta tentativa
    }

    tentativasRestantes--;

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você adivinhou o número secreto: " + numeroSecreto);
        Console.ReadKey();
        return; // encerra o programa
    }
    else
    {
        Console.WriteLine("Você errou! Tente novamente.");
    }

}
while (tentativasRestantes > 0);

Console.WriteLine($"Você perdeu! O número secreto era: {numeroSecreto}");
Console.ReadKey();

```
🎯 Objetivos do Projeto:

✅ Praticar a linguagem C#
✅ Exercitar o uso de do-while, condicionais e variáveis
✅ Aprender a tratar exceções com int.TryParse()
✅ Criar um projeto simples, mas funcional, para praticar lógica de programação

🤝 Contribuição
Sinta-se à vontade para enviar pull requests ou abrir issues com melhorias, ideias ou correções!

📄 Licença
Este projeto está sob a licença MIT.

🚀 Divirta-se jogando e programando!