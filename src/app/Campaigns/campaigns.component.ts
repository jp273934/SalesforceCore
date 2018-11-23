import { Component } from "@angular/core";
import { DataService } from "../Shared/data.service";

@Component({
    selector : 'campaigns',
    templateUrl : './campaigns.component.html'
})

export class CampaignsComponent {
    public campaigns;

    constructor(private dataService : DataService){}

    ngOnInit()
    {
        this.getCampaigns();
    }
   
    private getCampaigns()
    {
        this.dataService.getData('campaign').subscribe(data => {
            this.campaigns = data;
        })
    }
}