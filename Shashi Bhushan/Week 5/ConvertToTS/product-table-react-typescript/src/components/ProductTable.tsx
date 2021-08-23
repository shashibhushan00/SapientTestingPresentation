import '../style/ProductTable.css'

import IProduct from "../models/IProduct";
import { ProductRow } from "./ProductRow";
import { IProductTableProps } from "../models/IProductTableProps";

export const ProductTable: React.FunctionComponent<IProductTableProps> = (props) => {

    let productRowComponentArray: JSX.Element[] = [];
    let _products: IProduct[] = props.products;
    _products.forEach(product => {
        productRowComponentArray.push(<ProductRow product={product} key={product.id} />);
    });

    return (
        <div>
            <table>
                <thead>
                    <tr>
                        <th>Product ID</th>
                        <th>Product Name</th>
                        <th>Product Price</th>
                    </tr>
                </thead>
                <tbody>
                    {productRowComponentArray}
                </tbody>
            </table>
        </div>
    );

}