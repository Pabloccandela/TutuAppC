import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';

import { ServicioRoutingModule } from './servicio-routing.module';
import { ServicioComponent } from './servicio.component';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    ServicioComponent
  ],
  imports: [
    ReactiveFormsModule,
    SharedModule,
    ServicioRoutingModule
  ]
})
export class ServicioModule { }
