import {ConfigurationService} from "../modules/configuration/services/configuration.service";
import {OtherFeeAdapter} from "../model-adapter/other-fee.adapter";
import {OtherFeeRequest} from "../models/request/other-fee.request";
import {from, Observable} from "rxjs";
import {map} from "rxjs/operators";
import {OtherFeeModel} from "../models/other-fee.model";
import axios, {AxiosHeaders} from "axios/index";
import {AxiosResponse} from "axios";

const httpOptions = {
  headers: new AxiosHeaders({
    'Content-Type': 'application/json',
  })
};

export class OtherFeeServiceRepository {

  private configuration: any;
  endpoints = {
    createOtherFee: () => this.configuration.server.host + `student-taxes/create-other-fee`,
    updateOtherFee: (id: number) => this.configuration.server.host + `student-taxes/other-fee/${id}`,
    deleteOtherFee: (id: number) => this.configuration.server.host + `student-taxes/other-fee/${id}`,
    getOtherFees: () => this.configuration.server.host + `student-taxes/other-fees`
  };

  constructor(
    private configurationService: ConfigurationService,
    private otherFeeAdapter: OtherFeeAdapter
  ) {
    this.configuration = this.configurationService.getConfig();
  }

  createOtherFee(otherFeeRequest: OtherFeeRequest) {
    return from(axios.post(this.endpoints.createOtherFee(), otherFeeRequest, httpOptions));
  }

  updateOtherFee(id: number, otherFeeRequest: OtherFeeRequest) {
    return from(axios.put(this.endpoints.updateOtherFee(id), otherFeeRequest, httpOptions));
  }

  deleteOtherFee(id: number) {
    return from(axios.delete(this.endpoints.deleteOtherFee(id), httpOptions));
  }

  getOtherFees(): Observable<Array<OtherFeeModel>> {
    return from(axios.get(this.endpoints.getOtherFees(), httpOptions))
      .pipe(
        map((response: AxiosResponse<any>) =>
          response.data.map((otherFee: any) => {
            return this.otherFeeAdapter.adapt(otherFee);
          })
        )
      );
  }
}
