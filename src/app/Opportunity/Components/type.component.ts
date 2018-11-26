import { Component, Output } from "@angular/core";
import { EventEmitter } from "events";

@Component({
    selector : 'type',
    templateUrl : '../Views/type.component.html'
})

export class TypeComponent {

    @Output()
    typeSelected = new EventEmitter<string>();
    
    public selectType(type : string)
    {

    }
}