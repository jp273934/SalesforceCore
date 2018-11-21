import { Routes } from '@angular/router';
import { AccountsComponent } from '../Accounts/accounts.component';
import { ContactsComponent } from '../Contacts/contacts.component';

export const routes : Routes = [
    { path : '', component : AccountsComponent},
    { path: 'contacts', component : ContactsComponent}
];