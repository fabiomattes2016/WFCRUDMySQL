using Flunt.Notifications;
using Flunt.Validations;
using WFCRUDMySQL.Model;

namespace API.ViewModels
{
    public class UpdateContatoViewModel : Notifiable<Notification>
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }

        public Contato MapTo()
        {

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNull(Nome, "Informe o nome")
                .IsGreaterThan(Nome, 5, "O nome deve conter mais de 5 caracteres"));

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNull(Email, "Informe o e-mail")
                .IsGreaterThan(Email, 5, "O email deve conter mais de 5 caracteres"));

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNull(Telefone, "Informe o telefone")
                .IsGreaterThan(Telefone, 5, "O telefone deve conter mais de 5 caracteres"));

            return new Contato(Id, Nome, Email, Telefone);
        }
    }
}
