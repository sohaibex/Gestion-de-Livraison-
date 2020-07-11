import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from './core/guards/auth.guard';
import { LayoutComponent } from './layouts/layout.component';
import { ClientsParComponent } from './components/clients-par/clients-par.component';

const routes: Routes = [
  { path: 'account', loadChildren: () => import('./account/account.module').then(m => m.AccountModule) },
  // tslint:disable-next-line: max-line-length
  { path: '', component: LayoutComponent, loadChildren: () => import('./pages/pages.module').then(m => m.PagesModule), canActivate: [AuthGuard] },
  { path: '', component: LayoutComponent, loadChildren: () => import('./components/clients-par/client.module').then(m => m.ClientModule), canActivate: [AuthGuard] },
  { path: '', component: LayoutComponent, loadChildren: () => import('./components/commandes/commandes.module').then(m => m.CommandesModule), canActivate: [AuthGuard] },
  { path: '', component: LayoutComponent, loadChildren: () => import('./components/livreurs/livreurs.module').then(m => m.LivreursModule), canActivate: [AuthGuard] },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { scrollPositionRestoration: 'top' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
