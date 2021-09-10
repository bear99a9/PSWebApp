export interface Product {
    id: number;
    category: string;
    size: string;
    price: number;
    title: string;
    artDescription: string;
    artDating: string;
    artId: string;
    artist: string;
    artistBirthDate: Date;
    artistDeathDate: Date;
    artistNationality: string;
}

//constructor(
//    public id: number = -1,
//    public category: string = "Null",
//    public size: string = "Null",
//    public price: number = 0,
//    public title: string = "Null",
//    public artDescription: string = "Null",
//    public artDating: string = "Null",
//    public artId: string = "Null",
//    public artist: string = "Null",
//    public artistBirthDate: Date = new Date(),
//    public artistDeathDate: Date = new Date(),
//    public artistNationality: string = "Null") { }
