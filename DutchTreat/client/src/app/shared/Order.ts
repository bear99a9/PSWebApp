import { OrderItem } from "./OrderItem";

export class Order {
    constructor(orderId: number = 1,
        orderNumber: string = "1",
    ) { }
    orderDate: Date = new Date();
    items: OrderItem[] = [];
}