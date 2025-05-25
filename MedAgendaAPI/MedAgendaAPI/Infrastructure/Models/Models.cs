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
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public UserRole Role { get; set; }

        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
    }

    public class Medico
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string NomeMedico { get; set; }
        public int CrmNum { get; set; }
        public string Especialidade { get; set; }

        public User User { get; set; }
        public ICollection<Consulta> Consultas { get; set; }
    }

    public class Paciente
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Documento { get; set; }
        public string Email { get; set; }

        public User User { get; set; }
        public ICollection<Consulta> Consultas { get; set; }
        public ICollection<Exame> Exames { get; set; }
    }

    public class Consulta
    {
        public int Id { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public DateTime DataHora { get; set; }
        public string Unidade { get; set; }
        public string Especialidade { get; set; }

        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
    }

    public class Exame
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public string Unidade { get; set; }
        public DateTime Data { get; set; }

        public Paciente Paciente { get; set; }
    }

    public class ClinicaConsulta
    {
        public int Id { get; set; }
        public string NomeClinica { get; set; }
        public string Email { get; set; }
        public string Unidade { get; set; }
        public string Endereco { get; set; }
    }

    public class ClinicaExame
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
    }

    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
