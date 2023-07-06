import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { ServicioService, ServicioDTO, TipoDeServicio } from '@proxy/servicios';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ConfirmationService,Confirmation  } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-servicio',
  templateUrl: './servicio.component.html',
  styleUrls: ['./servicio.component.scss'],
  providers: [ListService],
})
export class ServicioComponent implements OnInit {
  servicio = { items: [], totalCount: 0 } as PagedResultDto<ServicioDTO>;
  isModalOpen = false;

  selectedServicio = {} as ServicioDTO; // declare selectedBook

  form: FormGroup;
  ServicioType = Object.entries(TipoDeServicio)
    .slice(0, 7)
    .map(([key, value]) => ({ key, value }));
  
  constructor(
    public readonly list: ListService,
    private servicioService: ServicioService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService
  ) {}

  ngOnInit() {
    const servicioStreamCreator = (query) =>
      this.servicioService.getList(query);
      this.list.hookToQuery(servicioStreamCreator).subscribe((response) => {
      this.servicio = response;
    });

    this.buildForm();
  }

  createServicio() {
    this.selectedServicio = {} as ServicioDTO; // reset the selected book
    this.buildForm();
    this.isModalOpen = true;
  }

  // Add editBook method
  editServicio(id: string) {
    this.servicioService.get(id).subscribe((servicio) => {
      this.selectedServicio = servicio;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  buildForm() {
    this.form = this.fb.group({
      nombre: [this.selectedServicio.nombre || "", Validators.required],
      descripcion: [this.selectedServicio.descripcion || "", Validators.required],
      precio: [this.selectedServicio.nombre || null , Validators.required],
      duracion: [this.selectedServicio.nombre || null, Validators.required],
      tipoDeServicio: [this.selectedServicio.nombre || null, Validators.required],
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }
    const request = this.selectedServicio.id
      ? this.servicioService.update(this.selectedServicio.id, this.form.value)
      : this.servicioService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }

  delete(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.servicioService.delete(id).subscribe(() => this.list.get());
      }
    });
  }
}
