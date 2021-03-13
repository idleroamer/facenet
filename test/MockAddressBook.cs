using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Tmds.DBus;

namespace Tests.AddressBook
{
    public class AddressBook : AddressBookDBusAdapter
    {
        public Task mockCreateNewContactAsync(contactCreatedArgs contactCreatedArg)
        {
            EmitcontactCreated(contactCreatedArg);
            return Task.CompletedTask;
        }

        public contactCreatedArgs lastCreatedContact;
        public override Task createNewContactAsync()
        {
            return Task.Run( () => {
                EmitcontactCreated(lastCreatedContact);
                return Task.CompletedTask;
                                   } );
        }
        public override Task selectContactAsync(int contactId)
        {
            return Task.Run( () => { 
                                   } );
        }
        public override Task<bool> deleteContactAsync(int contactId)
        {
            return Task.FromResult(true);
        }
        public override Task updateContactAsync(int contactId, Contact contact)
        {
            return Task.Run( () => { 

                                   } );
        }

        public Task<bool> blacklistContactAsync(Nested blackList)
        {
            return Task.FromResult(true);
        }

    }
}