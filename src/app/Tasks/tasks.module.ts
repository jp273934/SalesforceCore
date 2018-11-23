import { NgModule } from "@angular/core";
import { TasksComponent } from "./tasks.component";
import { CommonModule } from "@angular/common";

@NgModule({
    imports : [ CommonModule ],
    declarations : [ TasksComponent],
    exports : [ TasksComponent ]
})

export class TasksModule { }