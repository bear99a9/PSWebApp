export class OrderItem {
    constructor(
        public id: number = -1,
        public quantity: number = -1,
        public unitPrice: number = -1,
        public productId: number = -1,
        public productCategory: string = "Null",
        public productSize: string = "Null",
        public productTitle: string = "Null",
        public productArtist: string = "Null",
        public productArtId: string =  "Null") {}
}