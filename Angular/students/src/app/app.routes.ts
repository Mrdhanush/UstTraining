// app.routes.ts
import { Routes } from '@angular/router';
import { AddNewComponent } from './Pages/addnew/addnew.component';
import { UpdateComponent } from './Pages/update/update.component';
import { DetailsComponent } from './Pages/details/details.component';
import { DeleteComponent } from './Pages/delete/delete.component';
import { ListComponent } from './Pages/list/list.component';
import { PageNotFoundComponent } from './Pages/page-not-found/page-not-found.component';

export const routes: Routes = [
  { path: '', redirectTo: 'list', pathMatch: 'full' },
  { path: 'list', component: ListComponent },
  { path: 'addnew', component: AddNewComponent },
  { path: 'details', component: DetailsComponent },
  { path: 'update', component: UpdateComponent },
  { path: 'delete', component: DeleteComponent },
  { path: '**', component: PageNotFoundComponent }, 
];
