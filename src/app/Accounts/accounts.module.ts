import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AccountsComponent } from './accounts.component';

@NgModule({
    imports : [CommonModule],
    declarations : [AccountsComponent ],
    exports : [ AccountsComponent ]
})

export class AccountsModule {}