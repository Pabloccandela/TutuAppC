import type { CreateUpdateServicioDTO, ServicioDTO } from './models';
import { RestService, Rest } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ServicioService {
  apiName = 'Default';
  

  create = (input: CreateUpdateServicioDTO, config?: Partial<Rest.Config>) =>
    this.restService.request<any, ServicioDTO>({
      method: 'POST',
      url: '/api/app/servicio',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/servicio/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, ServicioDTO>({
      method: 'GET',
      url: `/api/app/servicio/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedAndSortedResultRequestDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<ServicioDTO>>({
      method: 'GET',
      url: '/api/app/servicio',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: string, input: CreateUpdateServicioDTO, config?: Partial<Rest.Config>) =>
    this.restService.request<any, ServicioDTO>({
      method: 'PUT',
      url: `/api/app/servicio/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
