import { NgModule } from "@angular/core";
import { FormsModule } from '@angular/forms';
import { CommonModule } from "@angular/common";
import { OpprotunityComponent } from "./Components/opportunity.component";
import { AccountsListComponent } from "./Components/accounts.list.component";
import { AccountService } from "../Accounts/accounts.service";

@NgModule({
    imports : [ CommonModule, FormsModule ],
    declarations : [ OpprotunityComponent, AccountsListComponent ],
    exports : [ OpprotunityComponent ],
    providers : [ AccountService ]
})

export class OpportunityModule { }