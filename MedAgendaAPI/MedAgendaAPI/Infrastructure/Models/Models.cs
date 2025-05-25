namespace ClinicaAPI.Models
{
    public enum UserRole
    {
        Medico = 1,
        Paciente = 2,
        Admin = 3
    }

    public class User
    {
        public int Id { get; set; }                 // PK int
        public string Nome { get; set; }            // Nome completo
        public string Email { get; set; }
        public string Senha { get; set; }
        public UserRole Role { get; set; }
    }

    public class Medico
    {
        public int MedId { get; set; }              // PK
        public int UserId { get; set; }             // FK para User
        public string NomeMedico { get; set; }
        public int CrmNum { get; set; }
        public string Especialidade { get; set; }

        public User User { get; set; }              // Navegação
    }

    public class Paciente
    {
        public int PacienteId { get; set; }         // PK
        public int UserId { get; set; }              // FK para User
        public string Nome { get; set; }            
        public int Idade { get; set; }
        public int Documento { get; set; }           
        public string Email { get; set; }

        public User User { get; set; }               // Navegação
    }

    public class Consulta
    {
        public int ConsultaId { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public DateTime DataHora { get; set; }
        public string Unidade { get; set; }
        public string Especialidade { get; set; }
        public int Exames { get; set; }              
    }

    public class Exame
    {
        public int ExameId { get; set; }
        public int PacienteId { get; set; }          // FK para Paciente
        public string Unidade { get; set; }
        public DateTime Data { get; set; }
    }

    public class ClinicaConsulta
    {
        public int ClinicaId { get; set; }           // PK para consistência
        public string NomeClinica { get; set; }
        public string Email { get; set; }
        public string Unidade { get; set; }
        public string Endereco { get; set; }
    }

    public class ClinicaExame
    {
        public int IdTipo { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
    }

    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
