using Contacts.UseCases.Interfaces;
using Contacts.UseCases.PluginInterfaces;
using System.Security.Cryptography.X509Certificates;
using Contact = Contacts.CoreBusiness.Contact;

namespace Contacts.UseCases
{
    // All the code in this file is included in all platforms.
    public class ViewContactsUseCase : IViewContactsUseCase
    {
        private readonly IContactRepository contactRepository;
        public ViewContactsUseCase(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }
        public async Task<List<Contact>> ExecuteAsync(string query)
        {
            return await this.contactRepository.GetContactsAsync(query);
        }
    }
}