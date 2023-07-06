import type { TipoDeServicio } from './tipo-de-servicio.enum';
import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateServicioDTO {
  nombre: string;
  descripcion: string;
  precio: number;
  duracion: number;
  tipoDeServicio: TipoDeServicio;
}

export interface ServicioDTO extends AuditedEntityDto<string> {
  nombre?: string;
  descripcion?: string;
  precio: number;
  duracion: number;
  tipoDeServicio: TipoDeServicio;
}
