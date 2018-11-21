import { Component } from '@angular/core';
import { DataService } from '../Shared/data.service';

@Component({
    selector : 'accounts',
    templateUrl : './accounts.component.html'
})

export class AccountsComponent {
    public accounts;

    constructor(private dataService : DataService) { }

    ngOnInit() {
        this.getAccounts();
    }
    
    getAccounts() {
        this.dataService.getData('account').subscribe( data => {
            this.accounts = data;
        })
    }
}