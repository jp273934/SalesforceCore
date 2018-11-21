import { Component } from "@angular/core";
import { DataService } from "../Shared/data.service";

@Component({
    selector : 'contacts',
    templateUrl : './contacts.component.html'
})

export class ContactsComponent {
    public contacts;

    constructor( private dataService : DataService){}
    
    ngOnInit(){
        this.getContacts();
    }
    
    getContacts(){
        this.dataService.getData('contact').subscribe(data => {
            this.contacts = data;
        })
    }
}