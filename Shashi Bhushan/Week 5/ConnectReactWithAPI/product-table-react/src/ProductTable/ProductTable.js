import { ProductRow } from "./ProductRow";

export function ProductTable(props) {

    let productRowComponentArray = [];
    let _products = props.products;
    _products.forEach(product => {

        productRowComponentArray.push(<ProductRow product={product} key={product.id} />);
    });

    return (
        <center>
            <br />
            <table border="1">
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
        </center>
    );

}