import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { OpprotunityComponent } from "./Components/opportunity.component";

@NgModule({
    imports : [ CommonModule ],
    declarations : [ OpprotunityComponent ],
    exports : [ OpprotunityComponent ]
})

export class OpportunityModule { }