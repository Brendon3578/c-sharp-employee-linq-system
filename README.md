# Employee Linq Management System

Este projeto em C# foi desenvolvido para testar operações feita com o **LINQ (Language-Integrated Query, ou Consulta Integrada à Linguagem)** com o propósito de gerenciar e organizar informações de funcionários a partir de um arquivo CSV. O sistema lê dados de funcionários, realiza operações com LINQ para filtrar, agrupar, e calcular informações como salários e departamentos.

## 💻 Descrição

O programa de console **Employee Linq Management System** lê um arquivo CSV contendo informações de funcionários, como nome, e-mail, salário e departamento. Ele utiliza operações LINQ para realizar filtragens, cálculos de soma e agrupamento dos dados com base em diferentes parâmetros, como o departamento e o nome dos funcionários.

## 🔮 Funcionalidades

- **Leitura de Arquivo CSV**: O sistema lê um arquivo CSV contendo dados de funcionários e os desserializa, armazenando em uma lista de objetos `Employee`.
- **Filtragem de Salários**: Utiliza LINQ para filtrar funcionários com salários maiores que um determinado valor e ordena os resultados alfabeticamente.
- **Cálculo de Soma**: Calcula a soma dos salários de todos os funcionários cujo nome começa com a letra "M".
- **Agrupamento por Departamento**: Agrupa os funcionários por departamento e exibe a lista organizada por nome.

## 🛠️ Estrutura do Código

- **Classe `Employee`**: Representa um funcionário, contendo as propriedades do tipo *string* `Name`, `Email` e `Department` e a propriedade `Salary` do tipo *decimal*.
- **Classe `Program`**: Classe principal que contém a lógica de leitura do arquivo CSV, processamento dos dados com LINQ, e exibição das informações no console.

## 📂 Estrutura do CSV

O arquivo `employees-data.csv` deve seguir este formato:

```csv
Name;Email;Salary;Department
John Doe;john.doe@example.com;5500,00;Finance
Jane Smith;jane.smith@example.com;6200,50;Human Resources
```

## 🎈 Exemplo de Uso

Ao rodar o sistema, o programa lê o arquivo CSV e exibe:

1. A lista de funcionários com salário superior a 6.000, ordenados por nome.
2. A soma dos salários de funcionários cujo nome começa com "M".
3. O agrupamento dos funcionários por departamento, exibindo seus nomes e salários.

Exemplo de saída no console:

```
> Rows of the CSV File:
Employee { Name = John Doe, Email = john.doe@example.com, Salary = 5500, Department = Finance }

[@] Employees with salary greater than $ 6000:
{ Email = jane.smith@example.com, Salary = 6200,50 }

[@] The sum of employees with first letter 'm' is 13000.75

[@] Grouping employees by department:
-- [Category: Finance] --
{ Name = John Doe, Salary = 5500,00 }
```

## 🔧 Tecnologias Utilizadas

- **C#**
- **.NET 8.0**
- **LINQ** para consultas e operações com coleções de dados

---

<h3 align="center">
    Feito com ☕ por <a href="https://github.com/Brendon3578"> Brendon Gomes</a>
</h3>
