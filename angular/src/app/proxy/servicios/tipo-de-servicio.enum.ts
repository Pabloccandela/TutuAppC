import { mapEnumToOptions } from '@abp/ng.core';

export enum TipoDeServicio {
  Indefinido = 0,
  Estetica = 1,
  Salud = 2,
  Consultoria = 3,
  SoporteTécnico = 4,
  Mantenimiento = 5,
  Entrenamiento = 6,
}

export const tipoDeServicioOptions = mapEnumToOptions(TipoDeServicio);
