import React from 'react'

import IProductTableContainerProps from '../models/IProductTableContainerProps';
import IProductTableContainerState from '../models/IProductTableContainerState';

import { ProductTable } from './ProductTable';
import { ProductPageNumberBar } from './ProductPageNumberBar'

export class ProductTableContainer extends React.Component<IProductTableContainerProps, IProductTableContainerState> {

    constructor(props: IProductTableContainerProps) {
        super(props);
        this.state = { isLoaded: false, products: [] };
        this.onPageNumberChange = this.onPageNumberChange.bind(this);
    }

    componentDidMount() {
        fetch("https://localhost:5001/productapi?page=1")
            .then(res => res.json())
            .then(
                (result) => {
                    this.setState({
                        isLoaded: true,
                        products: result
                    });
                },
                (error) => {
                    this.setState({
                        isLoaded: true,
                        error
                    });
                }
            )
    }

    onPageNumberChange(value: number) {
        console.log(`Page Number Entered -> ${value}`);
        fetch(`https://localhost:5001/productapi?page=${value}`)
            .then(res => res.json())
            .then(
                (result) => {
                    this.setState({
                        isLoaded: true,
                        products: result
                    });
                },
                (error) => {
                    this.setState({
                        isLoaded: true,
                        error
                    });
                }
            )
    }

    render() {
        if (this.state.isLoaded) {
            return (
                <div>
                    <ProductPageNumberBar pageNumberChanged={this.onPageNumberChange}></ProductPageNumberBar>
                    <br />
                    <ProductTable products={this.state.products}></ProductTable>
                </div>
            );
        } else {
            return (
                <div>
                    <h3>Loading...</h3>
                </div>
            );
        }
    }

}