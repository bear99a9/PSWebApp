import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Data } from "@angular/router";
import { map } from "rxjs/operators";

@Injectable()

export class Store {

    constructor(private http: HttpClient) {

    }

    public products: {
        id: number; category: string; size: string; artDescription: string; artDating: string; artId: string;
        artisit: string; artistNationality: string; title: string; price: string; artistBirthDate: Date; artistDeathDate: Date;
    }[] = [];

    loadProducts() {
        return this.http.get<[]>('/api/products')
            .pipe(map(data => {
                this.products = data;
                return;
            }));
    }

}
