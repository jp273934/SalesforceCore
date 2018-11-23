import { Routes } from '@angular/router';
import { AccountsComponent } from '../Accounts/accounts.component';
import { ContactsComponent } from '../Contacts/contacts.component';
import { TasksComponent } from '../Tasks/tasks.component';

export const routes : Routes = [
    { path : '', component : AccountsComponent},
    { path: 'contacts', component : ContactsComponent},
    { path: 'tasks', component : TasksComponent}
];