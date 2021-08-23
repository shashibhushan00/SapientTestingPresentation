import IProduct from "./IProduct";

export default interface IProductTableContainerState {
    isLoaded: boolean;
    products: IProduct[];
    error?: any;
}