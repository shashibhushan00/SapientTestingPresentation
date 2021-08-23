export function ProductRow(props) {

    return (
        <tr>
            <td>{props.product.id}</td>
            <td>{props.product.name}</td>
            <td>{props.product.price}</td>
        </tr>
    )
}