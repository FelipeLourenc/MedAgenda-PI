# 🏥 MedAgenda API

Esta é uma API RESTful construída com **ASP.NET Core 8** e **Entity Framework Core**, conectada a um banco de dados **PostgreSQL**. A aplicação gerencia recursos de uma clínica médica (como pacientes, agendamentos etc.) e está preparada para ser implantada em ambientes como o [Render](https://render.com/).

## 🚀 Como executar o projeto localmente

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [PostgreSQL](https://www.postgresql.org/download/)
- (Opcional) [Docker](https://www.docker.com/) para rodar o banco de dados

### 1. Clone o repositório

```bash
git clone https://github.com/seu-usuario/medagenda-api.git
cd medagenda-api
```

### 2. Configure a string de conexão

No arquivo `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=medagenda;Username=postgres;Password=senha"
  }
}
```

> 📝 Altere o host, database, username e password conforme necessário.

### 3. Execute as migrações

```bash
dotnet ef database update
```

Ou simplesmente rode o projeto (as migrações são aplicadas automaticamente).

### 4. Execute o projeto

```bash
dotnet run
```

A aplicação estará disponível em:

```
https://localhost:5001
http://localhost:5000
```

## 🧠 Funcionamento da aplicação

O `Program.cs` executa as seguintes tarefas:

1. **Registra o DbContext com PostgreSQL**
2. **Adiciona suporte a controllers**
3. **Habilita Swagger em ambiente de desenvolvimento**
4. **Aplica migrações automaticamente ao iniciar**
5. **Define as rotas dos controllers**
6. **Redireciona HTTP para HTTPS**

### Exemplo (`Program.cs`):

```csharp
builder.Services.AddDbContext<ClinicaContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ClinicaContext>();
    db.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
```

> 🔧 Se quiser que o Swagger funcione também em produção (ex: Render), remova o `if (app.Environment.IsDevelopment())` e mantenha `app.UseSwagger()` e `app.UseSwaggerUI()` sempre ativos.

## 📚 Documentação via Swagger

Após iniciar o projeto, acesse:

```
http://localhost:5000/swagger
```

> Em produção (ex: Render):  
> `https://seu-app.onrender.com/swagger`

## 🗂 Estrutura do Projeto

```
├── Controllers/
│   └── PacientesController.cs
├── Data/
│   └── ClinicaContext.cs
├── Models/
│   └── Paciente.cs
├── Migrations/
├── Program.cs
├── appsettings.json
└── README.md
```

## ☁️ Deploy no Render

1. Suba seu repositório para o GitHub.
2. Acesse [Render.com](https://render.com) e crie um novo Web Service.
3. Configure:
   - **Build Command:** `dotnet build`
   - **Start Command:** `dotnet MedAgenda.dll`
4. Adicione variável de ambiente:
   - `ConnectionStrings__DefaultConnection` com sua string de conexão PostgreSQL.
5. Salve e aguarde a publicação.

> ❗ Importante: certifique-se que `UseSwagger()` e `UseSwaggerUI()` estão fora do `if (app.Environment.IsDevelopment())` para que o Swagger funcione em produção.

## 🧪 Exemplo de endpoint

```http
GET /api/pacientes
```

### Exemplo de Controller:

```csharp
[ApiController]
[Route("api/[controller]")]
public class PacientesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Lista de pacientes");
}
```

## 📃 Licença

Este projeto está sob a licença MIT. Veja o arquivo `LICENSE` para mais informações.

## 🤝 Contribuições

Pull requests são bem-vindos! Sinta-se à vontade para propor melhorias, correções ou novas funcionalidades.
