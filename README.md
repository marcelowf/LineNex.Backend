<br>
<br>
<p align="center">
  <a href="https://github.com/marcelowf/Svg-Icon-Repo/">
    <img loading="lazy" alt="LineNex" src="https://raw.githubusercontent.com/marcelowf/Svg-Icon-Repo/main/LineNexLogoCut.png" width="80%"/>
  </a>
</p>
<br>
<br>

[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/) [![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=dask&logoColor=white)](https://www.microsoft.com/en-us/sql-server) [![Azure](https://img.shields.io/badge/Azure-0078D4?style=for-the-badge&logo=&logoColor=white)](https://azure.microsoft.com/) [![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)](https://git-scm.com/) [![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)](https://www.docker.com/) [![Terraform](https://img.shields.io/badge/Terraform-623CE4?style=for-the-badge&logo=terraform&logoColor=white)](https://www.terraform.io/) [![Azure DevOps](https://img.shields.io/badge/Azure%20DevOps-0078D7?style=for-the-badge&logo=&logoColor=white)](https://azure.microsoft.com/services/devops/) [![Prometheus](https://img.shields.io/badge/Prometheus-E6522C?style=for-the-badge&logo=prometheus&logoColor=white)](https://prometheus.io/) [![Grafana](https://img.shields.io/badge/Grafana-F46800?style=for-the-badge&logo=grafana&logoColor=white)](https://grafana.com/) [![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)](https://swagger.io/) [![xUnit](https://img.shields.io/badge/xUnit-00B5A3?style=for-the-badge&logo=task&logoColor=white)](https://xunit.net/) [![Cucumber](https://img.shields.io/badge/Cucumber-23D96C?style=for-the-badge&logo=cucumber&logoColor=white)](https://cucumber.io/) [![SonarAnalyzer](https://img.shields.io/badge/SonarAnalyzer-c42423?style=for-the-badge&logo=sonarqubeserver&logoColor=white)](https://docs.sonarsource.com/sonaranalyzer/latest/) [![OpenTelemetry](https://img.shields.io/badge/OpenTelemetry-0072CE?style=for-the-badge&logo=opentelemetry&logoColor=white)](https://opentelemetry.io/)

### 🚀 **Sobre o Projeto**  

O LineNex Backend é o núcleo lógico da solução LineNex, encarregado de processar, centralizar e expor dados operacionais capturados nas linhas de produção. Sua principal função é automatizar fluxos industriais e fornecer APIs para apoiar a tomada de decisões estratégicas com base em dados em tempo real.

---

#### 🔧 Pré-requisitos

- .NET SDK 9.0
- Docker e Docker Compose
- Azure CLI
- Acesso a uma assinatura Azure
- Git

---

## ⚙️ Configuração do Ambiente

Siga estes passos para configurar seu ambiente de desenvolvimento:

1. **Clonar repositório:**
    Clone este repositório em sua máquina local.
2. **Variáveis de Ambiente / Secrets:**
    No projeto LineNex.Api, edite o arquivo appsettings.json para configurar as variáveis necessárias, como strings de conexão e chaves de serviços externos. Alternativamente, você pode modificar as referências ao Azure Key Vault diretamente no arquivo Program.cs.
3. **Banco de Dados:**
    Aplique as migrações do Entity Framework Core localmente para preparar o banco de dados:

    ```bash
    cd LineNex.Api
    dotnet ef database update
    ```

---

#### 📌 **Como Rodar o Projeto**  

##### ➡️ **Executando Localmente**  

```bash
cd LineNex.Api  
dotnet run
```

##### 🐳 Executando com Docker

```bash
docker-compose up
```

##### 🧪 Executando os Testes

```bash
dotnet test
```

---

#### 🧰 CI/CD

O LineNex utiliza Azure DevOps Pipelines para automatizar o processo de CI/CD usando os arquivos yml localizados em Configuration.AzureDevOps/

---

#### 📝 Licença

Este projeto está sob a licença MIT. Consulte o arquivo LICENSE para mais detalhes.

#### 👤 Autores e Contato

LinkedIn: [Marcelo Wzorek Filho](https://www.linkedin.com/in/marcelo-wzorek-filho-132228255/)
E-mail: <marcelo.projects.dev@gmail.com>
GitHub: [marcelowf](https://github.com/marcelowf)

#### 🏷️ Tags

`LineNex` `Produção Industrial` `IoT` `Monitoramento` `Automação` `Azure` `.NET` `DDD` `Docker` `Terraform` `Prometheus` `Grafana` `Swagger` `CI/CD` `xUnit` `Cucumber` `SonarAnalyzer` `OpenTelemetry`
