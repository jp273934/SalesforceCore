import { Component } from "@angular/core";
import { IAccount } from "src/app/Accounts/account";
import { AccountService } from "src/app/Accounts/accounts.service";

@Component({
    selector : 'opportunity',
    templateUrl : '../Views/opportunity.component.html'
})

export class OpprotunityComponent { 
    public account : IAccount;
    public stepIndex : number;

    constructor(private accountService : AccountService) 
    {
        this.account = accountService.getDefaultAccount();
        this.stepIndex = 1;
    }
}