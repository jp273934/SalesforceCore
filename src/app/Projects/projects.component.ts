import { Component } from "@angular/core";
import { DataService } from "../Shared/data.service";

@Component({
    selector : 'projects',
    templateUrl : './projects.component.html'
})

export class ProjectsComponent {
    public projects;

    constructor(private dataService : DataService) {}
    
    ngOnInit()
    {
        this.getProjects();
    }
    
    private getProjects()
    {
        this.dataService.getData('project').subscribe(data => {
            this.projects = data;
        })
    }
}