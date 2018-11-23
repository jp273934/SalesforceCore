import { Component, Input } from "@angular/core";
import { DataService } from "src/app/Shared/data.service";
import { IAccount } from "src/app/Accounts/account";

@Component({
    selector : 'accounts-list',
    templateUrl : '../Views/accounts.list.component.html'
})

export class AccountsListComponent { 
    public accounts;

    @Input()
    public selectedAccount : IAccount;

    constructor(private dataService : DataService) {}

    ngOnInit(){
        this.getAccounts();
    }
    
    private getAccounts()
    {
        this.dataService.getData('account').subscribe(data => {
            this.accounts = data;
        });
    }
}