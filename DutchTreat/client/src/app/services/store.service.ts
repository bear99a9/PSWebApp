import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";
import { Order } from "../shared/Order";
import { OrderItem } from "../shared/OrderItem";
import { Product } from "../shared/Product";

@Injectable()

export class Store {

    constructor(private http: HttpClient) {

    }

    public products: Product[] = [];
    public order: Order = new Order();

    loadProducts() : Observable<void> {
        return this.http.get<[]>('/api/products')
            .pipe(map(data => {
                this.products = data;
                return;
            }));
    }

    addToOrder(product: Product) {

        const newItem = new OrderItem();
        newItem.productId = product.id;
        newItem.productTitle = product.title;
        newItem.productArtist = product.artist;
        newItem.productArtId = product.artId;
        newItem.productCategory = product.category;
        newItem.productSize = product.size;
        newItem.unitPrice = product.price;
        newItem.quantity = 1;

        this.order.items.push(newItem);
    }
}
