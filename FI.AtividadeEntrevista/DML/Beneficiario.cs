namespace FI.AtividadeEntrevista.DML
{
    /// <summary>
    /// Classe de Beneficiario que representa o registo na tabela Beneficiario do Banco de Dados
    /// </summary>
    public class Beneficiario
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Cpf
        /// </summary>
        public string Cpf { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// IdCliente
        /// </summary>
        public string IdCliente { get; set; }

        public Cliente Cliente { get; set; }
    }    
}
