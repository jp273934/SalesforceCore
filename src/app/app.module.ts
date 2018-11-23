import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AccountsModule } from './Accounts/accounts.module';
import { AppComponent } from './app.component';
import { DataService } from './Shared/data.service';
import { ContactsModule } from './Contacts/contacts.module';
import { RouterModule } from '@angular/router';
import { routes } from './Shared/app.routes';
import { TasksModule } from './Tasks/tasks.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, AccountsModule, HttpClientModule, ContactsModule, RouterModule.forRoot(routes), TasksModule
  ],
  providers: [ DataService ],
  bootstrap: [AppComponent]
})
export class AppModule { }
