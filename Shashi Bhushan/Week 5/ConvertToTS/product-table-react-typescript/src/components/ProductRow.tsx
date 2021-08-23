import React from "react"
import { IProductRowProps } from "../models/IProductRowProps"

export const ProductRow: React.FunctionComponent<IProductRowProps> = (props: IProductRowProps) => {

    return (
        <tr>
            <td>{props.product.id}</td>
            <td>{props.product.name}</td>
            <td>{props.product.price}</td>
        </tr>
    )
}