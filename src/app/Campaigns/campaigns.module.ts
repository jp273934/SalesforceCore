import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { CampaignsComponent } from "./campaigns.component";

@NgModule({
    imports : [ CommonModule],
    declarations : [ CampaignsComponent ],
    exports : [ CampaignsComponent]
})

export class CampaignsModule { }