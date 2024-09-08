namespace LHPet.Models;


public class Cliente{

    public int ClienteId { get; set; }
    public string ClienteName { get; set; }
    public string ClienteCpf { get; set; }
    public string ClienteEmail { get; set; }
    public string ClientePaciente { get; set; }
    public Cliente(int id, string name, string cpf, string email, string paciente) {
        this.ClienteId = id;
        this.ClienteName = name;
        this.ClienteCpf = cpf;
        this.ClienteEmail = email;
        this.ClientePaciente = paciente;
         }
    
}
